using System;
namespace Teams
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Main Code Here
            League PL = new League();
            PL.fixture();
            PL.showTable();
            Console.WriteLine();
            PL.fixture1();
            PL.showTable();
            Console.WriteLine();
            PL.fixture2();
            PL.showTable();

        }
    }
}
