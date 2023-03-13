using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Reflection;

namespace WebAPI_Montensseri.Frameworks
{
    public static class Extensions
    {
        public static List<T> ToList<T>(this DataTable table) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            List<T> result = new List<T>();

            foreach (var row in table.Rows)
            {
                var item = CreateItemFromRow<T>((DataRow)row, properties);
                result.Add(item);
            }

            return result;
        }

        private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            try
            {
                T item = new T();
                foreach (var property in properties)
                {
                    if (row.Table.Columns.Contains("FLD" + property.Name))
                    {
                        object value = null;
                        object input = row["FLD" + property.Name.ToUpper()];
                        Type underlyingType = Nullable.GetUnderlyingType(property.PropertyType);

                        if (underlyingType == null)
                        {
                            if (!(input is DBNull))
                            {
                                value = Convert.ChangeType(input, property.PropertyType);
                            }
                        }
                        else
                        {
                            if (!(input is DBNull))
                            {
                                value = input == null || input.ToString() == "" ? null : Convert.ChangeType(input, underlyingType);
                            }
                        }

                        property.SetValue(item, value, null);
                    }
                }
                return item;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}