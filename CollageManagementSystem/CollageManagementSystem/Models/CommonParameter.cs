using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollageManagementSystem.Models
{
    public class CommonParameter
    {
        
        public int? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }

        public int UserId { get; set; }

        public int YearId { get; set; }
    }
}