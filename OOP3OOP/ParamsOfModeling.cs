using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class ParamsOfModeling
    {
        // Порог эпидемии заболевших в процентах 
        static public float SickTreshold { get; } = 45;
        // Шаг моделирования (в неделях)
        public static int StepOfModeling { get; } = 1;
        static private int mounths;
        // Период моделирования (в месяцах)
        public int Proc { get; set; }
        private int countLocality;

        // Время года
        public Season season;
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        public int CountLocality
        {
            get { return countLocality; }
            set {
                if (value >= 5 && value <= 10)
                {
                    countLocality = value;
                }
                else
                    countLocality = -1;
            }
        }

        static public int Mouths
        {
            get { return mounths; }
            set
            {
                if (value >= 6 && value <= 24)
                {
                    mounths = value;
                }
                else
                    mounths = -1;
            }
        }

        public ParamsOfModeling(int M, int N)
        {
            Mouths = M;
            CountLocality = N;
        }
    }
}
