﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalcService
{
    public class CalcService : ICalcService
    {
        public int GetMul(int a, int b)
        {
            return (a*b);
        }

        public int GetSum(int a, int b)
        {
            return (a+b);
        }

        public int GetTotal(int a, int b) {

            return ((a * a) + (b * b));
        }
        
         public int GetRemainder(int a, int b) {

            return a;
        }
    }
}
