using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Modul_5
{
    // Основной класс формы
    public partial class zadanie1 : Form
    {
        private Point startPoint; // Точка, с которой начинается рисование
        private List<(string shape, Point start, Point end)> shapes = new(); // Список фигур, которые будут нарисованы на холсте
        private string currentShape = "";  // Переменная для хранения текущей фигуры(по умолчанию ничего не рисуется)
        private Point? currentEndPoint = null; // Текущая конечная точка для отображения временной фигуры

        public zadanie1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.White; // Установка белого фона для холста
            // Подключение обработчиков событий мыши
            pictureBox1.MouseDown += Canvas_MouseDown;
            pictureBox1.MouseMove += Canvas_MouseMove;
            pictureBox1.MouseUp += Canvas_MouseUp;
            pictureBox1.Paint += PictureBox1_Paint; // Подключение обработчика для перерисовки холста
        }
                
        private void Canvas_MouseDown(object sender, MouseEventArgs e) // Обработчик нажатия кнопки мыши
        {
            startPoint = e.Location; // Установка начальной точки рисования
            currentEndPoint = e.Location; // Установка текущей конечной точки
        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs e) // Обработчик перемещения мыши
        {
            if (e.Button == MouseButtons.Left) // Проверка, нажата ли левая кнопка мыши
            {
                currentEndPoint = e.Location; // Обновление конечной точки в зависимости от положения мыши
                pictureBox1.Invalidate();  // Вызов перерисовки холста
            }
        }
        
        private void Canvas_MouseUp(object sender, MouseEventArgs e) // Обработчик отпускания кнопки мыши
        {
            // Добавление нарисованной фигуры в список
            shapes.Add((currentShape, startPoint, e.Location));
            currentEndPoint = null; // Сброс текуей конечной точку
            pictureBox1.Invalidate();  // Вызов перерисовки холста
        }

        // Метод для перерисовки всех фигур на холсте
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Получение объекта Graphics для рисования
            // Рисовка всех сохраненные фигуры
            foreach (var shape in shapes)
            {
                DrawShape(g, shape.shape, shape.start, shape.end);
            }
            // Если есть текущая конечная точка, рисует текущую фигуру
            if (currentEndPoint.HasValue)
            {
                DrawShape(g, currentShape, startPoint, currentEndPoint.Value);
            }
        }
        
        private void DrawShape(Graphics g, string shape, Point p1, Point p2) // Метод для рисования фигуры на графике
        {
            Pen pen = new Pen(Color.Black, 2); // Создание пера для рисования
            switch (shape)
            {
                case "Line":
                    g.DrawLine(pen, p1, p2); // Рисовка линии
                    break;
                case "Circle":
                    int size1 = Math.Min(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y)); // Определение размера квадрата
                    g.DrawEllipse(pen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), size1, size1); // Рисовка круга
                    break;
                case "Square":
                    int size2 = Math.Min(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y)); // Определение размера квадрата
                    g.DrawRectangle(pen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), size2, size2); // Рисовка квадрата
                    break;
            }
        }
    
        private void ButtonLine_Click(object sender, EventArgs e) // Обработчик для кнопки линии
        {
            currentShape = "Line"; // Установка текущей фигуры как линии
        }
        private void ButtonCircle_Click(object sender, EventArgs e) // Обработчик для кнопки круга
        {
            currentShape = "Circle"; // Установка текущей фигуры как круга
        }
        private void ButtonSquare_Click(object sender, EventArgs e) // Обработчик для кнопки квадрата
        {
            currentShape = "Square"; // Установка текущей фигуры как квадрата
        }
        private void ButtonClear_Click(object sender, EventArgs e) // Обработчик для кнопки очистки холста
        {
            shapes.Clear();  // Очистка список фигур
            pictureBox1.Invalidate();  // Перерисовка холста
        }
    }
}
