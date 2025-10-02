using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public class BonusB : IBonus {
        private float x { get; set; }
        public float costOneHour { get; set; }
        public BonusB(float costOneHour, float x)
        {
            this.x = x;
            this.costOneHour = costOneHour;
        }
        public float Calculate(float hoursOfWork)
        {
            return costOneHour * hoursOfWork * x + 5;
        }
    }
    public class BonusBL2 : IBonus
    {
        private float x { get; set; }
        public float costOneHour { get; set; }
        private float A { get; set; }
        public BonusBL2(float costOneHour, float x, float A)
        {
            this.costOneHour = costOneHour;
            this.A = A;
            this.x = x;
        }
        public float Calculate(float hoursOfWork)
        {
            return (hoursOfWork + A) * costOneHour * x ;
        }
    }
    public class BonusBL3 : IBonus
    {
        private float A { get; set; }
        private float B { get; set; }
        private float x { get; set; }
        public float costOneHour { get; set; }
        public BonusBL3(float costOneHour, float x, float A, float B)
        {
            this.costOneHour = costOneHour;
            this.A = A;
            this.B = B;
            this.x = x;
        }
        public float Calculate(float hoursOfWork)
        {
            return (hoursOfWork + A) * (costOneHour + B) * x;
        }
    }
}