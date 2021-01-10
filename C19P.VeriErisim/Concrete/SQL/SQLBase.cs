using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.VeriErisim.Concrete.SQL
{
    public abstract class SQLBase
    {
        protected string _yol = @"Data Source=CASPERNIRVANA\SQLEXPRESS;Initial Catalog = CovidVeri; Integrated Security = True";
        protected SqlConnection _sqlConnection;
        protected SqlCommand _sqlCommand;
        protected void BaglantiAc()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
                _sqlConnection.Open();
        }
    }
}
