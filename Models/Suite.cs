using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2.Models
{
    public class Suite
    {
        public Suite(string suiteType, int capacity, decimal dailyRate)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            DailyRate = dailyRate;
        }
        private string SuiteType;

        public int Capacity {get;}

        public decimal DailyRate {get;}
    }
}