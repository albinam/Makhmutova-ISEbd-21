using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    class ArtilleryMount : ArmorCar, IComparable<ArtilleryMount>, IEquatable<ArtilleryMount>
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
                GunRange = Convert.ToDouble(strs[4]);
                Flag = Convert.ToBoolean(strs[5]);
                Mask = Convert.ToBoolean(strs[6]);
            }
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
        /// Смена дополнительного цвета        
        /// </summary>        
        /// <param name="color"></param>        
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + GunRange + ";" + Flag + ";" + Mask;
        }
        public int CompareTo(ArtilleryMount other)
        {
            var res = (this is ArmorCar).CompareTo(other is ArmorCar);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (GunRange != other.GunRange)
            {
                return GunRange.CompareTo(other.GunRange);
            }
            if (Flag != other.Flag)
            {
                return Flag.CompareTo(other.Flag);
            }
            if (Mask != other.Mask)
            {
                return Mask.CompareTo(other.Mask);
            }
            return 0;
        }
        public bool Equals(ArtilleryMount other)
        {
            var res = (this as ArmorCar).Equals(other as ArmorCar);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (GunRange != other.GunRange)
            {
                return false;
            }
            if (Flag != other.Flag)
            {
                return false;
            }
            if (Mask != other.Mask)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is ArtilleryMount carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}