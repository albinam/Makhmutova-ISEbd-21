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
        public double GunRange { private set; get; }
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
       double gunRange, bool flag, bool mask) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            GunRange = gunRange;
            Flag = flag;
            Mask = mask;
        }
        public ArtilleryMount(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                GunRange =Convert.ToDouble(strs[4]);
                Flag = Convert.ToBoolean(strs[5]);
                Mask = Convert.ToBoolean(strs[6]); }
        }
        public override void DrawArmorCar(Graphics g)
        {
            Pen penBlack = new Pen(Color.Black);
            g.DrawRectangle(penBlack, _startPosX + 10, _startPosY + 20, 70, 22);
            Brush brushDopColor = new SolidBrush(DopColor);
            g.FillRectangle(brushDopColor, _startPosX + 22, _startPosY + 5, 47, 15);
            g.DrawRectangle(penBlack, _startPosX + 10, _startPosY + 20, 70, 22);
            g.DrawLine(penBlack, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
            if (Flag)
            {
                g.DrawRectangle(penBlack, _startPosX + 45, _startPosY - 10, 7, 5);
                Brush brushWhite = new SolidBrush(Color.White);
                g.FillRectangle(brushWhite, _startPosX + 45, _startPosY - 10, 7, 5);
                g.DrawLine(penBlack, _startPosX + 52, _startPosY - 5, _startPosX + 52, _startPosY + 5);
            }
            base.DrawArmorCar(g);
            if (Mask)
            {
                Pen penMask = new Pen(MainColor);
                g.DrawLine(penMask, _startPosX, _startPosY, _startPosX + 80, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 10, _startPosY, _startPosX + 90, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 20, _startPosY, _startPosX + 100, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 30, _startPosY, _startPosX + 110, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 40, _startPosY, _startPosX + 120, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 100, _startPosY, _startPosX + 20, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 90, _startPosY, _startPosX + 10, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 80, _startPosY, _startPosX, _startPosY + 60);
                g.DrawLine(penMask, _startPosX + 70, _startPosY, _startPosX - 10, _startPosY + 60);
            }
        }
        /// Смена дополнительного цвета        
        /// </summary>        
        /// <param name="color"></param>        
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + GunRange + ";" +Flag + ";" +Mask;
        }
    }
}
