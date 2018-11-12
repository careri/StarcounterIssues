using System;
using System.IO;
using System.Reflection;
using Test.API;

namespace Test.TestApp
{
    public class UserFacade : IUserFactory
    {
        public static IUserFactory Get(DirectoryInfo di) => new UserFacade(di);


        private readonly IUserFactory m_factory;
        private UserFacade(DirectoryInfo di)
        {
            // Find an implementation of the IUserFactory
            m_factory = GetFactory(di);

        }

        private IUserFactory GetFactory(DirectoryInfo di)
        {
            // QAD to demonstrate
            var fi = new FileInfo(Path.Combine(di.FullName, "Test.UserModule.dll"));
            var an = AssemblyName.GetAssemblyName(fi.FullName);
            var ass = Assembly.Load(an);
            var type = ass.GetType("Test.UserModule.UserFactory");
            return (IUserFactory)Activator.CreateInstance(type);
        }

        public IUser Create(string name)
        {
            return m_factory.Create(name);
        }

        public IUser Get(string name)
        {
            return m_factory.Get(name);
        }
    }
}
