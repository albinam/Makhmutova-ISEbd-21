using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class GunsWithPattern : IGuns
    {
        public float _startPosX;
        public float _startPosY;
        public GunsWithPattern(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void GunsDraw(Graphics g, Guns numberOfGuns, Color color)
        {
            int n = (int)numberOfGuns;
            Brush br1 = new SolidBrush(color);
            g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
            Brush br2 = new SolidBrush(Color.White);
            g.FillRectangle(br2, _startPosX + 25, _startPosY + 8, 8, 2);
            Brush br3 = new SolidBrush(Color.Blue);
            g.FillRectangle(br3, _startPosX + 25, _startPosY + 10, 8, 2);
            Brush br4 = new SolidBrush(Color.Red);
            g.FillRectangle(br4, _startPosX + 25, _startPosY + 12, 8, 2);
            Pen pen = new Pen(color);
            if (n == 0)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
            }
            if (n == 1)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 9);
            }
            if (n == 2)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 9);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 15, _startPosX + 89, _startPosY + 15);
            }
        }

    }
}