using Assignment9.Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    class EntityBase:IEntity
    {
        public void SetFields(DataRow dr)
        {
            Type tp = this.GetType();
            foreach (PropertyInfo pi in tp.GetProperties())
            {
                if (null!=pi && pi.CanWrite)
                {
                    string nm = pi.PropertyType.Name.ToUpper();
                    if (nm.IndexOf("ENTITY") >= 0)
                        break;
                    if (pi.PropertyType.Name.ToUpper() != "BINARY")
                        pi.SetValue(this, dr[pi.Name], null);
                }
            }
        }
        

    }
}
