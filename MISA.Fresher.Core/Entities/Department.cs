﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Entities
{
    /// <summary>
    /// Phòng ban
    /// </summary>
    /// CreatedBy : PQHieu (11/06/2021)
    public class Department:BaseEntity
    {
        /// <summary>
        /// ID phòng ban
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public Guid DeparmentId { get; set; }

        /// <summary>
        /// Tên phòng ban
        /// </summary>
        /// CreatedBy : PQHieu (11/06/2021)
        public string DeparmentName { get; set; }
    }
}
