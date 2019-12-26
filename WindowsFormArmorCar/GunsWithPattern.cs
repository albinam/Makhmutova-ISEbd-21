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
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, _startPosX + 22, _startPosY + 5, 47, 15);
            Brush brushWhite = new SolidBrush(Color.White);
            g.FillRectangle(brushWhite, _startPosX + 25, _startPosY + 8, 8, 2);
            Brush brushBlue = new SolidBrush(Color.Blue);
            g.FillRectangle(brushBlue, _startPosX + 25, _startPosY + 10, 8, 2);
            Brush brushRed = new SolidBrush(Color.Red);
            g.FillRectangle(brushRed, _startPosX + 25, _startPosY + 12, 8, 2);
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
