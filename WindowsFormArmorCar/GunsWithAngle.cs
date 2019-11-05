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
            Brush br1 = new SolidBrush(color);
            g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
            Brush br2 = new SolidBrush(Color.Orange);
            g.FillRectangle(br2, _startPosX + 25, _startPosY + 8, 25, 1);
            g.FillRectangle(br2, _startPosX + 25, _startPosY + 10, 25, 1);
            g.FillRectangle(br2, _startPosX + 25, _startPosY + 12, 25, 1);
            Brush br3 = new SolidBrush(Color.Black);
            g.FillRectangle(br3, _startPosX + 25, _startPosY + 9, 25, 1);
            g.FillRectangle(br3, _startPosX + 25, _startPosY + 11, 25, 1);

            Pen pen = new Pen(Color.Black);
            if (n == 0)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 9);
            }
            if (n == 1)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 9);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 6);
            }
            if (n == 2)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 9);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 6);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 15, _startPosX + 89, _startPosY + 12);

            }
        }
    }
}
