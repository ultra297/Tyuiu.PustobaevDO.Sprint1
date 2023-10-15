using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PustobaevDO.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {               
    public int FahrenheitToСelsius(double temp)
        {
            double res = Math.Pow(temp, 2) / Math.Sqrt(temp);
            return (int)res;
            
        }
    }
}

