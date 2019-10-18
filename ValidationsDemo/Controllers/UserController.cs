using ServiceLayer;
using System.Collections.Generic;
using System.Web.Http;
using ValidationsDemo.Models;

namespace ValidationsDemo.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<UserPUT> Get()
        {
            var response = _userService.Get();
            return response;
        }

        // GET api/values/5
        [HttpGet]
        public UserPUT Get(int id)
        {
            var response = _userService.Get(id);
            return response;
        }

        // POST api/values
        [HttpPost]
        public void Post(UserPOST model)
        {

            _userService.Post(model);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(UserPUT model)
        {

            _userService.Put(model);
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {

            _userService.Delete(id);
        }
    }
}
