using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_assignment
{
   public class Operation
    {
        public double GetCalculation(string operation, IList<double> values)
        {

            double result = 0;
            ListManipulation LM = new ListManipulation();
            ExcelFormulas ef = new ExcelFormulas();
            List<double> AccendedList = LM.GetAscendedList(values);
            try
            {
                switch (operation)
                {
                    case "SUM":
                        result = ef.GetSum(AccendedList);
                        break;
                    case "MEAN":
                        result = ef.GetMean(AccendedList);
                        break;
                    case "MEDIAN":
                        result = ef.GetMedian(AccendedList);
                        break;
                    case "MODE":
                        result = ef.GetMode(AccendedList);
                        break;
                    case "*":
                        result = ef.GetMultiply(AccendedList);
                        break;
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
       
    }
}
