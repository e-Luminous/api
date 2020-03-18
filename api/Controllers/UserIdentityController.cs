using System;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

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

        
        [HttpPost("register")]
        public async Task<IActionResult>Register(CustomModel customUser)
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
                    

                    //return Json(test.ToString());
                    //return Ok(test.ToString());
                    
                    if (User_Role == "Admin")
                    {
                        //var roleId =
                            //await _context.Database.ExecuteSqlInterpolatedAsync(
                               // $"EXEC find_UserRoleId @roleName={User_Role}");
                        
                        
                        var InstitutionObj = new Institution
                        {
                            InstitutionId = Guid.NewGuid().ToString().Replace("-", ""),
                            Users = customObj
                        };
                       
                        //await _userManager.AddToRoleAsync(customObj, roleId);

                        // Data Insert on UserRole Table
                        await _context.Database.ExecuteSqlInterpolatedAsync
                            ($"EXEC Insert_UserRoleInfo @UserId={customObj.Id}, @RoleId={"1"}");
                        
                        _context.Add(customObj);
                        _context.Add(InstitutionObj);
                        //await _signInManager(userObj, isPersistent: true);
                    }
                    else if (User_Role == "Instructor")
                    {
                        var InstructorObj = new Instructor
                        {
                            InstructorId = Guid.NewGuid().ToString().Replace("-", ""),
                            Users = customObj
                        };

                        // Data Insert on UserRole Table
                        await _context.Database.ExecuteSqlInterpolatedAsync
                            ($"EXEC Insert_UserRoleInfo @UserId={customObj.Id}, @RoleId={"2"}");
                        
                        _context.Add(customObj);
                        _context.Add(InstructorObj);
                    }
                    else if (User_Role == "Student")
                    {
                        var StudentObj = new Student
                        {
                            StudentId = Guid.NewGuid().ToString().Replace("-", ""),
                            Users = customObj
                        };
                        
                        // Data Insert on UserRole Table
                        await _context.Database.ExecuteSqlInterpolatedAsync
                            ($"EXEC Insert_UserRoleInfo @UserId={customObj.Id}, @RoleId={"3"}");
                        
                        _context.Add(customObj);
                        _context.Add(StudentObj);
                    }
                    await _context.SaveChangesAsync();
                }
            }

            return Json("Yes");
        }
    }
}