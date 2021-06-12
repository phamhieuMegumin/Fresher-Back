using MISA.Fresher.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Entities
{
    /// <summary>
    /// Nhân viên
    /// </summary>
    /// CreatedBy : PQHieu (11/06/2021)
    public class Employee:BaseEntity
    {
        /// <summary>
        /// ID nhân viên
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string FullName { get; set; }

        /// <summary>
        /// ID phòng ban
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public Guid DeparmentId { get; set; }

        /// <summary>
        /// giới tính
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public Gender? Gender { get; set; }

        /// <summary>
        /// Tên giới tính
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string GenderName
        {
            get
            {
                if (Gender == 0) return "Nữ";
                return "Nam";
            }
        }
        /// <summary>
        /// Ngày sinh nhân viên
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Số chứng minh nhân dân
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp chứng minh nhân dân 
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi cấp chứng minh nhân dân
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string IdentityPlace { get; set; }

        /// <summary>
        /// Chức vụ nhân viên
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string PositionName { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string Address { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Số cố định
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string LandlinePhone { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string Email { get; set; }

        /// <summary>
        /// Số tài khoản ngân hàng
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string BankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string BankName { get; set; }

        /// <summary>
        /// Chi nhánh ngân hàng
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string BankBranch { get; set; }
       
    }
}
