﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class Factors 
    {
        // Насыщенность транспорта
        public float SaturationTrans { get; }
        // Процент заболевших
        public float ProcOfCases { get; }
        // Процент вакцинированных
        public float ProcOfVac { get; }

        public Factors()
        {
            ProcOfCases = new Random().Next(7);
            ProcOfVac = new Random().Next(20);
            SaturationTrans = (float)(new Random().Next(100)) / 100;
            Console.WriteLine(SaturationTrans);
        }
        
    }
}
