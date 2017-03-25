using Assignment9.Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class DBList
    {
        public static List<T> ToList<T>(DataTable dt) where T: IEntity, new()
        {
            List<T> TList = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                T tp = new T();
                tp.SetFields(dr);
                TList.Add(tp);
            }
            return TList;
        }
    }
}
