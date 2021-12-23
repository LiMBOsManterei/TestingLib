namespace TestingLibirly
{
    public class Circle : BaseCalculate
    {

        public double Radius { get; set; }

        public double Diametr { get; set; }

        const double P = 3.14;
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void CalculateSqaure()
        {
            S = P * (Radius * Radius);
        }

        public override string ToString()
        {
            return $"Площадь окружности по радиусу = {S}";
        }
    }

}
