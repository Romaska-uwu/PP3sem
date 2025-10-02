﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public class BonusA : IBonus {
        public float costOneHour { get; set; }
        public BonusA(float costOneHour) {
            this.costOneHour = costOneHour;
        }
        public float Calculate(float hoursOfWork) {
            return costOneHour * hoursOfWork;
        }
    }
    public class BonusAL2 : IBonus {
        public float costOneHour { get; set; }
        private float A { get; set; }
        public BonusAL2(float costOneHour, float A) {
            this.costOneHour = costOneHour;
            this.A = A;
        }
        public float Calculate(float hoursOfWork) {
            return (hoursOfWork + A) * costOneHour;
        }
    }
    public class BonusAL3 : IBonus
    {
        private float A { get; set; }
        private float B { get; set; }
        public float costOneHour { get; set; }
        public BonusAL3(float costOneHour, float A, float B) {
            this.costOneHour = costOneHour;
            this.A = A;
            this.B = B;
        }
        public float Calculate(float hoursOfWork) {
            return (hoursOfWork + A) * (costOneHour + B);
        }
    }
}