namespace TestingLibirly
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class triangle : BaseCalculate
    {
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        /// <summary>
        /// Периметр
        /// </summary>
        public double P { get; set; }

        public triangle(double side2, double side3, double side)
        {
            Side2 = side2;
            Side3 = side3;
            Side = side;
        }

        public override void CalculateSqaure()
        {
            double P2 = InitP()/2;
            double x = P2 *(P2-Side)*(P2-Side2)*(P2-Side3);

            S = System.Math.Sqrt(x);
        }

        double InitP()
        {
            return P = Side + Side2 + Side3;
            
        }

        public override string ToString()
        {
            return $"Площадь треугольника = {S}";
        } 
    }
}
