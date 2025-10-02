using System;

namespace lab01
{
    public class C4 : C3
    {
        private string privStrC4 = "private string C4";

        public C4()
        {
            Console.WriteLine("Конструктор по умолчанию С4");
        }

        public void MethodC4()
        {
            Console.WriteLine("Метод С4");
        }

        public void ShowFieldsC4()
        {
            Console.WriteLine($"public string C3: {protStrC3}");
            Console.WriteLine($"private string C4: {privStrC4}");
        }
    }
}
