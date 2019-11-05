using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class MilitaryBase<T> where T : class, ITransport
    {
        private T[] places;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        /// <summary>        
        /// Размер парковочного места (ширина)         
        /// </summary>       
        private const int _placeSizeWidth = 210;
        /// <summary>        
        /// Размер парковочного места (высота)         
        /// </summary>         
        private const int _placeSizeHeight = 80;
        /// <summary>        
        /// Конструктор       
        /// </summary>         
        /// /// <param name="sizes">Количество мест на парковке</param>        
        /// /// <param name="pictureWidth">Рамзер парковки - ширина</param>        
        /// /// <param name="pictureHeight">Рамзер парковки - высота</param>         
        public MilitaryBase(int sizes, int pictureWidth, int pictureHeight)
        {
            places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < places.Length; i++)
            {
                places[i] = null;
            }
        }

        /// <summary>         
        /// Перегрузка оператора сложения         
        /// Логика действия: на парковку добавляется автомобиль         
        /// </summary>         
        /// <param name="p">Парковка</param>      
        /// <param name=" artilleryMount">Добавляемый автомобиль</param>      
        /// <returns></returns>     
        public static int operator +(MilitaryBase<T> p, T artilleryMount)
        {
            for (int i = 0; i < p.places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places[i] = artilleryMount;
                    p.places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                        i % 5 * _placeSizeHeight + 15, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>         
        /// Перегрузка оператора вычитания       
        /// Логика действия: с парковки забираем автомобиль      
        /// </summary>         
        /// <param name="p">Парковка</param>       
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>         
        /// <returns></returns> 
        public static T operator -(MilitaryBase<T> p, int index)
        {
            if (index < 0 || index > p.places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T car = p.places[index];
                p.places[index] = null;
                return car;
            }
            return null;
        }
        /// <summary>         
        /// Метод проверки заполнености парковочного места (ячейки массива)         
        /// </summary>         
        /// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>         
        /// <returns></returns>         
        private bool CheckFreePlace(int index)
        {
            return places[index] == null;
        }
        /// <summary>         
        /// Метод отрисовки парковки        
        /// </summary>         
        /// <param name="g"></param>         
        public void Draw(Graphics g)
        {
            DrawMilitaryBase(g);
            for (int i = 0; i < places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {//если место не пустое                     
                    places[i].DrawArmorCar(g);
                }
            }
        }
        /// <summary>         
        /// /// Метод отрисовки разметки парковочных мест      
        /// /// </summary>       
        /// /// <param name="g"></param>        
        private void DrawMilitaryBase(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);             //границы праковки             
            g.DrawRectangle(pen, 0, 0, (places.Length / 5) * _placeSizeWidth, 400);
            for (int i = 0; i < places.Length / 4; i++)
            {
                //отрисовываем, по 5 мест на линии                 
                for (int j = 0; j < 5; ++j)
                {//линия рамзетки места                     
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                        i * _placeSizeWidth + 120, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
