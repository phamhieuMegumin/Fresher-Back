using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.Fresher.Core.Entities;
using MISA.Fresher.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Infracstructure.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        #region Field
        string _connectString;
        DynamicParameters dynamicParameters;
        #endregion
        #region Constructor
        public EmployeeRepository(IConfiguration configuration) : base(configuration)
        {
            dynamicParameters = new DynamicParameters();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Kiểm tra mã khách hàng đã tồn tại chưa
        /// </summary>
        /// <param name="employeeCode">Mã nhân viên</param>
        /// <param name="employeeId">ID của nhân viên</param>
        /// <returns>
        /// true - mã đã tồn tại
        /// false - mã chưa tồn tại
        /// </returns>
        /// CreatedBy : PQHieu (11/06/2021)
        public bool CheckEmployeeCodeExits(string employeeCode, Guid? employeeId)
        {
            dynamicParameters.Add("@m_employeeCode", employeeCode);
            dynamicParameters.Add("@m_employeeId", employeeId);
            var isExit = dbConnection.ExecuteScalar<bool>("Proc_CheckEmployeeCodeExists", dynamicParameters, commandType: CommandType.StoredProcedure);
            return isExit;
        }

        public string GetBiggestEmployeeCode()
        {
            var storeName = $"Proc_GetBiggestEmployeeCode";
            return dbConnection.ExecuteScalar<string>(storeName, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<Employee> GetByPaginationFilter(int pageInt, int pageSize, string filterString)
        {
            var storeName = $"Proc_GetEmployee_Pagination_Filter";
            dynamicParameters.Add("@m_PageSize", pageSize);
            dynamicParameters.Add("@m_PageInt", pageInt);
            dynamicParameters.Add("@m_Filter", filterString);
            return dbConnection.Query<Employee>(storeName, dynamicParameters, commandType: CommandType.StoredProcedure);
        }

        public int GetTotalByFilter(string filterString)
        {
            var storeName = $"Proc_GetTotal";
            dynamicParameters.Add("@m_Filter", filterString);
            return dbConnection.ExecuteScalar<int>(storeName, dynamicParameters, commandType: CommandType.StoredProcedure);
        }

        #endregion
    }
}
