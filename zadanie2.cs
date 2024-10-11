namespace Modul_5
{
    public partial class zadanie2 : Form
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog // Новое диалоговое окно для открытия файла
            {
                Filter = "Text Files (*.txt)|*.txt", // Фильтр только для текстовых файлов
            };

            // Проверка, был ли выбран файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName); // Отображение содержимого файла в RichTextBox
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog // Новое диалоговое окно для сохранения файла
            {
                Filter = "Text Files (*.txt)|*.txt", // Фильтр только для текстовых файлов
            };

            // Проверка, был ли выбран файл
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text); // Сохранение содержимого RichTextBox в указанный файл
            }
        }
    }
}
