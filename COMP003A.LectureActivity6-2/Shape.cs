using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// Represents a base class for geometric shapes.
    /// </summary>
    class Shape
    {
        /// <summary>
        /// Displays the area of a shape.
        /// </summary>
        public virtual void DisplayArea()
        {
            Console.WriteLine("Calculating area of a shape");
        }
    }
}
