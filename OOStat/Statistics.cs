using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStat
{
    internal class Statistics
    {
        public string input;

        public string[] parsedInput()
        {
            return input.Split(",");
        }
        public string getValues()
        {
            string output = "";
            foreach(string str in parsedInput())
            {
                output += str;
            }
            return output;
        }
        public double getSum()
        {
            double sum = 0.00;
            foreach (string str in parsedInput())
            {
                sum += Convert.ToDouble(str);
            }
            return sum;
        }
        public int countElements()
        {
            return parsedInput().Count();
        }
        public double getMean()
        {
            return getSum() / countElements();
        }
        public double getVariance()
        {
            double vari = 0.00;
            foreach (string str in parsedInput())
            {
                vari += Math.Pow(Convert.ToDouble(str)-getMean(),2);
            }
            return vari / countElements();
        }
        public double getSD()
        {
            return Math.Sqrt(getVariance());
        }
    }
}
