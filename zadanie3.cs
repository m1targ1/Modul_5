namespace Modul_5
{
    public partial class zadanie3 : Form
    {
        public zadanie3()
        {
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Добавить"
        {
            string task = textBoxTasks.Text.Trim(); // Получение текста из поля и удаление пробелов по краям
           
            if (string.IsNullOrEmpty(task)) // Проверка, пустое ли поле для ввода задачи
            {
                // Если поле пустое, показ сообщения об ошибке
                MessageBox.Show("Ошибка: поле для ввода задачи не должно быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода
            }
                       
            ListBoxCheckedTasks.Items.Add(task); // Добавление введенной задачи в список задач
            textBoxTasks.Clear(); // Очистка текстового поля после добавления задачи
        }
        
        private void buttonDel_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Удалить"
        {
            
            if (ListBoxCheckedTasks.SelectedItem == null) // Проверка, выбрана ли задача для удаления
            {
                // Если задача не выбрана, показ сообщения об ошибке
                MessageBox.Show("Ошибка: выберите задачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода
            }
            
            ListBoxCheckedTasks.Items.Remove(ListBoxCheckedTasks.SelectedItem); // Удаление выбранной задачи из списка задач
        }
    }
}
