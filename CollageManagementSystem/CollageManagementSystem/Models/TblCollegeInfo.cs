using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollageManagementSystem.Models
{
    public class TblCollegeInfo :  CommonParameter
    {

        public int College_Id { get; set; }
        public string College_Code { get; set; }
        public string College_Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? Registration_Date { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Footer { get; set; }
        public string Currency { get; set; }
        public string CurrencySymbol { get; set; }
        public string SessionStartMonth { get; set; }
        public string SessionEndMonth { get; set; }
        public string EnableFrontend { get; set; }
        public string ExamFinalResult { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string FacebookURL { get; set; }
        public string TwitterURL { get; set; }
        public string LinkedinURL { get; set; }
        public string GooglePlusURL { get; set; }
        public string YoutubeURL { get; set; }
        public string InstagramURL { get; set; }
        public string PinterestURL { get; set; }
        public string clgpassword { get; set; }
        public string Logo { get; set; }
        public int? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}