using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class DrawGuns
    {
        public Guns guns { private get; set; }
        private float x;
        private float y;
        public DrawGuns(Guns numberOfGuns, float _startPosX, float _startPosY)
        {
            guns = numberOfGuns;
            x = _startPosX;
            y = _startPosY;
        }
        private int ConvertToInt(Guns numberOfGuns)
        {
            return (int)numberOfGuns + 1;
        }
        public void GunsDraw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            int n = ConvertToInt(guns);
            if (n == 1)
            {
                g.DrawLine(pen, x + 69, y + 12, x + 89, y + 12);
            }
            if (n == 2)
            {
                g.DrawLine(pen, x + 69, y + 12, x + 89, y + 12);
                g.DrawLine(pen, x + 69, y + 9, x + 89, y + 9);
            }
            if (n== 3)
            {
                g.DrawLine(pen, x + 69, y + 12, x + 89, y + 12);
                g.DrawLine(pen, x + 69, y + 9, x + 89, y + 9);
                g.DrawLine(pen, x + 69, y + 15, x + 89, y + 15);
            }
        }
    }
}