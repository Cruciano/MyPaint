namespace myPaint
{
    partial class fmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.srFile1 = new System.Windows.Forms.ToolStripSeparator();
            this.miViewXY = new System.Windows.Forms.ToolStripMenuItem();
            this.srFile2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miPenal = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.miFillLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.srPenal1 = new System.Windows.Forms.ToolStripSeparator();
            this.miPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.miPencilHardH = new System.Windows.Forms.ToolStripMenuItem();
            this.miPencilHardB = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize6 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize7 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize8 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize9 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStandartBrashSize10 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSpecialBrash = new System.Windows.Forms.ToolStripMenuItem();
            this.miCross3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miCross4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miCross5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miLSlesh3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miLSlesh4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miLSlesh5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miRSlesh3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miRSlesh4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miRSlesh5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miX3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miX4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miX5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileBrash = new System.Windows.Forms.ToolStripMenuItem();
            this.miEraser = new System.Windows.Forms.ToolStripMenuItem();
            this.miEraserSize1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miEraserSize2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miEraserSize3 = new System.Windows.Forms.ToolStripMenuItem();
            this.srPenal2 = new System.Windows.Forms.ToolStripSeparator();
            this.miBrushEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.miLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.miCleanLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.miLayerToArrayboard = new System.Windows.Forms.ToolStripMenuItem();
            this.miLayerFromArrayboardAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miLayerFromArrayboard = new System.Windows.Forms.ToolStripMenuItem();
            this.miUniteLayers = new System.Windows.Forms.ToolStripMenuItem();
            this.mncbLayer = new System.Windows.Forms.ToolStripComboBox();
            this.miEffect = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectCorrRGB = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectGrey = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectSepia = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectAqua = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectEmbossed = new System.Windows.Forms.ToolStripMenuItem();
            this.miEffectFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.tmRender = new System.Windows.Forms.Timer(this.components);
            this.pnlColor1 = new System.Windows.Forms.Panel();
            this.pnlColor2 = new System.Windows.Forms.Panel();
            this.cdBrush = new System.Windows.Forms.ColorDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdBrush = new System.Windows.Forms.OpenFileDialog();
            this.ofdEffect = new System.Windows.Forms.OpenFileDialog();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miPenal,
            this.miLayer,
            this.mncbLayer,
            this.miEffect,
            this.miAbout});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnMain.Size = new System.Drawing.Size(1069, 32);
            this.mnMain.TabIndex = 0;
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewFile,
            this.miOpenFile,
            this.miSaveFile,
            this.miSaveAs,
            this.srFile1,
            this.miViewXY,
            this.srFile2,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(57, 28);
            this.miFile.Text = "&Файл";
            // 
            // miNewFile
            // 
            this.miNewFile.Name = "miNewFile";
            this.miNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNewFile.Size = new System.Drawing.Size(254, 26);
            this.miNewFile.Text = "&Створити";
            this.miNewFile.Click += new System.EventHandler(this.miNewFile_Click);
            // 
            // miOpenFile
            // 
            this.miOpenFile.Name = "miOpenFile";
            this.miOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpenFile.Size = new System.Drawing.Size(254, 26);
            this.miOpenFile.Text = "&Відкрити";
            this.miOpenFile.Click += new System.EventHandler(this.miOpenFile_Click);
            // 
            // miSaveFile
            // 
            this.miSaveFile.Name = "miSaveFile";
            this.miSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSaveFile.Size = new System.Drawing.Size(254, 26);
            this.miSaveFile.Text = "&Зберегти";
            this.miSaveFile.Click += new System.EventHandler(this.miSaveFile_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.miSaveAs.Size = new System.Drawing.Size(254, 26);
            this.miSaveAs.Text = "Зберегти &як...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // srFile1
            // 
            this.srFile1.Name = "srFile1";
            this.srFile1.Size = new System.Drawing.Size(251, 6);
            // 
            // miViewXY
            // 
            this.miViewXY.CheckOnClick = true;
            this.miViewXY.Name = "miViewXY";
            this.miViewXY.Size = new System.Drawing.Size(254, 26);
            this.miViewXY.Text = "Показувати &координати";
            // 
            // srFile2
            // 
            this.srFile2.Name = "srFile2";
            this.srFile2.Size = new System.Drawing.Size(251, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miExit.Size = new System.Drawing.Size(254, 26);
            this.miExit.Text = "Ви&хід";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miPenal
            // 
            this.miPenal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChangeColor,
            this.miFillLayer,
            this.srPenal1,
            this.miPencil,
            this.miStandartBrush,
            this.miSpecialBrash,
            this.miFileBrash,
            this.miEraser,
            this.srPenal2,
            this.miBrushEditor});
            this.miPenal.Name = "miPenal";
            this.miPenal.Size = new System.Drawing.Size(106, 28);
            this.miPenal.Text = "&Інструменти";
            // 
            // miChangeColor
            // 
            this.miChangeColor.Name = "miChangeColor";
            this.miChangeColor.Size = new System.Drawing.Size(311, 26);
            this.miChangeColor.Text = "Зм&інити колір (ліва/права миші)";
            this.miChangeColor.Click += new System.EventHandler(this.miChangeColor_Click);
            // 
            // miFillLayer
            // 
            this.miFillLayer.Name = "miFillLayer";
            this.miFillLayer.Size = new System.Drawing.Size(311, 26);
            this.miFillLayer.Text = "&Залити шар";
            this.miFillLayer.Click += new System.EventHandler(this.miFillLayer_Click);
            // 
            // srPenal1
            // 
            this.srPenal1.Name = "srPenal1";
            this.srPenal1.Size = new System.Drawing.Size(308, 6);
            // 
            // miPencil
            // 
            this.miPencil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPencilHardH,
            this.miPencilHardB});
            this.miPencil.Name = "miPencil";
            this.miPencil.Size = new System.Drawing.Size(311, 26);
            this.miPencil.Text = "&Олівець";
            // 
            // miPencilHardH
            // 
            this.miPencilHardH.Name = "miPencilHardH";
            this.miPencilHardH.Size = new System.Drawing.Size(175, 26);
            this.miPencilHardH.Text = "Твердість (H)";
            this.miPencilHardH.Click += new System.EventHandler(this.miPencilHardH_Click);
            // 
            // miPencilHardB
            // 
            this.miPencilHardB.Name = "miPencilHardB";
            this.miPencilHardB.Size = new System.Drawing.Size(175, 26);
            this.miPencilHardB.Text = "Твердість (B)";
            this.miPencilHardB.Click += new System.EventHandler(this.miPencilHardB_Click);
            // 
            // miStandartBrush
            // 
            this.miStandartBrush.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStandartBrashSize3,
            this.miStandartBrashSize4,
            this.miStandartBrashSize5,
            this.miStandartBrashSize6,
            this.miStandartBrashSize7,
            this.miStandartBrashSize8,
            this.miStandartBrashSize9,
            this.miStandartBrashSize10});
            this.miStandartBrush.Name = "miStandartBrush";
            this.miStandartBrush.Size = new System.Drawing.Size(311, 26);
            this.miStandartBrush.Text = "&Квадратний пензлик";
            // 
            // miStandartBrashSize3
            // 
            this.miStandartBrashSize3.Name = "miStandartBrashSize3";
            this.miStandartBrashSize3.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize3.Text = "Розмір &3 px";
            this.miStandartBrashSize3.Click += new System.EventHandler(this.miStandartBrashSize3_Click);
            // 
            // miStandartBrashSize4
            // 
            this.miStandartBrashSize4.Name = "miStandartBrashSize4";
            this.miStandartBrashSize4.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize4.Text = "Розмір &4 px";
            this.miStandartBrashSize4.Click += new System.EventHandler(this.miStandartBrashSize4_Click);
            // 
            // miStandartBrashSize5
            // 
            this.miStandartBrashSize5.Name = "miStandartBrashSize5";
            this.miStandartBrashSize5.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize5.Text = "Розмір &5 px";
            this.miStandartBrashSize5.Click += new System.EventHandler(this.miStandartBrashSize5_Click);
            // 
            // miStandartBrashSize6
            // 
            this.miStandartBrashSize6.Name = "miStandartBrashSize6";
            this.miStandartBrashSize6.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize6.Text = "Розмір &6 px";
            this.miStandartBrashSize6.Click += new System.EventHandler(this.miStandartBrashSize6_Click);
            // 
            // miStandartBrashSize7
            // 
            this.miStandartBrashSize7.Name = "miStandartBrashSize7";
            this.miStandartBrashSize7.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize7.Text = "Розмір &7 px";
            this.miStandartBrashSize7.Click += new System.EventHandler(this.miStandartBrashSize7_Click);
            // 
            // miStandartBrashSize8
            // 
            this.miStandartBrashSize8.Name = "miStandartBrashSize8";
            this.miStandartBrashSize8.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize8.Text = "Розмір &8 px";
            this.miStandartBrashSize8.Click += new System.EventHandler(this.miStandartBrashSize8_Click);
            // 
            // miStandartBrashSize9
            // 
            this.miStandartBrashSize9.Name = "miStandartBrashSize9";
            this.miStandartBrashSize9.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize9.Text = "Розмір &9 px";
            this.miStandartBrashSize9.Click += new System.EventHandler(this.miStandartBrashSize9_Click);
            // 
            // miStandartBrashSize10
            // 
            this.miStandartBrashSize10.Name = "miStandartBrashSize10";
            this.miStandartBrashSize10.Size = new System.Drawing.Size(172, 26);
            this.miStandartBrashSize10.Text = "Розмір &10 px";
            this.miStandartBrashSize10.Click += new System.EventHandler(this.miStandartBrashSize10_Click);
            // 
            // miSpecialBrash
            // 
            this.miSpecialBrash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCross3,
            this.miCross4,
            this.miCross5,
            this.miLSlesh3,
            this.miLSlesh4,
            this.miLSlesh5,
            this.miRSlesh3,
            this.miRSlesh4,
            this.miRSlesh5,
            this.miX3,
            this.miX4,
            this.miX5});
            this.miSpecialBrash.Name = "miSpecialBrash";
            this.miSpecialBrash.Size = new System.Drawing.Size(311, 26);
            this.miSpecialBrash.Text = "&Спеціальний пензлик";
            // 
            // miCross3
            // 
            this.miCross3.Name = "miCross3";
            this.miCross3.Size = new System.Drawing.Size(205, 26);
            this.miCross3.Text = "Форма \"+\" 3x3 px";
            this.miCross3.Click += new System.EventHandler(this.miCross3_Click);
            // 
            // miCross4
            // 
            this.miCross4.Name = "miCross4";
            this.miCross4.Size = new System.Drawing.Size(205, 26);
            this.miCross4.Text = "Форма \"+\" 4x4 px";
            this.miCross4.Click += new System.EventHandler(this.miCross4_Click);
            // 
            // miCross5
            // 
            this.miCross5.Name = "miCross5";
            this.miCross5.Size = new System.Drawing.Size(205, 26);
            this.miCross5.Text = "Форма \"+\" 5x5 px";
            this.miCross5.Click += new System.EventHandler(this.miCross5_Click);
            // 
            // miLSlesh3
            // 
            this.miLSlesh3.Name = "miLSlesh3";
            this.miLSlesh3.Size = new System.Drawing.Size(205, 26);
            this.miLSlesh3.Text = "Форма \"\\\" 3x3 px";
            this.miLSlesh3.Click += new System.EventHandler(this.miLSlesh3_Click);
            // 
            // miLSlesh4
            // 
            this.miLSlesh4.Name = "miLSlesh4";
            this.miLSlesh4.Size = new System.Drawing.Size(205, 26);
            this.miLSlesh4.Text = "Форма \"\\\" 4x4 px";
            this.miLSlesh4.Click += new System.EventHandler(this.miLSlesh4_Click);
            // 
            // miLSlesh5
            // 
            this.miLSlesh5.Name = "miLSlesh5";
            this.miLSlesh5.Size = new System.Drawing.Size(205, 26);
            this.miLSlesh5.Text = "Форма \"\\\" 5x5 px";
            this.miLSlesh5.Click += new System.EventHandler(this.miLSlesh5_Click);
            // 
            // miRSlesh3
            // 
            this.miRSlesh3.Name = "miRSlesh3";
            this.miRSlesh3.Size = new System.Drawing.Size(205, 26);
            this.miRSlesh3.Text = "Форма \"/\" 3x3 px";
            this.miRSlesh3.Click += new System.EventHandler(this.miRSlesh3_Click);
            // 
            // miRSlesh4
            // 
            this.miRSlesh4.Name = "miRSlesh4";
            this.miRSlesh4.Size = new System.Drawing.Size(205, 26);
            this.miRSlesh4.Text = "Форма \"/\" 4x4 px";
            this.miRSlesh4.Click += new System.EventHandler(this.miRSlesh4_Click);
            // 
            // miRSlesh5
            // 
            this.miRSlesh5.Name = "miRSlesh5";
            this.miRSlesh5.Size = new System.Drawing.Size(205, 26);
            this.miRSlesh5.Text = "Форма \"/\" 5x5 px";
            this.miRSlesh5.Click += new System.EventHandler(this.miRSlesh5_Click);
            // 
            // miX3
            // 
            this.miX3.Name = "miX3";
            this.miX3.Size = new System.Drawing.Size(205, 26);
            this.miX3.Text = "Форма \"X\" 3x3 px";
            this.miX3.Click += new System.EventHandler(this.miX3_Click);
            // 
            // miX4
            // 
            this.miX4.Name = "miX4";
            this.miX4.Size = new System.Drawing.Size(205, 26);
            this.miX4.Text = "Форма \"X\" 4x4 px";
            this.miX4.Click += new System.EventHandler(this.miX4_Click);
            // 
            // miX5
            // 
            this.miX5.Name = "miX5";
            this.miX5.Size = new System.Drawing.Size(205, 26);
            this.miX5.Text = "Форма \"X\" 5x5 px";
            this.miX5.Click += new System.EventHandler(this.miX5_Click);
            // 
            // miFileBrash
            // 
            this.miFileBrash.Name = "miFileBrash";
            this.miFileBrash.Size = new System.Drawing.Size(311, 26);
            this.miFileBrash.Text = "Пензлик з &файла";
            this.miFileBrash.Click += new System.EventHandler(this.miFileBrash_Click);
            // 
            // miEraser
            // 
            this.miEraser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEraserSize1,
            this.miEraserSize2,
            this.miEraserSize3});
            this.miEraser.Name = "miEraser";
            this.miEraser.Size = new System.Drawing.Size(311, 26);
            this.miEraser.Text = "&Ластик";
            // 
            // miEraserSize1
            // 
            this.miEraserSize1.Name = "miEraserSize1";
            this.miEraserSize1.Size = new System.Drawing.Size(148, 26);
            this.miEraserSize1.Text = "&Малий";
            this.miEraserSize1.Click += new System.EventHandler(this.miEraserSize1_Click);
            // 
            // miEraserSize2
            // 
            this.miEraserSize2.Name = "miEraserSize2";
            this.miEraserSize2.Size = new System.Drawing.Size(148, 26);
            this.miEraserSize2.Text = "&Середній";
            this.miEraserSize2.Click += new System.EventHandler(this.miEraserSize2_Click);
            // 
            // miEraserSize3
            // 
            this.miEraserSize3.Name = "miEraserSize3";
            this.miEraserSize3.Size = new System.Drawing.Size(148, 26);
            this.miEraserSize3.Text = "&Великий";
            this.miEraserSize3.Click += new System.EventHandler(this.miEraserSize3_Click);
            // 
            // srPenal2
            // 
            this.srPenal2.Name = "srPenal2";
            this.srPenal2.Size = new System.Drawing.Size(308, 6);
            // 
            // miBrushEditor
            // 
            this.miBrushEditor.Name = "miBrushEditor";
            this.miBrushEditor.Size = new System.Drawing.Size(311, 26);
            this.miBrushEditor.Text = "&Редактор пензликів";
            this.miBrushEditor.Click += new System.EventHandler(this.miBrushEditor_Click);
            // 
            // miLayer
            // 
            this.miLayer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddLayer,
            this.miDelLayer,
            this.miCleanLayer,
            this.miLayerToArrayboard,
            this.miLayerFromArrayboardAll,
            this.miLayerFromArrayboard,
            this.miUniteLayers});
            this.miLayer.Name = "miLayer";
            this.miLayer.Size = new System.Drawing.Size(61, 28);
            this.miLayer.Text = "&Шари";
            // 
            // miAddLayer
            // 
            this.miAddLayer.Name = "miAddLayer";
            this.miAddLayer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.miAddLayer.Size = new System.Drawing.Size(338, 26);
            this.miAddLayer.Text = "Додати &новий шар";
            this.miAddLayer.Click += new System.EventHandler(this.miAddLayer_Click);
            // 
            // miDelLayer
            // 
            this.miDelLayer.Name = "miDelLayer";
            this.miDelLayer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F8)));
            this.miDelLayer.Size = new System.Drawing.Size(338, 26);
            this.miDelLayer.Text = "Ви&далити активний шар";
            this.miDelLayer.Click += new System.EventHandler(this.miDelLayer_Click);
            // 
            // miCleanLayer
            // 
            this.miCleanLayer.Name = "miCleanLayer";
            this.miCleanLayer.Size = new System.Drawing.Size(338, 26);
            this.miCleanLayer.Text = "О&чистити шар";
            this.miCleanLayer.Click += new System.EventHandler(this.miCleanLayer_Click);
            // 
            // miLayerToArrayboard
            // 
            this.miLayerToArrayboard.Name = "miLayerToArrayboard";
            this.miLayerToArrayboard.Size = new System.Drawing.Size(338, 26);
            this.miLayerToArrayboard.Text = "&Копіювати шар";
            this.miLayerToArrayboard.Click += new System.EventHandler(this.miLayerToArrayboard_Click);
            // 
            // miLayerFromArrayboardAll
            // 
            this.miLayerFromArrayboardAll.Enabled = false;
            this.miLayerFromArrayboardAll.Name = "miLayerFromArrayboardAll";
            this.miLayerFromArrayboardAll.Size = new System.Drawing.Size(338, 26);
            this.miLayerFromArrayboardAll.Text = "&Вставити шар";
            this.miLayerFromArrayboardAll.Click += new System.EventHandler(this.miLayerFromArrayboardAll_Click);
            // 
            // miLayerFromArrayboard
            // 
            this.miLayerFromArrayboard.Enabled = false;
            this.miLayerFromArrayboard.Name = "miLayerFromArrayboard";
            this.miLayerFromArrayboard.Size = new System.Drawing.Size(338, 26);
            this.miLayerFromArrayboard.Text = "Вставити шар в не&прозорі точки";
            this.miLayerFromArrayboard.Click += new System.EventHandler(this.miLayerFromArrayboard_Click);
            // 
            // miUniteLayers
            // 
            this.miUniteLayers.Name = "miUniteLayers";
            this.miUniteLayers.Size = new System.Drawing.Size(338, 26);
            this.miUniteLayers.Text = "&Об\'єднати всі шари";
            this.miUniteLayers.Click += new System.EventHandler(this.miUniteLayers_Click);
            // 
            // mncbLayer
            // 
            this.mncbLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mncbLayer.Name = "mncbLayer";
            this.mncbLayer.Size = new System.Drawing.Size(160, 28);
            this.mncbLayer.SelectedIndexChanged += new System.EventHandler(this.mncbLayer_SelectedIndexChanged);
            // 
            // miEffect
            // 
            this.miEffect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEffectCorrRGB,
            this.miEffectInvert,
            this.miEffectGrey,
            this.miEffectSepia,
            this.miEffectBlur,
            this.miEffectContrast,
            this.miEffectAqua,
            this.miEffectEmbossed,
            this.miEffectFromFile});
            this.miEffect.Name = "miEffect";
            this.miEffect.Size = new System.Drawing.Size(69, 28);
            this.miEffect.Text = "Ефекти";
            // 
            // miEffectCorrRGB
            // 
            this.miEffectCorrRGB.Name = "miEffectCorrRGB";
            this.miEffectCorrRGB.Size = new System.Drawing.Size(236, 26);
            this.miEffectCorrRGB.Text = "Коригування кольору";
            this.miEffectCorrRGB.Click += new System.EventHandler(this.miEffectCorrRGB_Click);
            // 
            // miEffectInvert
            // 
            this.miEffectInvert.Name = "miEffectInvert";
            this.miEffectInvert.Size = new System.Drawing.Size(236, 26);
            this.miEffectInvert.Text = "&Інвертувати кольори";
            this.miEffectInvert.Click += new System.EventHandler(this.miEffectInvert_Click);
            // 
            // miEffectGrey
            // 
            this.miEffectGrey.Name = "miEffectGrey";
            this.miEffectGrey.Size = new System.Drawing.Size(236, 26);
            this.miEffectGrey.Text = "Відтінки сірого";
            this.miEffectGrey.Click += new System.EventHandler(this.miEffectGrey_Click);
            // 
            // miEffectSepia
            // 
            this.miEffectSepia.Name = "miEffectSepia";
            this.miEffectSepia.Size = new System.Drawing.Size(236, 26);
            this.miEffectSepia.Text = "Сепія";
            this.miEffectSepia.Click += new System.EventHandler(this.miEffectSepia_Click);
            // 
            // miEffectBlur
            // 
            this.miEffectBlur.Name = "miEffectBlur";
            this.miEffectBlur.Size = new System.Drawing.Size(236, 26);
            this.miEffectBlur.Text = "&Розмиття";
            this.miEffectBlur.Click += new System.EventHandler(this.miEffectBlur_Click);
            // 
            // miEffectContrast
            // 
            this.miEffectContrast.Name = "miEffectContrast";
            this.miEffectContrast.Size = new System.Drawing.Size(236, 26);
            this.miEffectContrast.Text = "&Контрастність";
            this.miEffectContrast.Click += new System.EventHandler(this.miEffectContrast_Click);
            // 
            // miEffectAqua
            // 
            this.miEffectAqua.Name = "miEffectAqua";
            this.miEffectAqua.Size = new System.Drawing.Size(236, 26);
            this.miEffectAqua.Text = "&Акварель";
            this.miEffectAqua.Click += new System.EventHandler(this.miEffectAqua_Click);
            // 
            // miEffectEmbossed
            // 
            this.miEffectEmbossed.Name = "miEffectEmbossed";
            this.miEffectEmbossed.Size = new System.Drawing.Size(236, 26);
            this.miEffectEmbossed.Text = "&Тиснення";
            this.miEffectEmbossed.Click += new System.EventHandler(this.miEffectEmbossed_Click);
            // 
            // miEffectFromFile
            // 
            this.miEffectFromFile.Name = "miEffectFromFile";
            this.miEffectFromFile.Size = new System.Drawing.Size(236, 26);
            this.miEffectFromFile.Text = "Завантажити з файла";
            this.miEffectFromFile.Click += new System.EventHandler(this.miEffectFromFile_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(28, 28);
            this.miAbout.Text = "?";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(0, 32);
            this.AnT.Margin = new System.Windows.Forms.Padding(4);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(1067, 738);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 2;
            this.AnT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseDown);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            this.AnT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseUp);
            // 
            // tmRender
            // 
            this.tmRender.Interval = 20;
            this.tmRender.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // pnlColor1
            // 
            this.pnlColor1.BackColor = System.Drawing.Color.Black;
            this.pnlColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor1.Location = new System.Drawing.Point(1011, 1);
            this.pnlColor1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlColor1.Name = "pnlColor1";
            this.pnlColor1.Size = new System.Drawing.Size(26, 24);
            this.pnlColor1.TabIndex = 9;
            this.pnlColor1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor1_MouseClick);
            // 
            // pnlColor2
            // 
            this.pnlColor2.BackColor = System.Drawing.Color.GreenYellow;
            this.pnlColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor2.Location = new System.Drawing.Point(1027, 5);
            this.pnlColor2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlColor2.Name = "pnlColor2";
            this.pnlColor2.Size = new System.Drawing.Size(26, 24);
            this.pnlColor2.TabIndex = 10;
            this.pnlColor2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor2_MouseClick);
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "Файли зображень в форматі BMP|*.bmp";
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "Файли зображень в форматі BMP|*.bmp";
            // 
            // ofdBrush
            // 
            this.ofdBrush.Filter = "Файли відбитка пензлика|*.brf";
            // 
            // ofdEffect
            // 
            this.ofdEffect.Filter = "Файли фільтрів ефекту|*.fxml";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 772);
            this.Controls.Add(this.pnlColor1);
            this.Controls.Add(this.pnlColor2);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.mnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myPaint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.ToolStripMenuItem miPenal;
        private System.Windows.Forms.ToolStripMenuItem miPencil;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrush;
        private System.Windows.Forms.ToolStripMenuItem miSpecialBrash;
        private System.Windows.Forms.ToolStripMenuItem miLayer;
        private System.Windows.Forms.ToolStripMenuItem miAddLayer;
        private System.Windows.Forms.ToolStripMenuItem miDelLayer;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miNewFile;
        private System.Windows.Forms.Timer tmRender;
        private System.Windows.Forms.Panel pnlColor1;
        private System.Windows.Forms.Panel pnlColor2;
        private System.Windows.Forms.ColorDialog cdBrush;
        private System.Windows.Forms.ToolStripMenuItem miSaveFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.ToolStripComboBox mncbLayer;
        private System.Windows.Forms.ToolStripMenuItem miFileBrash;
        private System.Windows.Forms.ToolStripMenuItem miEraser;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize3;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize4;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize5;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize6;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize7;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize8;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize9;
        private System.Windows.Forms.ToolStripMenuItem miStandartBrashSize10;
        private System.Windows.Forms.ToolStripMenuItem miPencilHardH;
        private System.Windows.Forms.ToolStripMenuItem miPencilHardB;
        private System.Windows.Forms.ToolStripMenuItem miEraserSize1;
        private System.Windows.Forms.ToolStripMenuItem miEraserSize2;
        private System.Windows.Forms.ToolStripMenuItem miEraserSize3;
        private System.Windows.Forms.OpenFileDialog ofdBrush;
        private System.Windows.Forms.ToolStripMenuItem miOpenFile;
        private System.Windows.Forms.ToolStripSeparator srFile1;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miCross3;
        private System.Windows.Forms.ToolStripMenuItem miCross4;
        private System.Windows.Forms.ToolStripMenuItem miCross5;
        private System.Windows.Forms.ToolStripMenuItem miLSlesh3;
        private System.Windows.Forms.ToolStripMenuItem miLSlesh4;
        private System.Windows.Forms.ToolStripMenuItem miLSlesh5;
        private System.Windows.Forms.ToolStripMenuItem miRSlesh3;
        private System.Windows.Forms.ToolStripMenuItem miRSlesh4;
        private System.Windows.Forms.ToolStripMenuItem miRSlesh5;
        private System.Windows.Forms.ToolStripMenuItem miX3;
        private System.Windows.Forms.ToolStripMenuItem miX4;
        private System.Windows.Forms.ToolStripMenuItem miX5;
        private System.Windows.Forms.ToolStripSeparator srPenal1;
        private System.Windows.Forms.ToolStripMenuItem miBrushEditor;
        private System.Windows.Forms.ToolStripMenuItem miChangeColor;
        private System.Windows.Forms.ToolStripSeparator srPenal2;
        private System.Windows.Forms.ToolStripMenuItem miViewXY;
        private System.Windows.Forms.ToolStripSeparator srFile2;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miEffect;
        private System.Windows.Forms.ToolStripMenuItem miEffectInvert;
        private System.Windows.Forms.ToolStripMenuItem miEffectBlur;
        private System.Windows.Forms.ToolStripMenuItem miEffectContrast;
        private System.Windows.Forms.ToolStripMenuItem miEffectAqua;
        private System.Windows.Forms.ToolStripMenuItem miEffectEmbossed;
        private System.Windows.Forms.ToolStripMenuItem miFillLayer;
        private System.Windows.Forms.ToolStripMenuItem miEffectGrey;
        private System.Windows.Forms.ToolStripMenuItem miEffectSepia;
        private System.Windows.Forms.ToolStripMenuItem miEffectFromFile;
        private System.Windows.Forms.OpenFileDialog ofdEffect;
        private System.Windows.Forms.ToolStripMenuItem miLayerToArrayboard;
        private System.Windows.Forms.ToolStripMenuItem miLayerFromArrayboard;
        private System.Windows.Forms.ToolStripMenuItem miUniteLayers;
        private System.Windows.Forms.ToolStripMenuItem miCleanLayer;
        private System.Windows.Forms.ToolStripMenuItem miLayerFromArrayboardAll;
        private System.Windows.Forms.ToolStripMenuItem miEffectCorrRGB;
    }
}

