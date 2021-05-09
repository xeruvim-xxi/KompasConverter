namespace KompasConverter
{
    partial class FormSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBFormat = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nScale = new System.Windows.Forms.NumericUpDown();
            this.cBColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBResolution = new System.Windows.Forms.ComboBox();
            this.cBColorBPP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bSaveSetting = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBFormat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Формат растра:";
            // 
            // cBFormat
            // 
            this.cBFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFormat.FormattingEnabled = true;
            this.cBFormat.Items.AddRange(new object[] {
            "JPEG",
            "TIFF",
            "TIFF(многостраничный)",
            "BMP"});
            this.cBFormat.Location = new System.Drawing.Point(140, 25);
            this.cBFormat.Name = "cBFormat";
            this.cBFormat.Size = new System.Drawing.Size(132, 21);
            this.cBFormat.TabIndex = 0;
            this.cBFormat.SelectedIndexChanged += new System.EventHandler(this.cBFormat_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nScale);
            this.groupBox2.Controls.Add(this.cBColor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка:";
            // 
            // nScale
            // 
            this.nScale.DecimalPlaces = 3;
            this.nScale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nScale.Location = new System.Drawing.Point(85, 55);
            this.nScale.Name = "nScale";
            this.nScale.Size = new System.Drawing.Size(60, 20);
            this.nScale.TabIndex = 3;
            // 
            // cBColor
            // 
            this.cBColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBColor.FormattingEnabled = true;
            this.cBColor.Items.AddRange(new object[] {
            "черный",
            "установленный для объекта"});
            this.cBColor.Location = new System.Drawing.Point(85, 25);
            this.cBColor.Name = "cBColor";
            this.cBColor.Size = new System.Drawing.Size(185, 21);
            this.cBColor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Масштаб:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цвет:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBResolution);
            this.groupBox3.Controls.Add(this.cBColorBPP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры растра:";
            // 
            // cBResolution
            // 
            this.cBResolution.FormatString = "N0";
            this.cBResolution.FormattingEnabled = true;
            this.cBResolution.Items.AddRange(new object[] {
            "96",
            "120",
            "150",
            "300",
            "450",
            "600"});
            this.cBResolution.Location = new System.Drawing.Point(180, 55);
            this.cBResolution.Name = "cBResolution";
            this.cBResolution.Size = new System.Drawing.Size(84, 21);
            this.cBResolution.TabIndex = 3;
            // 
            // cBColorBPP
            // 
            this.cBColorBPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBColorBPP.FormattingEnabled = true;
            this.cBColorBPP.Items.AddRange(new object[] {
            "монохромный",
            "16 цветов",
            "256 цветов",
            "24 разряда"});
            this.cBColorBPP.Location = new System.Drawing.Point(90, 25);
            this.cBColorBPP.Name = "cBColorBPP";
            this.cBColorBPP.Size = new System.Drawing.Size(180, 21);
            this.cBColorBPP.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Разрешение, точек на дюйм:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Цветность:";
            // 
            // bSaveSetting
            // 
            this.bSaveSetting.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSaveSetting.Location = new System.Drawing.Point(50, 245);
            this.bSaveSetting.Name = "bSaveSetting";
            this.bSaveSetting.Size = new System.Drawing.Size(85, 25);
            this.bSaveSetting.TabIndex = 3;
            this.bSaveSetting.Text = "Сохранить";
            this.bSaveSetting.UseVisualStyleBackColor = true;
            this.bSaveSetting.Click += new System.EventHandler(this.bSaveSetting_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(180, 245);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 25);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // FormSetting
            // 
            this.AcceptButton = this.bSaveSetting;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bSaveSetting;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSaveSetting);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBFormat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nScale;
        private System.Windows.Forms.ComboBox cBColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBResolution;
        private System.Windows.Forms.ComboBox cBColorBPP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSaveSetting;
        private System.Windows.Forms.Button bCancel;
    }
}