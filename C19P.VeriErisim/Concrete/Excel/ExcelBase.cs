using C19P.Veri.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.VeriErisim.Concrete.Excel
{
    public abstract class ExcelBase
    {
        protected OleDbConnection _oleDbConnection;
        protected OleDbCommand _oleDbCommand;
        protected string _yol = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CovidVeri.xlsx;Extended Properties=Excel 12.0 Xml;HDR=YES;";
       
        protected void BaglantiAc()
        {
            if (_oleDbConnection.State == ConnectionState.Closed)
                _oleDbConnection.Open();

        }
        
       
    }
}
