namespace SchoolDemo
{
    using System;

    public class TestClass
    {
        private string _privateString = "";

        public static int StaticInt = 2;

        public int NumberOfRepetitions = 2;

        public void DoWork()
        {
            char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
            string name = "";
            int[] a = new int[10];
            for (var j = 0; j < NumberOfRepetitions; j++)
                for (int i = 0; i < letters.Length; i++)
                {
                    name += letters[i];
                    a[i] = i + 1;
                    NewMethod(name, a[i]);
                }
        }

        private static void NewMethod(string name, int o)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + o);
        }
    }
}
