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
        private int GunsType;
        public Guns NumberOfGuns { private set; get; }
        string num;
        /// <param name="numberOfGuns">количество орудий</param>
        /// <param name="gunsType">тип орудия</param>
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
       double gunRange, bool flag, bool mask, Guns numberOfGuns, int gunsType) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            GunRange = gunRange;
            Flag = flag;
            Mask = mask;
            NumberOfGuns = numberOfGuns;
            GunsType = gunsType;
        }
        public ArtilleryMount(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                GunRange = Convert.ToDouble(strs[4]);
                Flag = Convert.ToBoolean(strs[5]);
                Mask = Convert.ToBoolean(strs[6]);
                num = Convert.ToString(strs[7]);
                switch (num)
                {
                    case "One":
                        {
                            NumberOfGuns = Guns.One;
                            break;
                        }
                    case "Two":
                        {
                            NumberOfGuns = Guns.Two;
                            break;
                        }
                    case "Three":
                        {
                            NumberOfGuns = Guns.Three;
                            break;
                        }
                }
                GunsType = Convert.ToInt32(strs[8]);
            }
        }
        public override void DrawArmorCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
            Brush br1 = new SolidBrush(DopColor);
            g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
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
            IGuns guns;
            switch (GunsType)
            {
                case 0:
                    guns = new SimpleGuns(_startPosX, _startPosY);
                    break;
                case 1:
                    guns = new GunsWithPattern(_startPosX, _startPosY);
                    break;
                case 2:
                    guns = new GunsWithAngle(_startPosX, _startPosY);
                    break;
                default:
                    guns = new SimpleGuns(_startPosX, _startPosY);
                    break;
            }
            guns.GunsDraw(g, NumberOfGuns, DopColor);
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
            return base.ToString() + ";" + DopColor.Name + ";" + GunRange + ";" + Flag + ";" + Mask + ";" + NumberOfGuns + ";" + GunsType;
        }
        public void SetGunType(int type)
        {
            GunsType = type;
        }
    }
}