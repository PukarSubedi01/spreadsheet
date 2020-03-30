using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spreadsheet_assignment
{
    public partial class Spreadsheet : Form
    {
        string FinalValue = "";
        List<string> formulasList = new List<string>();
        int colIndex = -1;
        int rowIndex = -1;
        public Spreadsheet()
        {
            InitializeComponent();
         
        }

        private void Spreadsheet_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 26;
            dataGridView1.RowCount = 26;
            dataGridView1.RowHeadersWidth = 49;
            for (int i = 0; i < 26; i++)
            {
                dataGridView1.Columns[i].Name = Convert.ToString(Convert.ToChar(i + 'A'));
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            RowColBox.Text = dataGridView1.CurrentCell.OwningColumn.HeaderText + 
                dataGridView1.CurrentCell.OwningRow.HeaderCell.Value;
           FormulaBar.Text = Convert.ToString(dataGridView1[dataGridView1.CurrentCell.ColumnIndex, 
               dataGridView1.CurrentCell.RowIndex].Value);
            UserInterface();
            ComboBoxItem();

        }
        private void UserInterface()
        {
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
       private void ComboBoxItem()
        {
            FormulaBox.Text = "Formulas";
            FormulaBox.Items.Add("=SUM A1:A2 (For addition)");
            FormulaBox.Items.Add("=MEAN A1:A2 (For mean)");
            FormulaBox.Items.Add("=MEDIAN A1:A2 (For median)");
            FormulaBox.Items.Add("=MODE A1:A2 (For mode)");
            FormulaBox.Items.Add("=A1*A2 (For multiplication)");
        }
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Values val = new Values();
            //finds out the value entered in a cell
            val.CellValue = Convert.ToString(dataGridView1.CurrentCell.Value); 
            Conditions c = new Conditions();
            Operation op = new Operation();
            //removes duplicates from the list
            formulasList = formulasList.Distinct().ToList(); 
            try
            {
                if (formulasList.Count > 0)
                {
                    if (val.CellValue.StartsWith("=") || val.CellValue.Contains("*"))
                    {
                        val.CellValue = Convert.ToString(dataGridView1.CurrentCell.Value);
                        FinalValue = "";

                    }
                    else
                        val.CellValue = FinalValue;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (val.CellValue.StartsWith("="))
                {
                    try
                    {
                        if (FinalValue == "")
                        {
                            rowIndex = e.RowIndex;
                            colIndex = e.ColumnIndex;
                            FinalValue = val.CellValue;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        if (val.CellValue.Contains("*"))
                        {
                            
                            val.FirstColumn = 
                                Convert.ToChar(val.CellValue.Substring(val.CellValue.IndexOf('=') + 1, 1).ToUpper());
                            val.EndingColumn =
                                Convert.ToChar(val.CellValue.Substring(val.CellValue.IndexOf('*') + 1, 1).ToUpper());
                            val.FirstHalf = 
                                val.CellValue.Substring(1, val.CellValue.IndexOf('*') - 1);
                            val.FirstRow =
                                Convert.ToInt32(val.FirstHalf.Substring(1));
                            val.EndingRow = 
                                Convert.ToInt32(val.CellValue.Substring(val.CellValue.IndexOf('*') + 2));
                            

                            try
                            {
                                if (val.FirstColumn == val.EndingColumn)
                                {
                                    dataGridView1.Rows[rowIndex].Cells[colIndex].Value = op.GetCalculation("*", 
                                        c.GetListSameColumn(val,
                                        dataGridView1));

                                }
                                else if (val.FirstRow == val.EndingRow)
                                {
                                    dataGridView1.Rows[rowIndex].Cells[colIndex].Value = op.GetCalculation("*",
                                        c.GetListSameRow(val, dataGridView1));

                                }
                                else
                                {
                                    dataGridView1.Rows[rowIndex].Cells[colIndex].Value = op.GetCalculation("*", 
                                        c.GetListDiffRowCol(val, dataGridView1));
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        if (val.CellValue.Contains(":"))
                        {
                            //Finds which algorithm to perform...
                            val.KeyOperation = val.CellValue.Substring(1, val.CellValue.IndexOf(' ') - 1).ToUpper();
                            //finds starting column in a formula
                            val.FirstColumn = Convert.ToChar(val.CellValue.Substring(val.CellValue.IndexOf(' ') + 1, 1).ToUpper());
                            //finds ending column in a formula
                            val.EndingColumn = Convert.ToChar(val.CellValue.Substring(val.CellValue.IndexOf(':') + 1, 1).ToUpper());
                            //stores first half of the formula.
                            val.FirstHalf = val.CellValue.Substring(1, val.CellValue.IndexOf(':') - 1);
                            //stores first row value.
                            val.FirstRow = Convert.ToInt32(val.FirstHalf.Substring(val.FirstHalf.IndexOf(' ') + 2));
                            //stores ending row value.
                            val.EndingRow = Convert.ToInt32(val.CellValue.Substring(val.CellValue.IndexOf(':') + 2)); 
                            try
                            {
                                if (val.FirstColumn == val.EndingColumn)
                                {
                                    dataGridView1.Rows[rowIndex].Cells[colIndex].Value = op.GetCalculation(val.KeyOperation, 
                                        c.GetListSameColumn(val, dataGridView1));

                                }
                                else if (val.FirstRow == val.EndingRow)
                                {


                                    dataGridView1.Rows[rowIndex].Cells[colIndex].Value = op.GetCalculation(val.KeyOperation, 
                                        c.GetListSameRow(val, dataGridView1));

                                }
                                else
                                {
                                    dataGridView1.Rows[rowIndex].Cells[colIndex].Value = op.GetCalculation(val.KeyOperation,
                                        c.GetListDiffRowCol(val, dataGridView1));
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    FinalValue = val.CellValue;
                    formulasList.Add(FinalValue);
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<double> values = new List<double>();   //stores selected values
            List<int> rowIndexes = new List<int>();  //stores row index
            List<int> columnIndexes = new List<int>(); //stores column index
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                var value = dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value;
                values.Add(Convert.ToInt32(value));
                rowIndexes.Add(cell.RowIndex);
                columnIndexes.Add(cell.ColumnIndex);
            }
            ArrayList chars = new ArrayList();
            List<double> uniqueValues = new List<double>();

            int valueIndex = 0;
            foreach (int s in columnIndexes)
            {
                int charIndex = 0;
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    if (charIndex == s)
                    {
                        if (!chars.Contains(c))
                        {
                            uniqueValues.Add(values[valueIndex]);
                            chars.Add(c);
                        }
                        else
                        {
                            uniqueValues[chars.IndexOf(c)] += values[valueIndex];
                        }
                    }
                    charIndex++;

                }
                valueIndex++;

            }
            string[] letters = new string[chars.Count];
            int index = 0;
            foreach (char c in chars)
            {
                letters[index] = c.ToString();
                index++;
            }

            int[] dataValues = new int[uniqueValues.Count];
            int arrIndex = 0;
            foreach (int val in uniqueValues)
            {
                dataValues[arrIndex] = val;
                arrIndex++;
            }

            BarChart bc = new BarChart(letters, dataValues);
            bc.Show();

        }

        
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            RowColBox.Text = dataGridView1.CurrentCell.OwningColumn.HeaderText + 
                dataGridView1.CurrentCell.OwningRow.HeaderCell.Value;
            FormulaBar.Text = Convert.ToString(dataGridView1.CurrentCell.Value);
        }

       
    }
}
    
