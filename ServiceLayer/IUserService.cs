using System.Collections.Generic;
using ValidationsDemo.Models;

namespace ServiceLayer
{
    public interface IUserService
    {
        void Delete(int id);
        IEnumerable<UserPUT> Get();
        UserPUT Get(int id);
        void Post(UserPOST model);
        void Put(UserPUT model);
    }
}