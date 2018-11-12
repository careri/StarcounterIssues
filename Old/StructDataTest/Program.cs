using System;
using Starcounter;

namespace StructDataTest
{
    public struct MyStruct
    {
        private readonly string m_name;

        public MyStruct(string name)
        {
            m_name = name;
        }

        public string Name
        {
            get { return m_name; }
        } 
    }

    public class StructWrapper
    {
        public MyStruct StructData { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var data = new MyStruct("apa");
            var wrapper = new StructWrapper { StructData = data };
            var json = new WrapperJson { Data = wrapper };
            var jsonStr = json.ToJson();
        }
    }
}