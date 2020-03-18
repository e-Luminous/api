using System;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserIdentityController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserIdentityController(ApplicationDbContext context, 
            UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        
        [HttpPost]
        public async Task<JsonResult>Register(CustomModel customUser)
        {
            if (ModelState.IsValid)
            {
                var mailAddress = new MailAddress(customUser.Email);
                customUser.UserName = mailAddress.User;

                var customObj = new IdentityUser
                {
                    Id = Guid.NewGuid().ToString().Replace("-", ""),
                    Email = customUser.Email,
                    UserName = customUser.UserName,
                    PhoneNumber = customUser.Mobile
                };

                var userCreationResult = await _userManager.CreateAsync(customObj, customUser.PasswordHash);
                if (userCreationResult.Succeeded)
                {
                    var User_Role = customUser.Role;
                    if (User_Role == "Admin")
                    {
                        var roleId =
                            await _context.Database.ExecuteSqlInterpolatedAsync(
                                $"find_UserRoleId @roleName={User_Role}");
                        
                        var InstitutionObj = new Institution
                        {
                            Users = customObj
                        };
                        //await _userManager.AddToRoleAsync(customObj, roleId);

                        await _context.Database.ExecuteSqlInterpolatedAsync(
                            $"Insert_UserRoleInfo @UserId={customObj.Id} @RoleId={roleId}");
                        
                        _context.Add(customObj);
                        _context.Add(InstitutionObj);
                        
                        //await _signInManager(userObj, isPersistent: true);
                    }
                    /*
                    else if (User_Role == "Instructor")
                    {
                        var InstructorObj = new Instructor
                        {
                            Users = customObj
                        };
                        
                        var userRoleObj = new UserRole
                        {
                            Id = customObj.Id,
                            RoleId = "2"
                        };
                        
                        _context.Add(customObj);
                        _context.Add(InstructorObj);
                        _context.Add(userRoleObj);
                    }
                    else if (User_Role == "Student")
                    {
                        var StudentObj = new Student
                        {
                            Users = customObj
                        };
                        
                        var userRoleObj = new UserRole
                        {
                            Id = customObj.Id,
                            RoleId = "3"
                        };
                        
                        _context.Add(customObj);
                        _context.Add(StudentObj);
                        _context.Add(userRoleObj);
                    }
                    */
                    await _context.SaveChangesAsync();
                }
            }

            return Json("Yes");
        }
    }
}