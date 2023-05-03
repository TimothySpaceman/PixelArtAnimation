namespace ColorMap_Generator
{
    partial class Form1
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
            this.vNud = new System.Windows.Forms.NumericUpDown();
            this.sNud = new System.Windows.Forms.NumericUpDown();
            this.hNud = new System.Windows.Forms.NumericUpDown();
            this.heightNud = new System.Windows.Forms.NumericUpDown();
            this.widthNud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).BeginInit();
            this.SuspendLayout();
            // 
            // vNud
            // 
            this.vNud.Location = new System.Drawing.Point(73, 100);
            this.vNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.vNud.Name = "vNud";
            this.vNud.Size = new System.Drawing.Size(120, 20);
            this.vNud.TabIndex = 24;
            // 
            // sNud
            // 
            this.sNud.Location = new System.Drawing.Point(73, 77);
            this.sNud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.sNud.Name = "sNud";
            this.sNud.Size = new System.Drawing.Size(120, 20);
            this.sNud.TabIndex = 23;
            // 
            // hNud
            // 
            this.hNud.Location = new System.Drawing.Point(73, 55);
            this.hNud.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.hNud.Name = "hNud";
            this.hNud.Size = new System.Drawing.Size(120, 20);
            this.hNud.TabIndex = 22;
            // 
            // heightNud
            // 
            this.heightNud.Location = new System.Drawing.Point(73, 32);
            this.heightNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNud.Name = "heightNud";
            this.heightNud.Size = new System.Drawing.Size(120, 20);
            this.heightNud.TabIndex = 21;
            this.heightNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // widthNud
            // 
            this.widthNud.Location = new System.Drawing.Point(73, 9);
            this.widthNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNud.Name = "widthNud";
            this.widthNud.Size = new System.Drawing.Size(120, 20);
            this.widthNud.TabIndex = 20;
            this.widthNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "V Step";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "S Step";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Width";
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyButton.Location = new System.Drawing.Point(12, 135);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(181, 28);
            this.copyButton.TabIndex = 14;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 171);
            this.Controls.Add(this.vNud);
            this.Controls.Add(this.sNud);
            this.Controls.Add(this.hNud);
            this.Controls.Add(this.heightNud);
            this.Controls.Add(this.widthNud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyButton);
            this.MaximumSize = new System.Drawing.Size(220, 210);
            this.MinimumSize = new System.Drawing.Size(220, 210);
            this.Name = "Form1";
            this.Text = "ColorMap Generator";
            ((System.ComponentModel.ISupportInitialize)(this.vNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown vNud;
        private System.Windows.Forms.NumericUpDown sNud;
        private System.Windows.Forms.NumericUpDown hNud;
        private System.Windows.Forms.NumericUpDown heightNud;
        private System.Windows.Forms.NumericUpDown widthNud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButton;
    }
}

