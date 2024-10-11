namespace Modul_5
{
    partial class zadanie1
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
            pictureBox1 = new PictureBox();
            ButtonLine = new Button();
            ButtonCircle = new Button();
            ButtonSquare = new Button();
            ButtonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 364);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ButtonLine
            // 
            ButtonLine.Location = new Point(12, 12);
            ButtonLine.Name = "ButtonLine";
            ButtonLine.Size = new Size(107, 31);
            ButtonLine.TabIndex = 1;
            ButtonLine.Text = "Линия";
            ButtonLine.UseVisualStyleBackColor = true;
            ButtonLine.Click += ButtonLine_Click;
            // 
            // ButtonCircle
            // 
            ButtonCircle.Location = new Point(125, 12);
            ButtonCircle.Name = "ButtonCircle";
            ButtonCircle.Size = new Size(107, 31);
            ButtonCircle.TabIndex = 2;
            ButtonCircle.Text = "Круг";
            ButtonCircle.UseVisualStyleBackColor = true;
            ButtonCircle.Click += ButtonCircle_Click;
            // 
            // ButtonSquare
            // 
            ButtonSquare.Location = new Point(238, 12);
            ButtonSquare.Name = "ButtonSquare";
            ButtonSquare.Size = new Size(107, 31);
            ButtonSquare.TabIndex = 3;
            ButtonSquare.Text = "Квадрат";
            ButtonSquare.UseVisualStyleBackColor = true;
            ButtonSquare.Click += ButtonSquare_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(351, 12);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(107, 31);
            ButtonClear.TabIndex = 4;
            ButtonClear.Text = "Очистить";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // zadanie1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(ButtonClear);
            Controls.Add(ButtonSquare);
            Controls.Add(ButtonCircle);
            Controls.Add(ButtonLine);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "zadanie1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "zadanie1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button ButtonLine;
        private Button ButtonCircle;
        private Button ButtonSquare;
        private Button ButtonClear;
    }
}