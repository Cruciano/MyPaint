namespace myPaint
{
    partial class fmCorrRGB
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.pnlBlue = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(96, 166);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Виконати";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(177, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(110, 10);
            this.tbRed.Maximum = 35;
            this.tbRed.Minimum = -35;
            this.tbRed.Name = "tbRed";
            this.tbRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbRed.Size = new System.Drawing.Size(42, 150);
            this.tbRed.TabIndex = 2;
            this.tbRed.TickFrequency = 5;
            this.tbRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(160, 10);
            this.tbGreen.Maximum = 35;
            this.tbGreen.Minimum = -35;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbGreen.Size = new System.Drawing.Size(42, 150);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.TickFrequency = 5;
            this.tbGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(210, 10);
            this.tbBlue.Maximum = 35;
            this.tbBlue.Minimum = -35;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbBlue.Size = new System.Drawing.Size(42, 150);
            this.tbBlue.TabIndex = 4;
            this.tbBlue.TickFrequency = 5;
            this.tbBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Red;
            this.pnlRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRed.Location = new System.Drawing.Point(10, 70);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(50, 50);
            this.pnlRed.TabIndex = 5;
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.Green;
            this.pnlGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGreen.Location = new System.Drawing.Point(25, 45);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(50, 50);
            this.pnlGreen.TabIndex = 6;
            // 
            // pnlBlue
            // 
            this.pnlBlue.BackColor = System.Drawing.Color.Blue;
            this.pnlBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlue.Location = new System.Drawing.Point(40, 20);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(50, 50);
            this.pnlBlue.TabIndex = 7;
            // 
            // fmCorrRGB
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(262, 199);
            this.Controls.Add(this.pnlBlue);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pnlRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCorrRGB";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Корекція кольору";
            this.Load += new System.EventHandler(this.fmCorrRGB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Panel pnlBlue;
    }
}