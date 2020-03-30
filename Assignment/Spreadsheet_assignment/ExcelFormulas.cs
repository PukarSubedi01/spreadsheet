using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_assignment
{
    public class ExcelFormulas
    {
        public double GetSum(List<double> ListedValues)
        {
           double Sum = 0;
            try
            {
                foreach (var Lv in ListedValues)
                    Sum += Lv;
                return Sum;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public double GetMean(List<double> ListedValues)
        {
            double sum = 0;
            double mean = 0;
            try
            {
                foreach (var Lv in ListedValues)
                    sum += Lv;
                mean = sum / ListedValues.Count;
                return mean;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public double GetMedian(List<double> ListedValues)
        {
            int item1 = 0;     //gets the item value for median
            int item2 = 0;      //gets the second item value for median
            double median = 0;
            try
            {
                if (ListedValues.Count % 2 == 1)
                {
                    item1 = (ListedValues.Count + 1) / 2;
                    median = ListedValues[item1 - 1];
                }
                else
                {
                    item1 = ListedValues.Count / 2;
                    item2 = (ListedValues.Count / 2) + 1;
                    median = (ListedValues[item1 - 1] + ListedValues[item2 - 1]) / 2;
                }
                return median;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public double GetMode(IList<double> Listedvalues) // this function finds maximum repeated value
        {
            double mode = 0;
            try
            {
                var groups = Listedvalues.GroupBy(x => x);
                var largest = groups.OrderByDescending(x => x.Count()).First();
                mode = Convert.ToInt32(largest.Key);
                return mode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public double GetMultiply(IList<double> Listedvalues)
        {
            double multiply = 1;
            try
            {
                foreach (var Lv in Listedvalues)
                  multiply *= Lv;
                return multiply;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
