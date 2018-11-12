using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.API;
using Test.Db;

namespace Test.UserModule
{
    internal class UserFactory : IUserFactory
    {
        public IUser Create(string name) => new User(name);

        public IUser Get(string name)
        {
            var query = $"SELECT f FROM {typeof(User).FullName} f WHERE f.{nameof(UserRoot.Name)}=?";
            return Starcounter.Db.SQL<User>(query, name).FirstOrDefault();
        }
    }
}
