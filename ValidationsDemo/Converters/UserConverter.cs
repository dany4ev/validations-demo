using ServiceModels;
using System.Collections.Generic;
using ValidationsDemo.Models;

namespace ValidationsDemo.Converters
{
    public static class UserConverter
    {
        public static UserPUT Convert(this User model)
        {
            return new UserPUT
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email
            };
        }

        public static User Convert(this UserPUT model)
        {
            return new User
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email
            };
        }

        public static IEnumerable<User> Convert(this IEnumerable<UserPUT> model)
        {
            foreach (var item in model)
                yield return Convert(item);
        }

        public static IEnumerable<UserPUT> Convert(this IEnumerable<User> model)
        {
            foreach (var item in model)
                yield return Convert(item);
        }
    }
}