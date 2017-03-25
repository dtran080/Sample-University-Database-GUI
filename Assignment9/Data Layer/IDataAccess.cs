using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Data_Layer
{
    interface IDataAccess
    {
        object GetSingleAnswer(string sql, List<DbParameter> PList, SqlConnection conn = null,
            SqlTransaction sqtr = null, bool bTransaction = false);
        DataTable GetManyRowsCols(string sql, List<DbParameter> PList, SqlConnection conn = null,
            SqlTransaction sqtr = null, bool bTransaction = false);
        int InsertUpdateDelete(string sql, List<DbParameter> PList, SqlConnection conn = null,
            SqlTransaction sqtr = null, bool bTransaction = false);
    }
}
