using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// Represents a circle with a specific are calculation.
    /// </summary>
    class Circle : Shape
    {
        // Auto-implemented property for the raduis of the circle
        public double Raduis {  get; set; }

        /// <summary>
        /// Constructor for the Circle Class
        /// </summary>
        /// <param name="raduis"></param>
        public Circle(double radius)
        {
            Raduis = radius;
        }

        /// <summary>
        /// Display the area of a circle.
        /// </summary>
        public override void DisplayArea()
        {
            Console.WriteLine($"Circle Area: {Math.PI * Raduis * Raduis}");
        }
    }
}
