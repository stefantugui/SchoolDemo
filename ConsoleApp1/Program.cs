namespace SchoolDemo
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Action a;

            var testObject = new TestClass();

            testObject.doWork();
            Thread.Sleep(1);
        }
    }
}
