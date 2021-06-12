﻿using MISA.Fresher.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Entities
{
    /// <summary>
    /// Các thuộc tính entity dùng chung
    /// </summary>
    /// CreatedBy : PQHieu (11/06/2021)
    public class BaseEntity
    {
        /// <summary>
        /// Ngày tạo
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string ModifiedBy { get; set; }

        public EntityState EntityState { get; set; } = EntityState.Add;
    }
}
