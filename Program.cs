using System;

namespace repro_dotnet
{
    public class TestClass<T> {
        public void DoStuff() {
            string p = "";
            var result = ((TestClass<T>?)null)?.DoOtherStuff(ref p);
        }

        public T? DoOtherStuff(ref string p) {
            return default;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
