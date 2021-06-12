using MISA.Fresher.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Interfaces.Repository
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        /// <summary>
        /// Kiểm tra mã nhân viên đã tồn tại hay chưa
        /// </summary>
        /// <param name="employeeCode">Mã nhân viên</param>
        /// <param name="employeeId">ID của nhân viên</param>
        /// <returns>
        /// true - mã nhân viên đã tồn tại
        /// false - mã nhân viên chưa tồn tại
        /// </returns>
        /// CreatedBy: PQHieu(12/06/2021)
        bool CheckEmployeeCodeExits(string employeeCode, Guid? employeeId = null);

        /// <summary>
        /// Lấy mã nhân viên lớn nhất
        /// </summary>
        /// <returns>
        /// Mã nhân viên mới
        /// </returns>
        string GetBiggestEmployeeCode();

        /// <summary>
        /// Danh sách nhân viên qua filter
        /// </summary>
        /// <param name="pageInt">page hiện tại</param>
        /// <param name="pageSize">số bẩn ghi trên page</param>
        /// <param name="filterString">giá trị bộ lọc</param>
        /// <returns>
        /// Danh sách nhân viên 
        /// </returns>
        IEnumerable<Employee> GetByPaginationFilter(int pageInt, int pageSize, string filterString);

        /// <summary>
        /// Lấy số lượng bản ghi hợp lệ
        /// </summary>
        /// <param name="filterString">chuỗi điều kiện</param>
        /// <returns>
        /// Số lượng bản ghi hợp lệ
        /// </returns>
        int GetTotalByFilter(string filterString);
    }
}
