using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System.IO;

namespace myPaint
{
    public partial class fmMain : Form
    {
        public fmMain(fmSplash screenform)
        {
            InitializeComponent();
            AnT.InitializeContexts(); // ініціалізація элемента SimpleOpenGLControl
            screenform.Hide();
            screenform.Dispose();
        }

        private anEngine ProgrammDrawingEngine;
        private int ActiveLayer = 0; // поточний активний шар
        private int LayersCount = 1; // лічильник шарів
        private int AllLayrsCount = 1; // лічильник шарів для генерації імен в комбобоксі
        private string MyDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string ViewXY;
        private IniFile ProgramINI = new IniFile();
        private Color DrawColor;
        private Boolean MustSave = false;
        private string ImgFileName = "Новий малюнок";

        float Mouse_X = 0, Mouse_Y = 0;

        private void fmMain_Load(object sender, EventArgs e)
        {
            Glut.glutInit(); // ініціалізація бібліотеки GLUT
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH); // ініціалізація режима вікна
            Gl.glClearColor(255, 255, 255, 1); // установка кольору очистки вікна
            Gl.glViewport(0, 0, AnT.Width, AnT.Height); // установка порту виведення на основі SimpleOpenGLControl
            Gl.glMatrixMode(Gl.GL_PROJECTION); // установка проекційної матриці 
            Gl.glLoadIdentity(); // очистка проекційної матриці 
            Glu.gluOrtho2D(0.0, AnT.Width, 0.0, AnT.Height);
            Gl.glMatrixMode(Gl.GL_MODELVIEW); // установка обєктно-видової матриці
            ProgrammDrawingEngine = new anEngine(AnT.Width, AnT.Height, AnT.Width, AnT.Height);
            if (ProgramINI.KeyExists("ColorL", "Options")) pnlColor1.BackColor = ColorTranslator.FromHtml(ProgramINI.Read("ColorL", "Options"));
            if (ProgramINI.KeyExists("ColorR", "Options")) pnlColor2.BackColor = ColorTranslator.FromHtml(ProgramINI.Read("ColorR", "Options"));
            if (ProgramINI.KeyExists("PicturePath", "Options")) MyDocPath = ProgramINI.Read("PicturePath", "Options");
            if (ProgramINI.KeyExists("ViewXY", "Options")) ViewXY = ProgramINI.Read("ViewXY", "Options");
            if (ViewXY == "1")
            {
                miViewXY.Checked = true;
            }
            else
            {
                miViewXY.Checked = false;
            }
            mncbLayer.Items.Add("Основа");
            mncbLayer.SelectedIndex = 0;
            this.Text = "myPaint - " + ImgFileName;
            tmRender.Start();
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            Drawing();
        }

        private void TextXY(float x, float y, string text)
        {
            Gl.glRasterPos2f(x, y);
            foreach (char char_for_draw in text)
            {
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_HELVETICA_12, char_for_draw);
            }
        }

        private void Drawing() // функція прорисовки
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT); // очистка буфера кольору і глибини 
            Gl.glLoadIdentity(); // очистка поточної матриці 
            Gl.glColor3f(0, 0, 0); // установка черного кольору 
            ProgrammDrawingEngine.SwapImage(); // візуалізація зображення
            ProgrammDrawingEngine.SetColor(DrawColor);
            if (miViewXY.Checked) TextXY(Mouse_X + 8f, Mouse_Y + 12f, "[" + (Mouse_X).ToString() + ";" + (Mouse_Y).ToString() + "]");
            Gl.glFlush(); // чекаємо завершення візуалізації кадра
            AnT.Invalidate(); // оновлення SimpleOpenGLControl
        }

        private void SaveToBMPFile(string myFileName)
        {
            Bitmap ImgToSave = ProgrammDrawingEngine.GetFinalImage();
            ImgToSave.Save(myFileName, System.Drawing.Imaging.ImageFormat.Bmp);
            ImgFileName = myFileName;
            this.Text = "myPaint - " + Path.GetFileName(ImgFileName);
        }

        private void AnT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawColor = pnlColor1.BackColor;
            }
            else
            {
                DrawColor = pnlColor2.BackColor;
            }
            if (!MustSave) MustSave = true;
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) || (e.Button == MouseButtons.Right))
            {
                ProgrammDrawingEngine.Drawing(e.X, AnT.Height - e.Y);
            }
            Mouse_X = e.X;
            Mouse_Y = AnT.Height - e.Y;
        }

        private void AnT_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) || (e.Button == MouseButtons.Right))
            {
                ProgrammDrawingEngine.Drawing(e.X, AnT.Height - e.Y);
            }
        }

        private void pnlColor1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cdBrush.ShowDialog() == DialogResult.OK)
            {
                pnlColor1.BackColor = cdBrush.Color;
            }
        }

        private void pnlColor2_MouseClick(object sender, MouseEventArgs e)
        {
            if (cdBrush.ShowDialog() == DialogResult.OK)
            {
                pnlColor2.BackColor = cdBrush.Color;
            }
        }

        private void NewBMPFile()
        {
            tmRender.Stop();
            ProgrammDrawingEngine = new anEngine(AnT.Width, AnT.Height, AnT.Width, AnT.Height);
            mncbLayer.Items.Clear();
            ActiveLayer = 0;
            LayersCount = 1;
            AllLayrsCount = 1;
            mncbLayer.Items.Add("Основа");
            mncbLayer.SelectedIndex = 0;
            ImgFileName = "Новий малюнок";
            this.Text = "myPaint - " + ImgFileName;
            miLayerFromArrayboard.Enabled = false;
            miLayerFromArrayboardAll.Enabled = false;
            MustSave = false;
            tmRender.Start();
        }


        private void miNewFile_Click(object sender, EventArgs e)
        {
            if (MustSave)
            {
                DialogResult reslt = MessageBox.Show("Зберегти зміни перед закриттям проекту?", "Попередження!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (reslt)
                {
                    case DialogResult.No:
                    {
                        NewBMPFile();
                        break;
                    }
                    case DialogResult.Cancel:
                    {
                        return;
                    }
                    case DialogResult.Yes:
                    {
                        if (ImgFileName == "Новий малюнок")
                        {
                            sfdFile.FileName = "";
                            sfdFile.InitialDirectory = MyDocPath;
                            if (sfdFile.ShowDialog() == DialogResult.OK)
                            {
                                SaveToBMPFile(sfdFile.FileName);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            SaveToBMPFile(ImgFileName);
                        }
                        NewBMPFile();
                        break;
                    }
                }
            }
            else
            {
                NewBMPFile();
            }
        }

        private void OpenBMPFile()
        {
            ofdFile.InitialDirectory = MyDocPath;
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                if (File.Exists(ofdFile.FileName))
                {
                    Bitmap ImgToLoad = new Bitmap(ofdFile.FileName);
                    if (ImgToLoad.Width > AnT.Width || ImgToLoad.Height > AnT.Height)
                    {
                        MessageBox.Show("Зображення неможливо завантажити, його розміри перевищують область малювання.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    tmRender.Stop();
                    ProgrammDrawingEngine = new anEngine(AnT.Width, AnT.Height, AnT.Width, AnT.Height);
                    ProgrammDrawingEngine.SetImageToMainLayer(ImgToLoad);
                    mncbLayer.Items.Clear();
                    ActiveLayer = 0;
                    LayersCount = 1;
                    AllLayrsCount = 1;
                    mncbLayer.Items.Add("Основа");
                    mncbLayer.SelectedIndex = 0;
                    ImgFileName = ofdFile.FileName;
                    this.Text = "myPaint - " + Path.GetFileName(ImgFileName);
                    miLayerFromArrayboard.Enabled = false;
                    miLayerFromArrayboardAll.Enabled = false;
                    MustSave = false;
                    tmRender.Start();
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void miOpenFile_Click(object sender, EventArgs e)
        {
            if (MustSave)
            {
                DialogResult reslt = MessageBox.Show("Зберегти зміни перед закриттям проекту?", "Попередження!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (reslt)
                {
                    case DialogResult.Yes:
                    {
                        if (ImgFileName == "Новий малюнок")
                        {
                            sfdFile.FileName = "";
                            sfdFile.InitialDirectory = MyDocPath;
                            if (sfdFile.ShowDialog() == DialogResult.OK)
                            {
                                SaveToBMPFile(sfdFile.FileName);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            SaveToBMPFile(ImgFileName);
                        }
                        OpenBMPFile();
                        break;
                    }
                    case DialogResult.No:
                    {
                        OpenBMPFile();
                        break;
                    }
                    case DialogResult.Cancel:
                    {
                        return;
                    }
                }
            }
            else
            {
                OpenBMPFile();
            }
        }

        private void miSaveFile_Click(object sender, EventArgs e)
        {
            if (ImgFileName == "Новий малюнок")
            {
                sfdFile.FileName = "";
                sfdFile.InitialDirectory = MyDocPath;
                if (sfdFile.ShowDialog() == DialogResult.OK)
                {
                    SaveToBMPFile(sfdFile.FileName);
                    MustSave = false;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (MustSave)
                {
                    SaveToBMPFile(ImgFileName);
                    MustSave = false;
                }
            }
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            sfdFile.FileName = "";
            sfdFile.InitialDirectory = MyDocPath;
            if (sfdFile.ShowDialog() == DialogResult.OK)
            {
                SaveToBMPFile(sfdFile.FileName);
                MustSave = false;
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MustSave)
            {
                DialogResult reslt = MessageBox.Show("Зберегти зміни перед закриттям проекту?", "Попередження!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (reslt)
                {
                    case DialogResult.Yes:
                    {
                        if (ImgFileName == "Новий малюнок")
                        {
                            sfdFile.FileName = "";
                            sfdFile.InitialDirectory = MyDocPath;
                            if (sfdFile.ShowDialog() == DialogResult.OK)
                            {
                                SaveToBMPFile(sfdFile.FileName);
                            }
                            else
                            {
                                e.Cancel = true;
                                return;
                            }

                        }
                        else
                        {
                            SaveToBMPFile(ImgFileName);
                        }
                        break;
                    }
                    case DialogResult.No:
                    {
                        break;
                    }
                    case DialogResult.Cancel:
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            if (miViewXY.Checked == true)
            {
                ViewXY = "1";
            }
            else
            {
                ViewXY = "0";
            }
            ProgramINI.Write("ColorL", ColorTranslator.ToHtml(pnlColor1.BackColor), "Options");
            ProgramINI.Write("ColorR", ColorTranslator.ToHtml(pnlColor2.BackColor), "Options");
            ProgramINI.Write("PicturePath", MyDocPath, "Options");
            ProgramINI.Write("ViewXY", ViewXY, "Options");
        }

        private void miPencilHardH_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(1);
        }

        private void miPencilHardB_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(2);
        }

        private void miStandartBrashSize3_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(3);
        }

        private void miStandartBrashSize4_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(4);
        }

        private void miStandartBrashSize5_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(5);
        }

        private void miStandartBrashSize6_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(6);
        }

        private void miStandartBrashSize7_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(7);
        }

        private void miStandartBrashSize8_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(8);
        }

        private void miStandartBrashSize9_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(9);
        }

        private void miStandartBrashSize10_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetStandartBrush(10);
        }

        private void miEraserSize1_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(1);
        }

        private void miEraserSize2_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(2);
        }

        private void miEraserSize3_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(3);
        }

        private void miCross3_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(0);
        }

        private void miCross4_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(4);
        }

        private void miCross5_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(5);
        }

        private void miLSlesh3_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(6);
        }

        private void miLSlesh4_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(7);
        }

        private void miLSlesh5_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(8);
        }

        private void miRSlesh3_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(9);
        }

        private void miRSlesh4_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(10);
        }

        private void miRSlesh5_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(11);
        }

        private void miX3_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(12);
        }

        private void miX4_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(13);
        }

        private void miX5_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.SetSpecialBrush(14);
        }

        private void miFileBrash_Click(object sender, EventArgs e)
        {
            ofdBrush.InitialDirectory = Directory.GetCurrentDirectory();
            if (ofdBrush.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdBrush.FileName))
                {
                    tmRender.Stop();
                    var fsBrush = new FileStream(ofdBrush.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    Bitmap ldBrush = new Bitmap(fsBrush);
                    fsBrush.Dispose();
                    if (ldBrush.Width > 40 || ldBrush.Height > 40)
                    {
                        MessageBox.Show("Найбільший розмір зображення для пензлика 40Х40 пікселів.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    ProgrammDrawingEngine.SetBrushFromFile(ofdBrush.FileName);
                    tmRender.Start();
                }
            }
        }

        private void miBrushEditor_Click(object sender, EventArgs e)
        {
            tmRender.Stop();
            fmBrush BrushEditor = new fmBrush();
            BrushEditor.ShowDialog();
            BrushEditor.Dispose();
            tmRender.Start();
        }

        private void miAddLayer_Click(object sender, EventArgs e) // функція додавання шару
        {
            LayersCount ++;
            AllLayrsCount++; // лічильник генеарації імен шарів
            ProgrammDrawingEngine.AddLayer();
            int AddingLayerNum = mncbLayer.Items.Add("Шар " + AllLayrsCount.ToString());
            mncbLayer.SelectedIndex = AddingLayerNum;
            ActiveLayer = AddingLayerNum;
            MustSave = true;
        }

        private void miDelLayer_Click(object sender, EventArgs e) // функція видалення шару
        {
            DialogResult res = MessageBox.Show("Буде видалений поточний активний шар, бажаєте продовжити дію?", "Попередження!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                if (ActiveLayer == 0)
                {
                    MessageBox.Show("Ви не можете видалити основний шар.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    LayersCount--;
                    int LayerNomForDel = mncbLayer.SelectedIndex;
                    mncbLayer.Items.RemoveAt(LayerNomForDel);
                    mncbLayer.SelectedIndex = 0;
                    ActiveLayer = 0;
                    ProgrammDrawingEngine.RemoveLayer(LayerNomForDel);
                    MustSave = true;
                }
            }
        }

        private void miFillLayer_Click(object sender, EventArgs e)
        {
            if (cdBrush.ShowDialog() == DialogResult.OK)
            {
                ProgrammDrawingEngine.FillLayer(cdBrush.Color);
                MustSave = true;
            }
        }

        private void miCleanLayer_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.CleanLayer();
            MustSave = true;
        }

        private void miLayerToArrayboard_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.LayerToArrayboard();
            miLayerFromArrayboard.Enabled = true;
            miLayerFromArrayboardAll.Enabled = true;
        }

        private void miLayerFromArrayboardAll_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.AllLayerFromArrayboard();
            MustSave = true;
        }

        private void miLayerFromArrayboard_Click(object sender, EventArgs e)
        {
            ProgrammDrawingEngine.LayerFromArrayboard();
            MustSave = true;
        }

        private void miUniteLayers_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Bitmap UniteImg = ProgrammDrawingEngine.GetFinalImage();
            ProgrammDrawingEngine = new anEngine(AnT.Width, AnT.Height, AnT.Width, AnT.Height);
            ProgrammDrawingEngine.SetImageToMainLayer(UniteImg);
            mncbLayer.Items.Clear();
            ActiveLayer = 0;
            LayersCount = 1;
            AllLayrsCount = 1;
            mncbLayer.Items.Add("Основа");
            mncbLayer.SelectedIndex = 0;
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void mncbLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mncbLayer.SelectedIndex != ActiveLayer)
            {
                if (mncbLayer.SelectedIndex != -1 && ActiveLayer < mncbLayer.Items.Count)
                {
                    ActiveLayer = mncbLayer.SelectedIndex;
                    ProgrammDrawingEngine.SetActiveLayerNom(ActiveLayer);
                }
            }
        }

        private void miEffectCorrRGB_Click(object sender, EventArgs e)
        {
            fmCorrRGB CorrectRGB = new fmCorrRGB();
            if (CorrectRGB.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                ProgrammDrawingEngine.EffectFilter(CorrectRGB.CorrR, CorrectRGB.CorrG, CorrectRGB.CorrB);
                this.Cursor = Cursors.Default;
            }
            CorrectRGB.Dispose();
            MustSave = true;
        }

        private void miEffectInvert_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ProgrammDrawingEngine.EffectFilter(1);
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void miEffectGrey_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ProgrammDrawingEngine.EffectFilter(2);
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void miEffectSepia_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ProgrammDrawingEngine.EffectFilter(3);
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void miEffectBlur_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ProgrammDrawingEngine.EffectFilter(4);
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void miEffectContrast_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ProgrammDrawingEngine.EffectFilter(5);
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void miEffectAqua_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ProgrammDrawingEngine.EffectFilter(6);
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void miEffectEmbossed_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ProgrammDrawingEngine.EffectFilter(7);
            this.Cursor = Cursors.Default;
            MustSave = true;
        }

        private void miEffectFromFile_Click(object sender, EventArgs e)
        {
            ofdEffect.InitialDirectory = Directory.GetCurrentDirectory();
            if (ofdEffect.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdEffect.FileName))
                {
                    this.Cursor = Cursors.WaitCursor;
                    ProgrammDrawingEngine.EffectFilter(ofdEffect.FileName);
                    this.Cursor = Cursors.Default;
                    MustSave = true;
                }
            }
        }

        private void miChangeColor_Click(object sender, EventArgs e)
        {
            Color tmpColor = pnlColor1.BackColor;
            pnlColor1.BackColor = pnlColor2.BackColor;
            pnlColor2.BackColor = tmpColor;
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            tmRender.Stop();
            fmAbout AboutProgram = new fmAbout();
            AboutProgram.ShowDialog();
            AboutProgram.Dispose();
            tmRender.Start();
        }
    }
}