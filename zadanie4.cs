using System;
using System.Drawing;
using System.Windows.Forms;

namespace Modul_5
{
    public partial class zadanie4 : Form
    {
        private Image originalImage; // Оригинальное изображение
        private float scaleFactor = 1.0f;  // Начальный коэффициент масштабирования
        private const float scaleStep = 0.1f;  // Шаг увеличения/уменьшения

        public zadanie4()
        {
            InitializeComponent();
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;  // Подписка на событие прокрутки мыши
            pictureBox1.Paint += PictureBox1_Paint;  // Подписка на событие перерисовки
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // Вызов нового окна для открытия файла
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Фильтр только для изображений
                if (openFileDialog.ShowDialog() == DialogResult.OK) // Если зпавершено с "Ок"
                {
                    originalImage = Image.FromFile(openFileDialog.FileName); // Открытие файла
                    pictureBox1.Invalidate();  // Перерисовка PictureBox
                }
            }
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Увеличение или уменьшение коэффициента масштабирования в зависимости от направления прокрутки колеса
            if (e.Delta > 0)
            {
                scaleFactor += scaleStep;  // Прокрутка вверх — увеличение
            }
            else if (e.Delta < 0)
            {
                scaleFactor = Math.Max(scaleFactor - scaleStep, 0.1f);  // Прокрутка вниз — уменьшение, но не меньше 0.1
            }

            pictureBox1.Invalidate();  // Обновление изображения для перерисовки
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (originalImage != null)
            {
                // Рассчёт новых размеров изображения
                int newWidth = (int)(originalImage.Width * scaleFactor);
                int newHeight = (int)(originalImage.Height * scaleFactor);

                // Рассчёт центра pictureBox для изображения
                int x = (pictureBox1.Width - newWidth) / 2;
                int y = (pictureBox1.Height - newHeight) / 2;
                                
                e.Graphics.DrawImage(originalImage, x, y, newWidth, newHeight); // Рисовка изображение с применённым масштабированием
            }
        }
    }
}
