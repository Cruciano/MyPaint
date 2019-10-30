using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace myPaint
{
    public partial class fmBrush : Form
    {
        public fmBrush()
        {
            InitializeComponent();
        }

        Bitmap newBrush;
        int GridSize;
        string BrushFileName = "";
        bool CanSave;

        private void fmBrush_Load(object sender, EventArgs e)
        {
            micbBrushSize.SelectedIndex = 8;
            CanSave = false;
        }

        private void NewBrushFile()
        {
            this.Cursor = Cursors.WaitCursor;
            mnBrushEditor.Enabled = false;
            pnlBrush.Controls.Clear();
            this.Size = new Size(this.Size.Width, 101);
            Application.DoEvents();
            GridSize = micbBrushSize.SelectedIndex + 2;
            Point location = new Point(0, 0);
            int chbNum = 0;
            this.Size = new Size(this.Size.Width, this.Size.Height + (GridSize * 10));
            this.CenterToParent();
            pnlBrush.Location = new Point(((this.Size.Width / 2) - (GridSize * 10 / 2)), 50);
            pnlBrush.Size = new Size((GridSize * 10), (GridSize * 10));
            Application.DoEvents();
            for (int cx = 0; cx < GridSize; cx++)
            {
                for (int cy = 0; cy < GridSize; cy++)
                {
                    CheckBox myCheckBox = new CheckBox();
                    myCheckBox.Name = "chb" + chbNum.ToString();
                    myCheckBox.Text = "";
                    myCheckBox.Size = new System.Drawing.Size(10, 10);
                    myCheckBox.Left = location.X;
                    myCheckBox.Top = location.Y;
                    myCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    myCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
                    myCheckBox.FlatAppearance.CheckedBackColor = Color.Black;
                    myCheckBox.UseVisualStyleBackColor = true;
                    myCheckBox.Click += MyCheckBox_Click;
                    pnlBrush.Controls.Add(myCheckBox);
                    location = new Point(location.X, location.Y + 10);
                    chbNum++;
                }
                location = new Point(location.X + 10, 0);
            }
            newBrush = new Bitmap(GridSize, GridSize);
            for (int bx = 0; bx < GridSize; bx++)
            {
                for (int by = 0; by < GridSize; by++)
                {
                    newBrush.SetPixel(bx, by, Color.Red);
                }
            }
            BrushFileName = "";
            this.Text = "Формування відбитку пензлика [" + GridSize.ToString() + "X" + GridSize.ToString() + "] - Новий";
            CanSave = false;
            mnBrushEditor.Enabled = true;
            miSaveBrush.Enabled = true;
            miClearBrush.Enabled = true;
            miInvertBrush.Enabled = true;
            this.Cursor = Cursors.Default;
        }


        private void miCreateBrush_Click(object sender, EventArgs e)
        {
            if (CanSave)
            {
                DialogResult reslt = MessageBox.Show("Зміни не збережено, бажаєте продовжити?", "Попередження!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reslt == DialogResult.Yes)
                {
                    NewBrushFile();
                }
            }
            else
            {
                NewBrushFile();
            }
        }

        private void InitBrush()
        {
            for (int i=1; i<3; i++)
            {
                if (newBrush.GetPixel(0, 0).ToArgb() == Color.Red.ToArgb())
                {
                    newBrush.SetPixel(0, 0, Color.Black);
                }
                else
                {
                    newBrush.SetPixel(0, 0, Color.Red);
                }    
            }
        }

        private void OpenBrushFile()
        {
            ofdBrushEditor.InitialDirectory = Directory.GetCurrentDirectory();
            if (ofdBrushEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdBrushEditor.FileName))
                {
                    var fsBrush = new FileStream(ofdBrushEditor.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    newBrush = new Bitmap(fsBrush);
                    fsBrush.Dispose();
                    InitBrush();
                    if (newBrush.Width > 40 || newBrush.Height > 40)
                    {
                        MessageBox.Show("Найбільший розмір зображення для пензлика 40Х40 пікселів.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    mnBrushEditor.Enabled = false;
                    pnlBrush.Controls.Clear();
                    this.Size = new Size(this.Size.Width, 101);
                    Application.DoEvents();
                    GridSize = newBrush.Width;
                    Point location = new Point(0, 0);
                    int chbNum = 0;
                    this.Size = new Size(this.Size.Width, this.Size.Height + (GridSize * 10));
                    this.CenterToParent();
                    pnlBrush.Location = new Point(((this.Size.Width / 2) - (GridSize * 10 / 2)), 50);
                    pnlBrush.Size = new Size((GridSize * 10), (GridSize * 10));
                    Application.DoEvents();
                    for (int cx = 0; cx < GridSize; cx++)
                    {
                        for (int cy = 0; cy < GridSize; cy++)
                        {
                            CheckBox myCheckBox = new CheckBox();
                            myCheckBox.Name = "chb" + chbNum.ToString();
                            myCheckBox.Text = "";
                            myCheckBox.Size = new System.Drawing.Size(10, 10);
                            myCheckBox.Left = location.X;
                            myCheckBox.Top = location.Y;
                            myCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            myCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
                            myCheckBox.FlatAppearance.CheckedBackColor = Color.Black;
                            if (newBrush.GetPixel(cx, GridSize - cy - 1).ToArgb() != Color.Red.ToArgb())
                            {
                                myCheckBox.Checked = true;
                            }
                            myCheckBox.UseVisualStyleBackColor = true;
                            myCheckBox.Click += MyCheckBox_Click;
                            pnlBrush.Controls.Add(myCheckBox);
                            location = new Point(location.X, location.Y + 10);
                            chbNum++;
                        }
                        location = new Point(location.X + 10, 0);
                    }
                    BrushFileName = ofdBrushEditor.FileName;
                    ofdBrushEditor.FileName = "";
                    this.Text = "Формування відбитку пензлика [" + GridSize.ToString() + "X" + GridSize.ToString() + "] - " + Path.GetFileName(BrushFileName);
                    CanSave = false;
                    mnBrushEditor.Enabled = true;
                    miSaveBrush.Enabled = true;
                    miClearBrush.Enabled = true;
                    miInvertBrush.Enabled = true;
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void miLoadBrush_Click(object sender, EventArgs e)
        {
            if (CanSave)
            {
                DialogResult reslt = MessageBox.Show("Зміни не збережено, бажаєте продовжити?", "Попередження!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reslt == DialogResult.Yes)
                {
                    OpenBrushFile();
                }
            }
            else
            {
                OpenBrushFile();
            }
        }

        private void miSaveBrush_Click(object sender, EventArgs e)
        {
            if (BrushFileName == "")
            {
                sfdBrushEditor.FileName = "";
                sfdBrushEditor.InitialDirectory = Directory.GetCurrentDirectory();
                if (sfdBrushEditor.ShowDialog() == DialogResult.OK)
                {
                    newBrush.Save(sfdBrushEditor.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    BrushFileName = sfdBrushEditor.FileName;
                    this.Text = "Формування відбитку пензлика [" + GridSize.ToString() + "X" + GridSize.ToString() + "] - " + Path.GetFileName(BrushFileName);
                    CanSave = false;
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult reslt = MessageBox.Show("Файл " + Path.GetFileName(BrushFileName) + " вже існує! Щоб продовжити збереження натисніть \"Так\", щоб створити новий файл \"Ні\".", "Попередження!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (reslt)
                {
                    case DialogResult.No:
                    {
                        sfdBrushEditor.FileName = "";
                        sfdBrushEditor.InitialDirectory = Directory.GetCurrentDirectory();
                        if (sfdBrushEditor.ShowDialog() == DialogResult.OK)
                        {
                            newBrush.Save(sfdBrushEditor.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            BrushFileName = sfdBrushEditor.FileName;
                                this.Text = "Формування відбитку пензлика [" + GridSize.ToString() + "X" + GridSize.ToString() + "] - " + Path.GetFileName(BrushFileName);
                                CanSave = false;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    }
                    case DialogResult.Yes:
                    {
                        newBrush.Save(BrushFileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        CanSave = false;
                        break;
                    }
                    case DialogResult.Cancel:
                    {
                        return;
                    }
                }
            }
        }

        private void miClearBrush_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mnBrushEditor.Enabled = false;
            foreach (var myCheckBox in pnlBrush.Controls.OfType<CheckBox>())
            {
                myCheckBox.Checked = false;
            }
            for (int bx = 0; bx < GridSize; bx++)
            {
                for (int by = 0; by < GridSize; by++)
                {
                    newBrush.SetPixel(bx, by, Color.Red);
                }
            }
            CanSave = true;
            mnBrushEditor.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void miInvertBrush_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mnBrushEditor.Enabled = false;
            foreach (var myCheckBox in pnlBrush.Controls.OfType<CheckBox>())
            {
               myCheckBox.Checked = !myCheckBox.Checked;
            }
            for (int bx = 0; bx < GridSize; bx++)
            {
                for (int by = 0; by < GridSize; by++)
                {
                    if (newBrush.GetPixel(bx, by).ToArgb() == Color.Red.ToArgb())
                    {
                        newBrush.SetPixel(bx, by, Color.Black);
                    }
                    else
                    {
                        newBrush.SetPixel(bx, by, Color.Red);
                    }
                }
            }
            CanSave = true;
            mnBrushEditor.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void MyCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox myCheckBox = (CheckBox)sender;
            if (myCheckBox.Checked)
            {
                newBrush.SetPixel((myCheckBox.Left / 10), GridSize - (myCheckBox.Top / 10) - 1, Color.Black);
            }
            else
            {
                newBrush.SetPixel((myCheckBox.Left / 10), GridSize - (myCheckBox.Top / 10) - 1, Color.Red);
            }
            CanSave = true;
        }

        private void fmBrush_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CanSave)
            {
                DialogResult reslt = MessageBox.Show("Зміни не збережено, бажаєте вийти з редактора?", "Попередження!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reslt == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}