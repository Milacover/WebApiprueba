using APIService.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;
using Resources.RequestModels;
using Resources.FilterModels;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private ISecurityService _securityService;
        private IUserService _userService;
        public UserController(ISecurityService securityService, IUserService userService)
        //private readonly ILogger<ProductController> _logger;
        //public UserController(ILogger<ProductController> logger, IUserService userService)
        {
            //_logger = logger;
            _securityService = securityService;
            _userService = userService;
        }

        [HttpPost(Name = "InsertUser")]
        public int Post([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] NewUserRequest newUserRequest)
        {
            var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                return _userService.InsertUser(newUserRequest);
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        [HttpGet(Name = "GetAllUsers")]
        public List<UserItem> GetAll([FromHeader] string userName, [FromHeader] string userPassword)
        {
            var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                return _userService.GetAllUsers();
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] UserItem userItem)
        {
            var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                _userService.UpdateUser(userItem);
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromHeader] string userName, [FromHeader] string userPassword, [FromQuery] int id)
        {
            var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                _userService.DeleteUser(id);
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        //[HttpGet(Name = "GetUsersByCriteria")]
        //public List<UserItem> GetByCriteria([FromHeader] string userName, [FromHeader] string userPassword, [FromQuery] UserFilter userFilter)
        //{
            //var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
           // if (validCredentials == true)
            //{
                //return _userService.GetUsersByCriteria(userFilter);
            //}
            //else
            //{
                //throw new InvalidCredentialException();
            //}
        }
    }
