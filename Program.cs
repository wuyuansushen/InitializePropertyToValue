using System;

namespace InitializePropertyToValue
{
    internal class InitializeAutoProperty
    {
        public string Initialized { get; set; } = "Default auto property value";
    }
    internal class InitializeProperty
    {
        public string Initialized { get { return initialized; }
            //get=>initialized;
            set { if (value == "ABC")
                {
                    initialized = "Fuck ABC";
                }
                else
                    initialized = value;
            }
            } 

        private string initialized= "Default Property Value";

    }
    static class Program
    {
        static void Main(string[] args)
        {
            var TestAuto = new InitializeAutoProperty();
            Console.WriteLine($"AutoProperty:\nDefault Auto Property Value: {TestAuto.Initialized}\n");


            var Test = new InitializeProperty();
            Console.WriteLine($"Property:\nDefault Value: {Test.Initialized}");
            Test.Initialized = "ABC";
            Console.WriteLine($"Input 'ABC' Value: {Test.Initialized}");
            Test.Initialized = "abc";
            Console.WriteLine($"Input 'abc' Value: {Test.Initialized}");
        }
    }
}
