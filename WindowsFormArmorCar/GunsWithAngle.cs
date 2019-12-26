using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class GunsWithAngle:IGuns
    { 
        public float _startPosX;
        public float _startPosY;
        public GunsWithAngle(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void GunsDraw(Graphics g, Guns numberOfGuns, Color color)
        {
            int n = (int)numberOfGuns;
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, _startPosX + 22, _startPosY + 5, 47, 15);
            Brush brushOrange = new SolidBrush(Color.Orange);
            g.FillRectangle(brushOrange, _startPosX + 25, _startPosY + 8, 25, 1);
            g.FillRectangle(brushOrange, _startPosX + 25, _startPosY + 10, 25, 1);
            g.FillRectangle(brushOrange, _startPosX + 25, _startPosY + 12, 25, 1);
            Brush brushBlack = new SolidBrush(Color.Black);
            g.FillRectangle(brushBlack, _startPosX + 25, _startPosY + 9, 25, 1);
            g.FillRectangle(brushBlack, _startPosX + 25, _startPosY + 11, 25, 1);
            Pen penBlack = new Pen(Color.Black);
            if (n == 0)
            {
                g.DrawLine(penBlack, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 9);
            }
            if (n == 1)
            {
                g.DrawLine(penBlack, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 9);
                g.DrawLine(penBlack, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 6);
            }
            if (n == 2)
            {
                g.DrawLine(penBlack, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 9);
                g.DrawLine(penBlack, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 6);
                g.DrawLine(penBlack, _startPosX + 69, _startPosY + 15, _startPosX + 89, _startPosY + 12);
            }
        }
    }
}
