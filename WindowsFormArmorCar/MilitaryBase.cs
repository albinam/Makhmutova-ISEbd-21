using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class MilitaryBase<T> : IEnumerator<T>, IEnumerable<T>, IComparable<MilitaryBase<T>> 
        where T : class, ITransport
    {
        private Dictionary<int, T> places;
        /// <summary>         
        /// Максимальное количество мест на парковке         
        /// </summary>        
        private int _maxCount;
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
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)         
        /// </summary>   
        private int _currentIndex;
        /// <summary>         
        /// Получить порядковое место на парковке       
        /// </summary>   
        public int GetKey
        {
            get
            {
                return places.Keys.ToList()[_currentIndex];
            }
        }
        /// <summary>        
        /// Конструктор       
        /// </summary>         
        /// /// <param name="sizes">Количество мест на парковке</param>        
        /// /// <param name="pictureWidth">Рамзер парковки - ширина</param>        
        /// /// <param name="pictureHeight">Рамзер парковки - высота</param>         
        public MilitaryBase(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _currentIndex = -1;
            places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
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
            if (p.places.Count == p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p.places.ContainsValue(artilleryMount))
            {
                throw new ParkingAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, artilleryMount);
                    p.places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i % 5 * _placeSizeHeight + 15, p.PictureWidth, p.PictureHeight);
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
            if (!p.CheckFreePlace(index))
            {
                T car = p.places[index];
                p.places.Remove(index);
                return car;
            }
            throw new ParkingNotFoundException(index);
        }
        /// <summary>         
        /// Метод проверки заполнености парковочного места (ячейки массива)         
        /// </summary>         
        /// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>         
        /// <returns></returns>         
        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }
        /// <summary>         
        /// Метод отрисовки парковки        
        /// </summary>         
        /// <param name="g"></param>         
        public void Draw(Graphics g)
        {
            DrawMilitaryBase(g);
            var keys = places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                places[keys[i]].DrawArmorCar(g);
            }
        }
        /// <summary>         
        /// /// Метод отрисовки разметки парковочных мест      
        /// /// </summary>       
        /// /// <param name="g"></param>        
        private void DrawMilitaryBase(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);             //границы праковки             
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 400);
            for (int i = 0; i < _maxCount / 4; i++)
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
        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    places.Add(ind, value);
                    places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new ParkingOccupiedPlaceException(ind);
                }
            }
        }
        /// <summary>         
        /// Метод интерфейса IEnumerator для получения текущего элемента         
        /// </summary>        
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[_currentIndex]];
            }
        }
        /// <summary>         
        /// Метод интерфейса IEnumerator для получения текущего элемента        
        /// </summary>         
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        /// <summary>         
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта        
        /// </summary>        
        public void Dispose()
        {
            places.Clear();
        }

        /// <summary>        
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции     
        /// </summary>         
        /// <returns></returns>         
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// <summary>         
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции        
        /// </summary>       
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>         
        /// Метод интерфейса IEnumerable        
        /// </summary>         
        /// <returns></returns>       
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>         
        /// Метод интерфейса IEnumerable        
        /// </summary>         
        /// <returns></returns>        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>         
        /// Метод интерфейса IComparable        
        /// </summary>        
        /// <param name="other"></param>        
        /// <returns></returns>         
        public int CompareTo(MilitaryBase<T> other)
        {
            if (places.Count > other.places.Count)
            {
                return -1;
            }
            else if (places.Count < other.places.Count)
            {
                return 1;
            }
            else if (places.Count > 0)
            {
                var thisKeys = places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < places.Count; ++i)
                {
                    if (places[thisKeys[i]] is ArmorCar && other.places[thisKeys[i]] is ArtilleryMount)
                    {
                        return 1;
                    }
                    if (places[thisKeys[i]] is ArtilleryMount && other.places[thisKeys[i]] is ArmorCar)
                    {
                        return -1;
                    }
                    if (places[thisKeys[i]] is ArmorCar && other.places[thisKeys[i]] is ArmorCar)
                    {
                        return (places[thisKeys[i]] is ArmorCar).CompareTo(other.places[thisKeys[i]] is ArmorCar);
                    }
                    if (places[thisKeys[i]] is ArtilleryMount && other.places[thisKeys[i]] is ArtilleryMount)
                    {
                        return (places[thisKeys[i]] is ArtilleryMount).CompareTo(other.places[thisKeys[i]] is ArtilleryMount);
                    }
                }
            }
            return 0;
        }
    }
}