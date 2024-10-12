using System.Data;

namespace Modul_5
{
    public partial class zadanie5 : Form
    {
        public zadanie5()
        {
            InitializeComponent();
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1"; // Добавление в textBox1 цифры
        }

        private void buttonNum2_Click(object sender, EventArgs e) { textBox1.Text += "2"; }
        private void buttonNum3_Click(object sender, EventArgs e) { textBox1.Text += "3"; }
        private void buttonNum4_Click(object sender, EventArgs e) { textBox1.Text += "4"; }
        private void buttonNum5_Click(object sender, EventArgs e) { textBox1.Text += "5"; }
        private void buttonNum6_Click(object sender, EventArgs e) { textBox1.Text += "6"; }
        private void buttonNum7_Click(object sender, EventArgs e) { textBox1.Text += "7"; }
        private void buttonNum8_Click(object sender, EventArgs e) { textBox1.Text += "8"; }
        private void buttonNum9_Click(object sender, EventArgs e) { textBox1.Text += "9"; }
        private void buttonNum0_Click(object sender, EventArgs e) { textBox1.Text += "0"; }
        private void buttonMultiply_Click(object sender, EventArgs e) { textBox1.Text += "*"; }
        private void buttonShare_Click(object sender, EventArgs e) { textBox1.Text += "/"; }
        private void buttonStack_Click(object sender, EventArgs e) { textBox1.Text += "+"; }
        private void buttonSubstract_Click(object sender, EventArgs e) { textBox1.Text += "-"; }
        private void buttonEqually_Click(object sender, EventArgs e)
        {
            try
            {                
                string expression = textBox1.Text; // Получение выражения из текстового поля  
                expression = expression.Replace(',', '.'); // Заменяем запятых на точки для корректного вычисления              
                var table = new DataTable(); // Использоввние DataTable для вычисления выражения                
                var result = table.Compute(expression, null); // Преобразование результата в число                                
                decimal decimalResult = Convert.ToDecimal(result); // Преобразование результата в число типа decimal                              
                textBox1.Text = decimalResult % 1 == 0 ? decimalResult.ToString("F0") : decimalResult.ToString(); // Форматирование результата: если целое число - вывод без дробной части
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в вычислении: " + ex.Message); // В случае ошибки вывод сообщения об ошибке
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Очистка textBox1
        }
  
        private void buttonDouble_Click(object sender, EventArgs e) // Обработчик для кнопки с точкой (для ввода дробных чисел)
        {
            // Проверка, есть ли уже точка в текущем числе
            string currentText = textBox1.Text;
            if (currentText.Length > 0)
            {
                // Если последним символом не является оператор
                if (Char.IsDigit(currentText.Last()))
                {
                    // Поиск последнего числа перед операцией
                    int lastOperatorIndex = currentText.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                    string lastOperand = currentText.Substring(lastOperatorIndex + 1);

                    // Если в последнем операнде нет точки, добавление ее
                    if (!lastOperand.Contains("."))
                    {
                        textBox1.Text += ".";
                    }
                }
            }
        }
    }
}
