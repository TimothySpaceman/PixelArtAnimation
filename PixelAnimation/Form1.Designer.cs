namespace PixelAnimation
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
            this.mainBox = new System.Windows.Forms.PictureBox();
            this.freqTrackBar = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.colorAnimationBox = new System.Windows.Forms.PictureBox();
            this.colorMapBox = new System.Windows.Forms.PictureBox();
            this.textureBox = new System.Windows.Forms.PictureBox();
            this.skinLabel = new System.Windows.Forms.Label();
            this.skinComboBox = new System.Windows.Forms.ComboBox();
            this.animCombo = new System.Windows.Forms.ComboBox();
            this.animationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorAnimationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Location = new System.Drawing.Point(0, 0);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(420, 420);
            this.mainBox.TabIndex = 0;
            this.mainBox.TabStop = false;
            // 
            // freqTrackBar
            // 
            this.freqTrackBar.Location = new System.Drawing.Point(426, 31);
            this.freqTrackBar.Maximum = 24;
            this.freqTrackBar.Name = "freqTrackBar";
            this.freqTrackBar.Size = new System.Drawing.Size(277, 45);
            this.freqTrackBar.TabIndex = 1;
            this.freqTrackBar.Value = 5;
            this.freqTrackBar.ValueChanged += new System.EventHandler(this.freqTrackBar_ValueChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(432, 10);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(129, 18);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "Animation Speed";
            // 
            // colorAnimationBox
            // 
            this.colorAnimationBox.Location = new System.Drawing.Point(0, 420);
            this.colorAnimationBox.Name = "colorAnimationBox";
            this.colorAnimationBox.Size = new System.Drawing.Size(140, 140);
            this.colorAnimationBox.TabIndex = 3;
            this.colorAnimationBox.TabStop = false;
            // 
            // colorMapBox
            // 
            this.colorMapBox.Location = new System.Drawing.Point(140, 420);
            this.colorMapBox.Name = "colorMapBox";
            this.colorMapBox.Size = new System.Drawing.Size(140, 140);
            this.colorMapBox.TabIndex = 4;
            this.colorMapBox.TabStop = false;
            // 
            // textureBox
            // 
            this.textureBox.Location = new System.Drawing.Point(280, 420);
            this.textureBox.Name = "textureBox";
            this.textureBox.Size = new System.Drawing.Size(140, 140);
            this.textureBox.TabIndex = 5;
            this.textureBox.TabStop = false;
            // 
            // skinLabel
            // 
            this.skinLabel.AutoSize = true;
            this.skinLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skinLabel.Location = new System.Drawing.Point(432, 79);
            this.skinLabel.Name = "skinLabel";
            this.skinLabel.Size = new System.Drawing.Size(39, 18);
            this.skinLabel.TabIndex = 6;
            this.skinLabel.Text = "Skin";
            // 
            // skinComboBox
            // 
            this.skinComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skinComboBox.FormattingEnabled = true;
            this.skinComboBox.Location = new System.Drawing.Point(478, 75);
            this.skinComboBox.Name = "skinComboBox";
            this.skinComboBox.Size = new System.Drawing.Size(215, 26);
            this.skinComboBox.TabIndex = 7;
            this.skinComboBox.SelectionChangeCommitted += new System.EventHandler(this.skinComboBox_SelectionChangeCommitted);
            // 
            // animCombo
            // 
            this.animCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animCombo.FormattingEnabled = true;
            this.animCombo.Location = new System.Drawing.Point(516, 107);
            this.animCombo.Name = "animCombo";
            this.animCombo.Size = new System.Drawing.Size(177, 26);
            this.animCombo.TabIndex = 9;
            this.animCombo.SelectionChangeCommitted += new System.EventHandler(this.animCombo_SelectionChangeCommitted);
            // 
            // animationLabel
            // 
            this.animationLabel.AutoSize = true;
            this.animationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animationLabel.Location = new System.Drawing.Point(432, 111);
            this.animationLabel.Name = "animationLabel";
            this.animationLabel.Size = new System.Drawing.Size(78, 18);
            this.animationLabel.TabIndex = 8;
            this.animationLabel.Text = "Animation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 560);
            this.Controls.Add(this.animCombo);
            this.Controls.Add(this.animationLabel);
            this.Controls.Add(this.skinComboBox);
            this.Controls.Add(this.skinLabel);
            this.Controls.Add(this.textureBox);
            this.Controls.Add(this.colorMapBox);
            this.Controls.Add(this.colorAnimationBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.freqTrackBar);
            this.Controls.Add(this.mainBox);
            this.MaximumSize = new System.Drawing.Size(720, 599);
            this.MinimumSize = new System.Drawing.Size(720, 599);
            this.Name = "Form1";
            this.Text = "Pixel Art Animation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorAnimationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainBox;
        private System.Windows.Forms.TrackBar freqTrackBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.PictureBox colorAnimationBox;
        private System.Windows.Forms.PictureBox colorMapBox;
        private System.Windows.Forms.PictureBox textureBox;
        private System.Windows.Forms.Label skinLabel;
        private System.Windows.Forms.ComboBox skinComboBox;
        private System.Windows.Forms.ComboBox animCombo;
        private System.Windows.Forms.Label animationLabel;
    }
}

