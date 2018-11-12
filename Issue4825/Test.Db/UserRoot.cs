using Starcounter;
using System;
using Test.API;

namespace Test.Db
{
    [Database]
    public abstract class UserRoot : Persistent, IUser
    {
        private string m_name;

        public string Name => m_name;

        string IUser.Name { get => m_name; set => throw new NotImplementedException(); }

        protected void SetName(string value)
        {
            m_name = value;
        }
    }
}
