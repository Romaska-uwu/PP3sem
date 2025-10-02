using System;

namespace lab01
{
    class Program
    {
        static void Main()
        {
            //C1
            Console.WriteLine("C1\n");
            C1 firstC1 = new C1();
            C1 secondC1 = new C1("second", "C1");
            C1 thirdC1 = new C1(secondC1);


            Console.WriteLine(firstC1.pubStrC1);
            Console.WriteLine(secondC1.pubStrC1);
            Console.WriteLine(thirdC1.publicProperty);

            firstC1.PublicMethod();


            //---------------------------------------------------------------------------

            //C2
            Console.WriteLine("\n\nC2\n");
            C2 firstC2 = new C2();
            C2 secondC2 = new C2(5, "secondC2");
            C2 thirdC2 = new C2(secondC2);

            firstC2.MethodI1();
            firstC2.propertyI1 = 4;

            Console.WriteLine(firstC2.pubStrC1);
            Console.WriteLine(secondC2.pubStrC1);
            Console.WriteLine(thirdC2.publicProperty);

            Console.WriteLine($"{firstC2.propertyI1}");
            firstC2.PublicMethod();

            //---------------------------------------------------------------------------

            Console.WriteLine("\n\nC4\n");
            C4 firstC4 = new C4();
            firstC4.MethodC3();
            firstC4.ShowFieldsC4();
        }
    }
}