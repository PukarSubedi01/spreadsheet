namespace Spreadsheet_assignment
{
    partial class Spreadsheet
    {
        /// <Summary>
        /// Required designer variable.
        /// </Summary>
        private System.ComponentModel.IContainer components = null;

        /// <Summary>
        /// Clean up any resources being used.
        /// </Summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <Summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </Summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.RowColBox = new System.Windows.Forms.ComboBox();
            this.FormulaBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FormulaBar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(2, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Chart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RowColBox
            // 
            this.RowColBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowColBox.FormattingEnabled = true;
            this.RowColBox.Location = new System.Drawing.Point(12, 53);
            this.RowColBox.Name = "RowColBox";
            this.RowColBox.Size = new System.Drawing.Size(136, 32);
            this.RowColBox.TabIndex = 3;
            // 
            // FormulaBox
            // 
            this.FormulaBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormulaBox.FormattingEnabled = true;
            this.FormulaBox.Location = new System.Drawing.Point(211, 12);
            this.FormulaBox.Name = "FormulaBox";
            this.FormulaBox.Size = new System.Drawing.Size(199, 32);
            this.FormulaBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "fx";
            // 
            // FormulaBar
            // 
            this.FormulaBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormulaBar.FormattingEnabled = true;
            this.FormulaBar.Location = new System.Drawing.Point(211, 54);
            this.FormulaBar.Name = "FormulaBar";
            this.FormulaBar.Size = new System.Drawing.Size(675, 28);
            this.FormulaBar.TabIndex = 6;
            // 
            // Spreadsheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(887, 584);
            this.Controls.Add(this.FormulaBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormulaBox);
            this.Controls.Add(this.RowColBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Spreadsheet";
            this.Text = "Spreadsheet";
            this.Load += new System.EventHandler(this.Spreadsheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox RowColBox;
        private System.Windows.Forms.ComboBox FormulaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FormulaBar;
    }
}

