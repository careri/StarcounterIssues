using System;
using System.IO;
using Starcounter;
using Test.TestApp;

// Uncomment this row to make it work
// using User = Test.UserModule.User;

namespace Test
{
    class Program
    {
        static void Main()
        {
            try
            {
                using (var t = new Transaction())
                {
                    t.Scope(() =>
                    {
                        var appFI = new FileInfo(typeof(Program).Assembly.Location);
                        var workDI = appFI.Directory;
                        var factory = UserFacade.Get(workDI);
                        var name = "apa";
                        var foo = factory.Create(name);
                        var foo2 = factory.Get(name);

                        if (!foo.Equals(foo2))
                        {
                            throw new ApplicationException("Mismatch");
                        }
                });
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}