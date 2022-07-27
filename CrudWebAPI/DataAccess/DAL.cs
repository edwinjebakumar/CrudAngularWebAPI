using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWebAPI.Models;
using System.Data.SqlClient;
using System.Data;

namespace CrudWebAPI.DataAccess
{
    public class DAL
    {
        private string _connectionString = string.Empty;
        public DAL(string conn)
        {
            _connectionString = conn;
        }

        public List<Invoice> GetAllInvoices()
        {
            DataTable dt = new DataTable();
            int res = 0;
            List<Invoice> lst = new List<Invoice>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("sp_GetAllInvoices", sqlConnection))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        res = sqlDataAdapter.Fill(dt);
                    }
                }
            }
            if (res > 0 && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Add(new Invoice{
                        Id = Convert.ToInt32(dr["Id"]),
                        InvNumber = Convert.ToInt32(dr["INVOICENUMBER"]),
                        CustNumber = Convert.ToInt32(dr["CUSTOMERNUMBER"]),
                        InvDt = Convert.ToDateTime(dr["INVOICEDT"]),
                        Amount = Convert.ToDecimal(dr["AMOUNT"]),
                        VoidFlag = Convert.ToBoolean(dr["VOIDFLAG"]),
                    });
                }
            }

            return lst;
        }
    }
}