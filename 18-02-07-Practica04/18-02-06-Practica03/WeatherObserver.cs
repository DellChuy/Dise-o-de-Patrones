﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_06_Practica03
{
    interface WeatherObserver
    {
        void update(double temp, double hum, double presion);
    }
}
