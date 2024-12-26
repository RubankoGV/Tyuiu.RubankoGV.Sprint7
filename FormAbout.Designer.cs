namespace Tyuiu.RubankoGV.Sprint7.V8
{
    partial class FormAbout
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
            pictureBoxAva_RGV = new PictureBox();
            labelText_RGV = new Label();
            buttonOK_RGV = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_RGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAva_RGV
            // 
            pictureBoxAva_RGV.BackgroundImage = Properties.Resources.ava;
            pictureBoxAva_RGV.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAva_RGV.Location = new Point(10, 9);
            pictureBoxAva_RGV.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAva_RGV.Name = "pictureBoxAva_RGV";
            pictureBoxAva_RGV.Size = new Size(209, 188);
            pictureBoxAva_RGV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAva_RGV.TabIndex = 0;
            pictureBoxAva_RGV.TabStop = false;
            // 
            // labelText_RGV
            // 
            labelText_RGV.AutoSize = true;
            labelText_RGV.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelText_RGV.Location = new Point(225, 9);
            labelText_RGV.Name = "labelText_RGV";
            labelText_RGV.Size = new Size(247, 184);
            labelText_RGV.TabIndex = 1;
            labelText_RGV.Text = "Разработчик: Рубанко Г.В.\r\n\r\n\r\n\r\n\r\nГруппа: ИБКСб-24-1\r\n \r\n\r\n";
            labelText_RGV.Click += labelText_RGV_Click;
            // 
            // buttonOK_RGV
            // 
            buttonOK_RGV.BackColor = Color.AliceBlue;
            buttonOK_RGV.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK_RGV.Location = new Point(507, 176);
            buttonOK_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonOK_RGV.Name = "buttonOK_RGV";
            buttonOK_RGV.Size = new Size(87, 21);
            buttonOK_RGV.TabIndex = 2;
            buttonOK_RGV.Text = "ОК";
            buttonOK_RGV.UseVisualStyleBackColor = false;
            buttonOK_RGV.Click += buttonOK_RGV_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.tyumenskij_industrialnyj_universitet;
            pictureBox1.Location = new Point(503, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(604, 206);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_RGV);
            Controls.Add(labelText_RGV);
            Controls.Add(pictureBoxAva_RGV);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_RGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxAva_RGV;
        private Label labelText_RGV;
        private Button buttonOK_RGV;
        private PictureBox pictureBox1;
    }
}
