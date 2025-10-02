using System;

namespace lab01
{
    public class C1
    {
        private const int privateConst = 3;
        private string privStr = "private field";

        public const int pubConstInt = 23;

        public int pubInt1 = 15;
        public int pubIntC2 = 20;

        protected const int protConstInt1 = 6;

        protected int protIntC2 = 8;

        public string pubStrC1 = "public field";
        public string pubStr2 = "second public field";
        public string pubStrC2 = "third public field";

        protected string protStr = "protected Field";

        private int privateProperty { get; set; }
        public string? publicProperty { get; set; }
        protected int protectedProperty { get; set; }

        public C1()
        {
            Console.WriteLine("Конструктор по умолчанию С1");
        }

        public C1(C1 copy)
        {
            Console.WriteLine("Копирующий конструктор С1");
            publicProperty = copy.pubStrC1;
        }

        public C1(string pubStrC1, string pubStrC11)
        {
            Console.WriteLine("Конструктор по параметрам С1");
            this.pubStrC1 = pubStrC1;
            this.pubStr2 = pubStrC11;
        }


        private void PrivateMethod()
        {
            Console.WriteLine("Private method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("public method");
            PrivateMethod();
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("protected method");
        }
    }
}