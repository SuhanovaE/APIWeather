using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weathearap
{
     class WeatherResponse
    {
        public string Name { set; get; }
        public MainInfo Main { set; get; }

    }
    class MainInfo
    {
        public float Temp { set; get; }
    }
}
