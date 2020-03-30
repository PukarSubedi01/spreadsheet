using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_assignment
{
    public class ListManipulation
    {
        public List<double> GetAscendedList(IList<double> values) 
            //arranging the list in ascending order for finding the median 
        {
            bool flag;
            double temp;
            try
            {
                do
                {
                    flag = false;
                    for (int i = 0; i < values.Count - 1; i++)
                    {
                        if (values[i] > values[i + 1])
                        {
                            temp = values[i];
                            values[i] = values[i + 1];
                            values[i + 1] = temp;
                            flag = true;
                        }
                    }

                } while (flag == true);
                List<double> list = values.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }       
    }
}
