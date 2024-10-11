namespace Modul_5
{
    partial class zadanie3
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
            ListBoxCheckedTasks = new CheckedListBox();
            ButtonAdd = new Button();
            textBoxTasks = new TextBox();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // ListBoxCheckedTasks
            // 
            ListBoxCheckedTasks.FormattingEnabled = true;
            ListBoxCheckedTasks.Location = new Point(12, 70);
            ListBoxCheckedTasks.Name = "ListBoxCheckedTasks";
            ListBoxCheckedTasks.Size = new Size(246, 292);
            ListBoxCheckedTasks.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(12, 41);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(95, 23);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Добавить";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // textBoxTasks
            // 
            textBoxTasks.Location = new Point(12, 12);
            textBoxTasks.Name = "textBoxTasks";
            textBoxTasks.Size = new Size(246, 23);
            textBoxTasks.TabIndex = 2;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(163, 41);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(95, 23);
            buttonDel.TabIndex = 3;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // zadanie3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 377);
            Controls.Add(buttonDel);
            Controls.Add(textBoxTasks);
            Controls.Add(ButtonAdd);
            Controls.Add(ListBoxCheckedTasks);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "zadanie3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "zadanie3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ListBoxCheckedTasks;
        private Button ButtonAdd;
        private TextBox textBoxTasks;
        private Button buttonDel;
    }
}