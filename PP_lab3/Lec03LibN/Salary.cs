using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public class SalaryL1 : IFactory {
        public IBonus GetA(float costOneHour) {
            return new BonusA(costOneHour);
        }
        public IBonus GetB(float costOneHour, float x) {
            return new BonusB(costOneHour, x);
        }
        public IBonus GetC(float costOneHour, float x, float y) {
            return new BonusC(costOneHour, x, y);
        }
    }
    public class SalaryL2 : IFactory {
        private readonly float A;
        public SalaryL2(float A) {
            this.A = A;
        }
        public IBonus GetA(float costOneHour) {
            return new BonusAL2(costOneHour, A);
        }
        public IBonus GetB(float costOneHour, float x) {
            return new BonusBL2(costOneHour, x, A);
        }
        public IBonus GetC(float costOneHour, float x, float y) {
            return new BonusCL2(costOneHour, x, y, A);
        }
    }
    public class SalaryL3 : IFactory {
        private float A { get; set; }
        private float B { get; set; }
        public SalaryL3(float A, float B) {
            this.A = A;
            this.B = B;
        }
        public IBonus GetA(float costOneHour) {
            return new BonusAL3(costOneHour, A, B);
        }
        public IBonus GetB(float costOneHour, float x) {
            return new BonusBL3(costOneHour, x, A, B);
        }
        public IBonus GetC(float costOneHour, float x, float y) {
            return new BonusCL3(costOneHour, x, y, A, B);
        }
    }
}
