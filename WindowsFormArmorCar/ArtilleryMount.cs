using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    class ArtilleryMount : ArmorCar
    {
        /// <summary>
        /// Дальность стрельбы
        /// </summary>
        public float GunRange { private set; get; }
        /// <summary>
        /// маскировка
        /// </summary>
        public bool Mask { private set; get; }
        /// <summary>
        /// флаг
        /// </summary>
        public bool Flag { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
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
        public ArtilleryMount(int maxSpeed, float weight, Color mainColor, Color dopColor,
      float gunRange, bool flag, bool mask) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            GunRange = gunRange;
            Flag = flag;
            Mask = mask;
        }
        public override void DrawArmorCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
            Brush br1 = new SolidBrush(DopColor);
            g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
            g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
            if (Flag)
            {
                g.DrawRectangle(pen, _startPosX + 45, _startPosY - 10, 7, 5);
                Brush br3 = new SolidBrush(Color.White);
                g.FillRectangle(br3, _startPosX + 45, _startPosY - 10, 7, 5);
                g.DrawLine(pen, _startPosX + 52, _startPosY - 5, _startPosX + 52, _startPosY + 5);
            }
            base.DrawArmorCar(g);
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
        }
    }
}
