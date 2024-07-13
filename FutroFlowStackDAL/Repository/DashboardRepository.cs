using FutroFlowStackDAL.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using FutroFlowStackDAL.OracleConfig;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Dapper;

namespace FutroFlowStackDAL.Repository
{
    public class DashboardRepository: IDashboardRepository
    {
        private readonly IConfiguration _configuration;
       
        public DashboardRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<object> GetHomePage(int token)
        {
            object result = null;

            try
            {
                var Param = new OracleDynamicParameter();

                Param.Add("token", OracleDbType.NVarchar2, ParameterDirection.Input, token.ToString());
                Param.Add("Result_refs", OracleDbType.RefCursor, ParameterDirection.Output);

                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var query = "Dashboard.get_common_data";

                    result = SqlMapper.Query(conn, query, param: Param, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex) {
                throw ex;
            }
           
            return result;
        }
        public IDbConnection GetConnection()
        {
            var connectionString = _configuration.GetSection("ConnectionStrings").GetSection("Database").Value;
            var conn = new OracleConnection(connectionString);
            return conn;
        }
    }

}

