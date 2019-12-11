using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class ArmorCar : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public ArmorCar(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public ArmorCar(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawArmorCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 10, _startPosY + 20, 70, 22);
            Brush br2 = new SolidBrush(Color.Brown);
            g.DrawRectangle(pen, _startPosX + 7, _startPosY + 42, 75, 10);
            g.FillRectangle(br2, _startPosX + 7, _startPosY + 42, 75, 10);
            g.DrawEllipse(pen, _startPosX + 8, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 17, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 26, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 35, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 44, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 53, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 62, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 71, _startPosY + 42, 9, 9);
            List<Point> star = new List<Point>(12);
            star.Add(new Point((int)_startPosX + 41, (int)_startPosY + 26));
            star.Add(new Point((int)_startPosX + 39, (int)_startPosY + 29));
            star.Add(new Point((int)_startPosX + 36, (int)_startPosY + 29));
            star.Add(new Point((int)_startPosX + 39, (int)_startPosY + 32));
            star.Add(new Point((int)_startPosX + 38, (int)_startPosY + 35));
            star.Add(new Point((int)_startPosX + 41, (int)_startPosY + 32));
            star.Add(new Point((int)_startPosX + 44, (int)_startPosY + 35));
            star.Add(new Point((int)_startPosX + 43, (int)_startPosY + 32));
            star.Add(new Point((int)_startPosX + 46, (int)_startPosY + 29));
            star.Add(new Point((int)_startPosX + 43, (int)_startPosY + 29));
            Pen pen2 = new Pen(Color.Red);
            g.DrawPolygon(pen2, star.ToArray<Point>());
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
