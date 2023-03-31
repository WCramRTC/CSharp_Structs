using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Structs
{
    internal class PointClass
    {
        int _x;
        int _y;

        public PointClass(int x, int y)
        {
            _x = x;
            _y = y;
        } // Point()

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }


        public override string ToString()
        {
            return $"Class ( X: {X} - Y: {Y} )";
        } // ToString()
    }
}
