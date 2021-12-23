using TestingLibirly.Interfaces;

namespace TestingLibirly
{

    /// <summary>
    /// Базовый класс реализации вычисления площади
    /// </summary>
    public class BaseCalculate : Square
    {
        private double s;

        public double S { get

            {
                if (s != 0)
                {
                    return s;
                }            
            CalculateSqaure();
                return s;
            }

              set => s = value; }

        public double Side { get; set; }

        public BaseCalculate()
        {

        }

        public BaseCalculate(double side)
        {
            Side = side;
        }

        public virtual void CalculateSqaure()
        {
            S = Side * Side;
        }

        public override string ToString()
        {
            return $"Площадь = {S}";
        }
    }
}
