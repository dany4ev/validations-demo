using System.Collections.Generic;
using ValidationsDemo.Models;

namespace ServiceModels.Converters
{
    public static class UserConverter
    {
        //public static UserPUT Convert(this User model)
        //{
        //    return new UserPUT
        //    {
        //        Id = model.Id,
        //        Name = model.Name,
        //        Email = model.Email
        //    };
        //}

        //public static User Convert(this UserPUT model)
        //{
        //    return new User
        //    {
        //        Id = model.Id,
        //        Name = model.Name,
        //        Email = model.Email
        //    };
        //}

        //public static IEnumerable<User> Convert(this IEnumerable<UserPUT> model)
        //{
        //    foreach (var item in model)
        //        yield return Convert(item);
        //}

        //public static IEnumerable<UserPUT> Convert(this IEnumerable<User> model)
        //{
        //    foreach (var item in model)
        //        yield return Convert(item);
        //}

        public static UserPUT Convert(this UserPOST model)
        {
            return new UserPUT
            {
                Name = model.Name,
                Email = model.Email
            };
        }

        public static UserPOST Convert(this UserPUT model)
        {
            return new UserPOST
            {
                Name = model.Name,
                Email = model.Email
            };
        }

        public static IEnumerable<UserPOST> Convert(this IEnumerable<UserPUT> model)
        {
            foreach (var item in model)
                yield return Convert(item);
        }

        public static IEnumerable<UserPUT> Convert(this IEnumerable<UserPOST> model)
        {
            foreach (var item in model)
                yield return Convert(item);
        }
    }
}