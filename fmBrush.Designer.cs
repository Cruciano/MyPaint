namespace myPaint
{
    partial class fmBrush
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnBrushEditor = new System.Windows.Forms.MenuStrip();
            this.miCreateBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.micbBrushSize = new System.Windows.Forms.ToolStripComboBox();
            this.miLoadBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.miClearBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.miInvertBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBrush = new System.Windows.Forms.Panel();
            this.ofdBrushEditor = new System.Windows.Forms.OpenFileDialog();
            this.sfdBrushEditor = new System.Windows.Forms.SaveFileDialog();
            this.mnBrushEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnBrushEditor
            // 
            this.mnBrushEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateBrush,
            this.micbBrushSize,
            this.miLoadBrush,
            this.miSaveBrush,
            this.miClearBrush,
            this.miInvertBrush});
            this.mnBrushEditor.Location = new System.Drawing.Point(0, 0);
            this.mnBrushEditor.Name = "mnBrushEditor";
            this.mnBrushEditor.Size = new System.Drawing.Size(552, 25);
            this.mnBrushEditor.TabIndex = 0;
            // 
            // miCreateBrush
            // 
            this.miCreateBrush.Name = "miCreateBrush";
            this.miCreateBrush.Size = new System.Drawing.Size(68, 21);
            this.miCreateBrush.Text = "&Створити";
            this.miCreateBrush.Click += new System.EventHandler(this.miCreateBrush_Click);
            // 
            // micbBrushSize
            // 
            this.micbBrushSize.Items.AddRange(new object[] {
            "2 X 2",
            "3 X 3",
            "4 X 4",
            "5 X 5",
            "6 X 6",
            "7 X 7",
            "8 X 8",
            "9 X 9",
            "10 X 10",
            "11 X 11",
            "12 X 12",
            "13 X 13",
            "14 X 14",
            "15 X 15",
            "16 X 16",
            "17 X 17",
            "18 X 18",
            "19 X 19",
            "20 X 20",
            "21 X 21",
            "22 X 22",
            "23 X 23",
            "24 X 24",
            "25 X 25",
            "26 X 26",
            "27 X 27",
            "28 X 28",
            "29 X 29",
            "30 X 30",
            "31 X 31",
            "32 X 32",
            "33 X 33",
            "34 X 34",
            "35 X 35",
            "36 X 36",
            "37 X 37",
            "38 X 38",
            "39 X 39",
            "40 X 40"});
            this.micbBrushSize.Name = "micbBrushSize";
            this.micbBrushSize.Size = new System.Drawing.Size(121, 21);
            // 
            // miLoadBrush
            // 
            this.miLoadBrush.Name = "miLoadBrush";
            this.miLoadBrush.Size = new System.Drawing.Size(87, 21);
            this.miLoadBrush.Text = "За&вантажити";
            this.miLoadBrush.Click += new System.EventHandler(this.miLoadBrush_Click);
            // 
            // miSaveBrush
            // 
            this.miSaveBrush.Enabled = false;
            this.miSaveBrush.Name = "miSaveBrush";
            this.miSaveBrush.Size = new System.Drawing.Size(66, 21);
            this.miSaveBrush.Text = "&Зберегти";
            this.miSaveBrush.Click += new System.EventHandler(this.miSaveBrush_Click);
            // 
            // miClearBrush
            // 
            this.miClearBrush.Enabled = false;
            this.miClearBrush.Name = "miClearBrush";
            this.miClearBrush.Size = new System.Drawing.Size(68, 21);
            this.miClearBrush.Text = "&Очистити";
            this.miClearBrush.Click += new System.EventHandler(this.miClearBrush_Click);
            // 
            // miInvertBrush
            // 
            this.miInvertBrush.Enabled = false;
            this.miInvertBrush.Name = "miInvertBrush";
            this.miInvertBrush.Size = new System.Drawing.Size(83, 21);
            this.miInvertBrush.Text = "&Інвертувати";
            this.miInvertBrush.Click += new System.EventHandler(this.miInvertBrush_Click);
            // 
            // pnlBrush
            // 
            this.pnlBrush.Location = new System.Drawing.Point(0, 26);
            this.pnlBrush.Name = "pnlBrush";
            this.pnlBrush.Size = new System.Drawing.Size(20, 20);
            this.pnlBrush.TabIndex = 1;
            // 
            // ofdBrushEditor
            // 
            this.ofdBrushEditor.Filter = "Файли відбитка пензлика|*.brf";
            // 
            // sfdBrushEditor
            // 
            this.sfdBrushEditor.Filter = "Файли відбитка пензлика|*.brf";
            // 
            // fmBrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 76);
            this.Controls.Add(this.pnlBrush);
            this.Controls.Add(this.mnBrushEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnBrushEditor;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBrush";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Формування відбитку пензлика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmBrush_FormClosing);
            this.Load += new System.EventHandler(this.fmBrush_Load);
            this.mnBrushEditor.ResumeLayout(false);
            this.mnBrushEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnBrushEditor;
        private System.Windows.Forms.ToolStripMenuItem miCreateBrush;
        private System.Windows.Forms.ToolStripComboBox micbBrushSize;
        private System.Windows.Forms.ToolStripMenuItem miLoadBrush;
        private System.Windows.Forms.ToolStripMenuItem miSaveBrush;
        private System.Windows.Forms.ToolStripMenuItem miClearBrush;
        private System.Windows.Forms.ToolStripMenuItem miInvertBrush;
        private System.Windows.Forms.Panel pnlBrush;
        private System.Windows.Forms.OpenFileDialog ofdBrushEditor;
        private System.Windows.Forms.SaveFileDialog sfdBrushEditor;
    }
}