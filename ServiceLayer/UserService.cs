using ServiceModels.Converters;
using ServiceModels.Validators;
using System.Collections.Generic;
using System.Linq;
using ValidationsDemo.Models;

namespace ServiceLayer
{
    public class UserService : BaseValidators, IUserService
    {
        private List<UserPUT> _users = new List<UserPUT>();

        public UserService()
        {
            _users.AddRange(
                new UserPUT[] {
                    new UserPUT
                    {
                        Id = 1,
                        Name = "test1",
                        Email = "test1@domain.com"
                    }, new UserPUT
                    {
                        Id = 2,
                        Name = "test2",
                        Email = "test2@domain.com"
                    }, new UserPUT
                    {
                        Id = 3,
                        Name = "test3",
                        Email = "test3@domain.com"
                    }
                });
        }

        public IEnumerable<UserPUT> Get()
        {
            return _users;
        }

        public UserPUT Get(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

        public void Post(UserPOST model)
        {
            if (RequiredObjectValidate(model) == null) return;

            // Note: additional cusom validation here returning custom response objects

            _users.Add(model.Convert());
        }

        public void Put(UserPUT model)
        {
            if (RequiredObjectValidate(model) == null) return;

            // Note: additional cusom validation here returning custom response objects

            if (_users.Any(user => user == model))
                _users.Add(model);
        }

        public void Delete(int id)
        {
            var model = _users.FirstOrDefault(user => user.Id == id);

            if (RequiredObjectValidate(model) == null) return;

            // Note: additional cusom validation here returning custom response objects

            if (_users.Any(user => user == model))
                _users.Remove(model);
        }
    }
}
