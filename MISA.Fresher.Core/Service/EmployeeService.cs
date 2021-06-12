using MISA.Fresher.Core.Entities;
using MISA.Fresher.Core.Exceptions;
using MISA.Fresher.Core.Interfaces.Repository;
using MISA.Fresher.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Service
{
    public class EmployeeService:BaseService<Employee>, IEmployeeService
    {

        #region Field
        IEmployeeRepository _employeeRepository;
        #endregion

        #region Constructor
        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion

        #region Methods
        protected override void Validate(Employee employee)
        {
            base.Validate(employee);
            var isDuplicateCode = false;
           
            // Kiểm tra trùng mã 
            if (employee.EntityState == Enum.EntityState.Add)
            {
                isDuplicateCode = _employeeRepository.CheckEmployeeCodeExits(employee.EmployeeCode);
            }
            else
            {
                isDuplicateCode = _employeeRepository.CheckEmployeeCodeExits(employee.EmployeeCode, employee.EmployeeId);
            }
            if (isDuplicateCode)
            {
                throw new ValidateException(Properties.Resources.Error_Employee_Code_Exits, employee.GetType().GetProperty("EmployeeCode").Name);
            }
           
        }
        #endregion
    }
}
