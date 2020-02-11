using CollageManagementSystem.ApplicationClasses;
using CollageManagementSystem.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace CollageManagementSystem.Controllers
{
    public class IndexController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [Route("api/index/getsigninuser")]
        [HttpGet]
        public IHttpActionResult GetSignInUserDetails()
        {
            var userStore = new UserStore<ApplicationUser, Role, int, UserLogin, UserRole, UserClaim>(db);
            var userManager = new UserManager<ApplicationUser, int>(userStore);
            var userId = Convert.ToInt32(User.Identity.GetUserId());

            var roles = ((ClaimsIdentity)User.Identity).Claims
                  .Where(c => c.Type == ClaimTypes.Role)
                  .Select(c => c.Value).FirstOrDefault();

            var rolesIds = ((ClaimsIdentity)User.Identity).Claims
                .Where(c => c.Type == ClaimTypes.Role);

            var signInUsers = new SignInUser
            {
                UserId = userId,
                Role = roles == null ? "" : roles.ToString().ToLower(),
                College_Id = db.Users.FirstOrDefault(x => x.Id == userId).CollegeId
                //  UserPermissions = roles == null ? db.Menu.Select(x => x.Name).ToList() : db.MenuRoles.Where(x => x.Roles.Name == roles.ToString()).Select(x => x.Menus.Name).ToList()
            };

            return Ok(new
            {
                signInUser = signInUsers
            });
        }
    }
}
