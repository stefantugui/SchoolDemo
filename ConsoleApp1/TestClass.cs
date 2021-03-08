namespace SchoolDemo
{
    using System;

    public class TestClass
    {
        public int numberOfRepetitions = 2;

        public string StringProp { get; set; }

        public void doWork()
        {
            char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
            string name = "";
            int[] a = new int[10];
            for (var j = 0; j < numberOfRepetitions; j++)
                for (int i = 0; i < letters.Length; i++)
                {
                    name += letters[i];
                    a[i] = i + 1;
                    Console.WriteLine("Hello, " + name + "! Count to " + a[i]);
                }
            Console.ReadKey();
        }
    }
}
