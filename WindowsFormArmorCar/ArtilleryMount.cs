using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    class ArtilleryMount
    {
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Дальность стрельбы
        /// </summary>
        public float GunRange { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// маскировка
        /// </summary>
        public bool Mask { private set; get; }
        /// <summary>
        /// флаг
        /// </summary>
        public bool Flag { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// количество орудий
        /// </summary>
        public Guns Guns { private get; set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="gunRange">дальность стрельбы</param>
        /// <param name="flag">сдается или нет</param>
        /// <param name="mask">есть максировка или нет</param>
        /// <param name="guns">количество орудий</param>

        public ArtilleryMount(int maxSpeed, float weight, Color mainColor, Color dopColor,
      float gunRange, bool flag, bool mask, Guns guns)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            GunRange = gunRange;
            Flag = flag;
            Mask = mask;
            Guns = guns;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        public void DrawArmorCar(Graphics g )
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
            if (Flag)
            {
                g.DrawRectangle(pen, _startPosX + 45, _startPosY - 10, 7, 5);
                Brush br3 = new SolidBrush(Color.White);
                g.FillRectangle(br3, _startPosX + 45, _startPosY - 10, 7, 5);
                g.DrawLine(pen, _startPosX + 52, _startPosY - 5, _startPosX + 52, _startPosY + 5);
            }
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 10, _startPosY + 20, 70, 22);
            Brush br1 = new SolidBrush(DopColor);
            g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
            Brush br2 = new SolidBrush(Color.Brown);
            g.DrawRectangle(pen, _startPosX + 7, _startPosY + 42, 77, 10);
            g.FillRectangle(br2, _startPosX + 7, _startPosY + 42, 77, 10);
            g.DrawEllipse(pen, _startPosX + 8, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 17, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 26, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 35, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 44, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 53, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 62, _startPosY + 42, 9, 9);
            g.DrawEllipse(pen, _startPosX + 71, _startPosY + 42, 9, 9);
            if (Mask)
            {
                Pen pen1 = new Pen(MainColor);
                g.DrawLine(pen1, _startPosX, _startPosY, _startPosX + 80, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 10, _startPosY, _startPosX + 90, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 20, _startPosY, _startPosX + 100, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 30, _startPosY, _startPosX + 110, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 40, _startPosY, _startPosX + 120, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 100, _startPosY, _startPosX + 20, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 90, _startPosY, _startPosX + 10, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 80, _startPosY, _startPosX, _startPosY + 60);
                g.DrawLine(pen1, _startPosX + 70, _startPosY, _startPosX - 10, _startPosY + 60);
            }
            DrawGuns drawGuns=new DrawGuns(Guns, _startPosX, _startPosY);
            drawGuns.GunsDraw(g);
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
            Brush br4 = new SolidBrush(Color.Red);
            g.DrawPolygon(pen2, star.ToArray<Point>());
        }
    }
}
