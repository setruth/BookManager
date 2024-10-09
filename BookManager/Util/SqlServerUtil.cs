using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BookManager.Util
{
    public class SqlServerUtil
    {
        public static List<T> ConvertDataTableToList<T>(DataTable dataTable) where T : new()
        {
            return dataTable.AsEnumerable().Select(row =>
            {
                var entity = new T();
                foreach (var prop in typeof(T).GetProperties())
                {
                    if (dataTable.Columns.Contains(prop.Name) && row[prop.Name] != DBNull.Value)
                    {
                        prop.SetValue(entity, Convert.ChangeType(row[prop.Name], prop.PropertyType));
                    }
                }
                return entity;
            }).ToList();
        }
    }
}