using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Thandizo.DAL.Models;

namespace Thandizo.DAL.EF.Extensions
{
    public static class DbExtensions
    {
        public static async Task<IEnumerable<TModel>> FromSprocAsync<TModel>(this thandizoContext context, string sproc, IDictionary<string, object> parameters = null)
           where TModel : new()
        {
            IEnumerable<TModel> data = Enumerable.Empty<TModel>();
            await context.Database.OpenConnectionAsync();
            var command = context.Database.GetDbConnection().CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sproc;

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    var dbParameter = command.CreateParameter();
                    dbParameter.ParameterName = parameter.Key;
                    dbParameter.Value = parameter.Value;
                    command.Parameters.Add(dbParameter);
                }
            }

            using (var reader = await command.ExecuteReaderAsync())
            {
                data = await reader.MapToListAsync<TModel>();
            }
            return data;
        }

        public static async Task<IEnumerable<T>> MapToListAsync<T>(this DbDataReader reader)
           where T : new()
        {
            if (reader != null && reader.HasRows)
            {
                var item = typeof(T);
                var items = new List<T>();
                var propertySet = new Dictionary<string, PropertyInfo>();
                var properties = item.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                propertySet = properties.ToDictionary(p => p.Name.ToUpper(), p => p);

                while (await reader.ReadAsync())
                {
                    var newItem = new T();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var key = reader.GetName(i).ToUpper();

                        if (propertySet.ContainsKey(key))
                        {
                            var propertyInfo = propertySet[key];

                            if ((propertyInfo != null) && propertyInfo.CanWrite)
                            {
                                var value = reader.GetValue(i);
                                propertyInfo.SetValue(newItem, (value == DBNull.Value) ? null : value, null);
                            }
                        }
                    }
                    items.Add(newItem);
                }
                return items;
            }
            return null;
        }
    }
}
