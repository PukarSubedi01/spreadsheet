using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spreadsheet_assignment
{
    class Conditions
    {
        public List<double> GetListSameColumn(Values val, DataGridView dgv)   
            //return list of value with same column
        {
            List<double> ValuesList = new List<double>();
            try
            {
                if (val.FirstRow < val.EndingRow)
                {
                    for (int i = val.FirstRow - 1; i <= val.EndingRow - 1; i++)
                    {
                        ValuesList.Add(Convert.ToDouble(dgv.Rows[i].Cells[val.FirstColumn.ToString()].Value));

                    }
                }
                else
                {
                    for (int i = val.EndingRow - 1; i <= val.FirstRow - 1; i++)
                    {
                        ValuesList.Add(Convert.ToDouble(dgv.Rows[i].Cells[val.FirstColumn.ToString()].Value));

                    }
                }
                return ValuesList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<double> GetListSameRow(Values val , DataGridView dgv)       
            //return list of value with same row
        {
            List<double> ValuesList = new List<double>();
            try
            {
                if (val.FirstColumn < val.EndingColumn)
                {
                    for (char i = val.FirstColumn; i <= val.EndingColumn; i++)
                    {
                        ValuesList.Add(Convert.ToDouble(dgv.Rows[val.FirstRow - 1].Cells[Convert.ToString(i)].Value));

                    }
                }
                else
                {
                    for (char i = val.EndingColumn; i <= val.FirstColumn; i++)
                    {
                        ValuesList.Add(Convert.ToDouble(dgv.Rows[val.FirstRow - 1].Cells[Convert.ToString(i)].Value));
                    }
                }
                return ValuesList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<double> GetListDiffRowCol(Values val, DataGridView dgv)        
            //return list of value with different column and different row.
        {
            List<double> ValuesList = new List<double>();


            try
            {
                if (val.FirstRow < val.EndingRow && val.FirstColumn < val.EndingColumn)
                {
                    for (char i = val.FirstColumn; i <= val.EndingColumn; i++)
                    {
                        for (int j = val.FirstRow - 1; j <= val.EndingRow - 1; j++)
                        {
                            ValuesList.Add(Convert.ToDouble(dgv.Rows[j].Cells[Convert.ToString(i)].Value));

                        }
                    }
                }
                else if (val.FirstRow < val.EndingRow && val.FirstColumn > val.EndingColumn)
                {
                    for (char i = val.EndingColumn; i <= val.FirstColumn; i++)
                    {
                        for (int j = val.FirstRow - 1; j <= val.EndingRow - 1; j++)
                        {
                            ValuesList.Add(Convert.ToDouble(dgv.Rows[j].Cells[Convert.ToString(i)].Value));

                        }
                    }
                }
                else if (val.FirstRow > val.EndingRow && val.FirstColumn < val.EndingColumn)
                {
                    for (char i = val.FirstColumn; i <= val.EndingColumn; i++)
                    {
                        for (int j = val.EndingRow - 1; j <= val.FirstRow - 1; j++)
                        {
                            ValuesList.Add(Convert.ToDouble(dgv.Rows[j].Cells[Convert.ToString(i)].Value));

                        }
                    }
                }
                else
                {
                    for (char i = val.EndingColumn; i <= val.FirstColumn; i++)
                    {
                        for (int j = val.EndingRow - 1; j <= val.FirstRow - 1; j++)
                        {
                            ValuesList.Add(Convert.ToDouble(dgv.Rows[j].Cells[Convert.ToString(i)].Value));

                        }
                    }
                }
                return ValuesList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
