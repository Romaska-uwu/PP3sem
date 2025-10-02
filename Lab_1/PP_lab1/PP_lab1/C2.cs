using System;

namespace lab01
{
    public class C2 : C1, I1
    {
        public event EventHandler? EventI1;
        public int propertyI1 { get; set; }

        public int this[int index]
        {
            get { return protIntC2; }
            set { protIntC2 = 7; }
        }

        public C2()
        {
            Console.WriteLine("Конструктор по умолчанию С2");
        }

        public C2(C2 c)
        {
            Console.WriteLine("Конструктор копирования С2");
            publicProperty = c.pubStr2;
        }

        public C2(int pubIntC2, string pubStrC2)
        {
            Console.WriteLine("Конструктор с параметрами С2");
            this.pubIntC2 = pubIntC2;
            this.pubStrC2 = pubStrC2;
        }

        public void MethodI1()
        {
            Console.WriteLine("метод I1 в C2");
        }
    }
}





