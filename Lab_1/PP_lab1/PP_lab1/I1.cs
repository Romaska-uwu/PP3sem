using System;

namespace lab01
{
    public interface I1
    {
        int propertyI1 { get; set; }

        void MethodI1();

        event EventHandler EventI1;
        int this[int index] { get; set; }
    }
}
