namespace KompasConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPDrawings = new System.Windows.Forms.TabPage();
            this.bSetting = new System.Windows.Forms.Button();
            this.bConvertAllDrawing = new System.Windows.Forms.Button();
            this.bConvertActiveDrawing = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tPDrawings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPDrawings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tPDrawings
            // 
            this.tPDrawings.Controls.Add(this.bSetting);
            this.tPDrawings.Controls.Add(this.bConvertAllDrawing);
            this.tPDrawings.Controls.Add(this.bConvertActiveDrawing);
            this.tPDrawings.Location = new System.Drawing.Point(4, 24);
            this.tPDrawings.Name = "tPDrawings";
            this.tPDrawings.Padding = new System.Windows.Forms.Padding(3);
            this.tPDrawings.Size = new System.Drawing.Size(346, 268);
            this.tPDrawings.TabIndex = 0;
            this.tPDrawings.Text = "Чертежи";
            this.tPDrawings.UseVisualStyleBackColor = true;
            // 
            // bSetting
            // 
            this.bSetting.Location = new System.Drawing.Point(20, 180);
            this.bSetting.Name = "bSetting";
            this.bSetting.Size = new System.Drawing.Size(300, 55);
            this.bSetting.TabIndex = 2;
            this.bSetting.Text = "Настройки";
            this.bSetting.UseVisualStyleBackColor = true;
            this.bSetting.Click += new System.EventHandler(this.bSetting_Click);
            // 
            // bConvertAllDrawing
            // 
            this.bConvertAllDrawing.Location = new System.Drawing.Point(20, 100);
            this.bConvertAllDrawing.Name = "bConvertAllDrawing";
            this.bConvertAllDrawing.Size = new System.Drawing.Size(300, 55);
            this.bConvertAllDrawing.TabIndex = 1;
            this.bConvertAllDrawing.Text = "Конвертировать все открытые документы (чертежи)";
            this.bConvertAllDrawing.UseVisualStyleBackColor = true;
            this.bConvertAllDrawing.Click += new System.EventHandler(this.bConvertAllDrawing_Click);
            // 
            // bConvertActiveDrawing
            // 
            this.bConvertActiveDrawing.Location = new System.Drawing.Point(20, 20);
            this.bConvertActiveDrawing.Name = "bConvertActiveDrawing";
            this.bConvertActiveDrawing.Size = new System.Drawing.Size(300, 55);
            this.bConvertActiveDrawing.TabIndex = 0;
            this.bConvertActiveDrawing.Text = "Конвертировать активный документ (чертеж)";
            this.bConvertActiveDrawing.UseVisualStyleBackColor = true;
            this.bConvertActiveDrawing.Click += new System.EventHandler(this.bConvertActiveDrawing_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.bConvertAllDrawing;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 302);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компас-Конвертер";
            this.tabControl1.ResumeLayout(false);
            this.tPDrawings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPDrawings;
        private System.Windows.Forms.Button bSetting;
        private System.Windows.Forms.Button bConvertAllDrawing;
        private System.Windows.Forms.Button bConvertActiveDrawing;
    }
}

