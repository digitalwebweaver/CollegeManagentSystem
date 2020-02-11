using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CollageManagementSystem.Models
{
    public class IdentityModels
    {


        // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
        // New derived classes
        public class UserRole : IdentityUserRole<int>
        {
        }

        public class UserClaim : IdentityUserClaim<int>
        {
        }

        public class UserLogin : IdentityUserLogin<int>
        {
        }

        public class Role : IdentityRole<int, UserRole>
        {
            public Role() { }
            public Role(string name) { Name = name; }
        }

        public class UserStore : UserStore<ApplicationUser, Role, int,
            UserLogin, UserRole, UserClaim>
        {
            public UserStore(ApplicationDbContext context) : base(context)
            {
            }
        }

        public class RoleStore : RoleStore<Role, int, UserRole>
        {
            public RoleStore(ApplicationDbContext context) : base(context)
            {
            }
        }

        // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
        public class ApplicationUser : IdentityUser<int, UserLogin, UserRole, UserClaim>
        {
            public string RefPassword { get; set; }
            public int? StudentIdOfParent { get; set; }

            public bool IsParent { get; set; }


            public int? CollegeId { get; set; }


            [ForeignKey("CollegeId")]
            public virtual TblCollegeInfo Colleges { get; set; }

            [ForeignKey("StudentIdOfParent")]
            public virtual ApplicationUser User { get; set; }


            //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)  //  comment by yogini  on  11-02-2020 hving error  check later
            //{
            //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            //   //
            //    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            //    // Add custom user claims here
            //    return userIdentity;
            //}
        }

        public class ApplicationDbContext : IdentityDbContext<ApplicationUser, Role, int,
            UserLogin, UserRole, UserClaim>
        {
            public ApplicationDbContext()
                : base("DbConnection")
            {
            }


            //   make  all  seperate  modal  ---- 11022020  yogini
            //public DbSet<TblDesignations> TblDesignations { get; set; }
            //public DbSet<TblEmployeeDepartments> TblEmployeeDepartments { get set; }
            //public DbSet<TblEmployeeMaster> TblEmployeeMaster { get; set; }
            //public DbSet<TblHostel> TblHostel { get; set; }
            //public DbSet<TblHostelMaster> TblHostelMaster { get; set; }
            //public DbSet<TblHostelRequired> TblHostelRequired { get; set; }
            //public DbSet<TblMaritalStatus> TblMaritalStatus { get; set; }
            //public DbSet<TblModule> TblModule { get; set; }
            //public DbSet<TblNoticeBoard> TblNoticeBoard { get; set; }
            //public DbSet<TblNoticeRoles> TblNoticeRoles { get; set; }
            //public DbSet<TblNursingCategory> TblNursingCategory { get; set; }
            //public DbSet<TblParentMenu> TblParentMenu { get; set; }
            //public DbSet<TblParentMenuRole> TblParentMenuRole { get; set; }
            //public DbSet<TblProgramMaster> TblProgramMaster { get; set; }
            //public DbSet<TblRelation> TblRelation { get; set; }
            //public DbSet<TblRole> TblRole { get; set; }
            //public DbSet<TblRoomType> TblRoomType { get; set; }
            //public DbSet<TblSemesterMaster> TblSemesterMaster { get; set; }
            //public DbSet<Tblsendemaillevels> Tblsendemaillevels { get; set; }
            //public DbSet<Tblsendemailsms> Tblsendemailsms { get; set; }
            //public DbSet<Tblsendemailsmsroles> Tblsendemailsmsroles { get; set; }
            //public DbSet<Tblsendemailusers> Tblsendemailusers { get; set; }
            //public DbSet<TblStudentAttendance> TblStudentAttendance { get; set; }
            //public DbSet<Tblstudentdocs> Tblstudentdocs { get; set; }
            //public DbSet<TblSubjectMaster> TblSubjectMaster { get; set; }
            //public DbSet<TblUploadcontent> TblUploadcontent { get; set; }
            //public DbSet<Tbluploadcontent_assign_role> Tbluploadcontent_assign_role { get; set; }
            //public DbSet<Tbluploadcontent_multi_file> Tbluploadcontent_multi_file { get; set; }
            //public DbSet<TblLevelMaster> TblLevelMaster { get; set; }
            //public DbSet<TblLanguage> TblLanguage { get; set; }
            //public DbSet<TblStateMaster> TblStateMaster { get; set; }
            //public DbSet<TblCountryMaster> TblCountryMaster { get; set; }
            //public DbSet<TblStudentInfo> TblStudentInfo { get; set; }
            //public DbSet<TblAssignLevelProgram> TblAssignLevelProgram { get; set; }
            //public DbSet<TblAssignSubject> TblAssignSubject { get; set; }
            //public DbSet<TblAttendanceCategory> TblAttendanceCategory { get; set; }
            //public DbSet<TblChildMenu> TblChildMenu { get; set; }
            //public DbSet<TblChildMenuRoles> TblChildMenuRoles { get; set; }
            //public DbSet<TblCityMaster> TblCityMaster { get; set; }
            //public DbSet<TblCollegeInfo> TblCollegeInfo { get; set; }


            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }




    }
}