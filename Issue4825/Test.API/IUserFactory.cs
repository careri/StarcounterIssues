using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.API
{
    public interface IUserFactory
    {
        IUser Create(string name);

        IUser Get(string name);
    }
}
