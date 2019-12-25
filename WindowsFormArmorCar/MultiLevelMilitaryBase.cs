using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class MultiLevelMilitaryBase
    {
        /// <summary>        
        /// Список с уровнями парковки         
        /// </summary>       
        List<MilitaryBase<ITransport,IGuns>> militaryBaseStages;
        /// <summary>        
        /// Сколько мест на каждом уровне    
        /// </summary> 
        private const int countPlaces = 15;
        /// <summary>       
        /// Конструктор         
        /// </summary>         
        /// <param name="countStages">Количество уровенй парковки</param>        
        /// <param name="pictureWidth"></param>         
        /// <param name="pictureHeight"></param>        
        public MultiLevelMilitaryBase(int countStages, int pictureWidth, int pictureHeight)
        {
            militaryBaseStages = new List<MilitaryBase<ITransport,IGuns>>();
            for (int i = 0; i < countStages; ++i)
            {
                militaryBaseStages.Add(new MilitaryBase<ITransport,IGuns>(countPlaces, pictureWidth, pictureHeight));
            }
        } 
        /// <summary>        
        /// Индексатор         
        /// </summary>       
        /// <param name="ind"></param>        
        /// <returns></returns>        
        public MilitaryBase<ITransport,IGuns> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < militaryBaseStages.Count)
                {
                    return militaryBaseStages[ind];
                }
                return null;
            }
        }
        public ITransport this[int level, int key]
        {
            get
            {
                if (level > -1 && level < militaryBaseStages.Count)
                {
                    return militaryBaseStages[level].GetTransportByKey(key);
                }
                return null;
            }
        }
    } 
}