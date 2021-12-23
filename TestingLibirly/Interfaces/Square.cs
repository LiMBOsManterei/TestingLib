using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLibirly.Interfaces
{
    /// <summary>
    /// Интерфейс предстваляющий вычисление площади
    /// </summary>
    public interface Square
    {

        /// <summary>
        /// Площадь
        /// </summary>
        double S { get; set; }


        /// <summary>
        /// Метод вычисления площади
        /// </summary>
        void CalculateSqaure();

        

    }
}
