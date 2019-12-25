using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class SimpleGuns:IGuns
    {
        public float _startPosX;
        public float _startPosY;
        public SimpleGuns(float x, float y)
        {
            _startPosX=x;
            _startPosY = y;
        }
        public void GunsDraw(Graphics g, Guns numberOfGuns,Color color)
        {        
            int n = (int) numberOfGuns;
            Brush br1 = new SolidBrush(color);
            g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
            Pen pen = new Pen(Color.Black);
            if (n == 0)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
            }
            if (n == 1)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 9);
            }
            if (n== 2)
            {
                g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 9, _startPosX + 89, _startPosY + 9);
                g.DrawLine(pen, _startPosX + 69, _startPosY + 15, _startPosX + 89, _startPosY + 15);
            }
        }
    }
}