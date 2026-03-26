using System;
using System.Drawing;
using System.Windows.Forms;

namespace Domashka_6
{
	public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(700, 500);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();


            // Заливаем фон формы
            g.FillRectangle(Brushes.LightBlue, 0, 0, this.Width, this.Height * 5/6);


            // Рисуем солнце
            g.FillEllipse(Brushes.Yellow, this.Width * 11/16, this.Height * 1/16,
                                          // радиус = 1/16
                                          this.Width * 2/16,  this.Height * 2/16);


            // Рисуем ствол дерева
                                          // X = 1/25 + 1/8 - 1/25   // Y = 1/18 + 1/8
            g.FillRectangle(Brushes.Gray, this.Width * 1/8,          (int)(this.Height * (1.0/18 + 1.0/8)),
                                          // width = 1/25 + 1/25     // height = 1 - (1/3 + Y)
                                          this.Width * 2/25,         (int)(this.Height * (1 - (1.0/3 + 1.0/18 + 1.0/8))));


            // Рисуем крону дерева
            g.FillEllipse(Brushes.LimeGreen, this.Width * 1/25, this.Height * 1/18,
                                             // радиус = 1/8
                                             this.Width * 2/8,  this.Height * 2/8);


            // Рисуем дом
            g.FillRectangle(Brushes.RoyalBlue, this.Width * 1/3, this.Height * 1/3,
                                          this.Width * 1/3, this.Height * 4/9);


            // Рисуем крышу
                         // X = 1/3, Y = 1/3
            Point p1 = new Point(this.Width * 1/3, this.Height * 1/3);

                         // X = 1/3 + 1/6 = 1/2, Y = 1/3 - 1/6 = 1/6
            Point p2 = new Point(this.Width * 1/2, this.Height * 1/6);

                         // X = 2/3, Y = 2/3
            Point p3 = new Point(this.Width * 2/3, this.Height * 1/3);

            Point[] poligon_points = new Point[] { p1, p2, p3 };


            g.FillPolygon(Brushes.MediumVioletRed, poligon_points);



            // Рисуем окна и дверь
                                 // X = 1/3 + 1/18 = 7/18, Y = 1/3 + 1/12 = 5/12
            g.FillRectangle(Brushes.White, this.Width * 7/18,  this.Height * 5/12,
                                           this.Width * 1/18,  this.Height * 1/12);

                                 // X = 1/2 + 1/18 = 10/18, Y = 1/3 + 1/12 = 5/12
            g.FillRectangle(Brushes.White, this.Width * 10/18, this.Height * 5/12,
                                           this.Width * 1/18,  this.Height * 1/12);
            
                                 // X = 1/2 - 1/26 = 12/26, Y = 1/2 + 1/30 = 16/30
            g.FillRectangle(Brushes.Black, this.Width * 12/26, this.Height * 16/30,
                                           this.Width * 1/13,  this.Height * 3/12);



            // Рисуем землю
            g.FillRectangle(Brushes.Orange, 0,          this.Height * 2/3,
                                            this.Width, this.Height * 1/6);



            // Рисуем облако
            g.FillEllipse(Brushes.White, this.Width * 24/32, this.Height * 9/64,
                                         // диаметр = 3/40
                                         this.Width * 3/40,  this.Height * 3/40);
            
            g.FillEllipse(Brushes.White, this.Width * 25/32, this.Height * 3/32,
                                         this.Width * 3/40,  this.Height * 3/40);

            g.FillEllipse(Brushes.White, this.Width * 26/32, this.Height * 3/32,
                                         this.Width * 3/40,  this.Height * 3/40);
            
            g.FillEllipse(Brushes.White, this.Width * 55/64, this.Height * 7/64,
                                         this.Width * 3/40,  this.Height * 3/40);

            g.FillEllipse(Brushes.White, this.Width * 26/32, this.Height * 9/64,
                                         this.Width * 3/40,  this.Height * 3/40);
            
            g.FillEllipse(Brushes.White, this.Width * 27/32, this.Height * 9/64,
                                         this.Width * 3/40,  this.Height * 3/40);



            // Рисуем dog.png
            Image img = Image.FromFile("../../Files/dog.png");
            g.DrawImage(img, this.Width * 3/5,  this.Height * 1/2,
                             this.Width * 3/20, this.Height * 1/4);


            // Пишем надись
            // Размер шрифта пропорционален площади (размеру) формы
            float font_size = ((float)this.Width * (float)this.Height) * 13/(700 * 500);

            Font font = new Font("Times New Roman", font_size, FontStyle.Bold | FontStyle.Italic);


            // Рисуем надись
            Point point = new Point(this.Width * 150/700, this.Height * 430/500);

            g.DrawString("Выполнил Ампилов Павел", font, Brushes.Black, point);



            // Освобожение ресурсов
            g.Dispose();
        }


		private void Form2_SizeChanged(object sender, EventArgs e)
		{
            this.Invalidate();  // Перерисовка
        }
	}
}
