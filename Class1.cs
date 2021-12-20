using System;
using System.Collections.Generic;
using System.Text;

namespace _1_4
{
     public class Range
    {
        private int a;
        private int b;

        public Range(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int aa
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int bb
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        

        public void check(int o)
        {

            if (o >= this.aa  && o < this.bb)
            {
                Console.WriteLine("Точка принадлежит заданному интервалу");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит заданному интервалу");
            }

        }
       
    }
}
