using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Spreadsheet_assignment
{
    public partial class BarChart : Form
    {
        string[] characters;   //stores the series of selected Columns
        int[] values;     //stores the series of selected rows
        public BarChart(string[] characters, int[] values)
        {
            this.characters = characters;
            this.values = values;
            InitializeComponent();
        }

        private void BarChart_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            // Data arrays
            string[] seriesArray = characters; // { "A", "B", "C", "D" };
            int[] pointsArray = values;//{ 2, 1, 7, 5 };

            // Set palette
            chart1.Palette = ChartColorPalette.EarthTones;

            // Set title
            chart1.Titles.Add("Spread Sheet");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = chart1.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

    }
}
