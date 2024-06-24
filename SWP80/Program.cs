using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP80
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        
    }
    class Quader
    {
        private int _lenght;
        private int _width;
        private int _height;

        public int Length => _lenght;
        public int Width => _width; 
        public int Height => _height;


        public Quader(int length,int width,int height)
        {
            _lenght = length;
            _width = width;
            _height = height;
        }

        public int Oberflaeche()
        {
            return 2 * (_lenght * _width) + 2 * (_height * _width) + 2 * (_lenght * _height);
        }

    }
}
