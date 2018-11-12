using Starcounter;
using Test.Db;

namespace Test.UserModule
{
    [Database]
    public class User : UserRoot
    {
        internal User(string name)
            : base()
        {
            SetName(name);
        }

        internal new void SetName(string value)
        {
            base.SetName(value);
        }

        //public string DummyField { get; set; }
    }
}
