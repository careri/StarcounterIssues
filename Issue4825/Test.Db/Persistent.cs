using Starcounter;
using System;
using Test.API;

namespace Test.Db
{
    [Database]
    public abstract class Persistent : IPersistent
    {
        protected Persistent()
        {
            Created = DateTime.Now;
        }

        public DateTime Created { get; }
    }
}