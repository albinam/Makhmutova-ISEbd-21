using System;
using System.Collections.Generic;
using System.IO;
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
        private int pictureWidth;
        private int pictureHeight;
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
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLevels:" + militaryBaseStages.Count);
                foreach (var level in militaryBaseStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var armor_car = level[i];
                            if (armor_car != null)
                            {
                                if (armor_car.GetType().Name == "ArmorCar")
                                {
                                    sw.WriteLine(i + ":ArmorCar:" + armor_car);
                                }
                                if (armor_car.GetType().Name == "ArtilleryMount")
                                {
                                    sw.WriteLine(i + ":ArtilleryMount:" + armor_car);
                                }
                            }
                        }
                        finally { }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            int counter = -1;
            ITransport armor_car = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                int count;
                bool isValid = line.Contains("CountLevels");
                if (isValid)
                {
                    count = Convert.ToInt32(line.Split(':')[1]);
                    if (militaryBaseStages != null)
                    {
                        militaryBaseStages.Clear();
                    }
                    militaryBaseStages = new List<MilitaryBase<ITransport,IGuns>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "Level")
                    {
                        counter++;
                        militaryBaseStages.Add(new MilitaryBase<ITransport,IGuns>(countPlaces,
        pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] splitLine = line.Split(':');
                    if (splitLine.Length > 2)
                    {
                        if (splitLine[1] == "ArmorCar")
                        {
                            armor_car = new ArmorCar(splitLine[2]);
                        }
                        else
                        {
                            armor_car = new ArtilleryMount(splitLine[2]);
                        }
                        militaryBaseStages[counter][Convert.ToInt32(splitLine[0])] = armor_car;
                    }
                }
                return true;
            }
        }
        public bool SaveLevel(int levelIndex, string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (levelIndex < 0 || levelIndex >= militaryBaseStages.Count)
            {
                return false;
            }
            if (militaryBaseStages[levelIndex] == null)
            {
                return false;
            }
            var level = militaryBaseStages[levelIndex];
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < countPlaces; i++)
                {
                    var armor_car = level[i];
                    if (armor_car != null)
                    {
                        if (armor_car.GetType().Name == "ArmorCar")
                        {
                            sw.WriteLine(i + ":ArmorCar:" + armor_car);
                        }
                        if (armor_car.GetType().Name == "ArtilleryMount")
                        {
                            sw.WriteLine(i + ":ArtilleryMount:" + armor_car);
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadLevel(int levelIndex, string filename)
        {
            if (levelIndex < 0 || levelIndex >= militaryBaseStages.Count)
            {
                return false;
            }
            if (!File.Exists(filename) || militaryBaseStages[levelIndex] == null)
            {
                throw new FileNotFoundException();
            }
            militaryBaseStages[levelIndex].Clear();
            ITransport armor_car = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] splitLine = line.Split(':');
                    if (splitLine.Length > 2)
                    {
                        if (splitLine[1] == "ArmorCar")
                        {
                            armor_car = new ArmorCar(splitLine[2]);
                        }
                        else
                        {
                            armor_car = new ArtilleryMount(splitLine[2]);
                        }
                        if (armor_car != null)
                        {
                            militaryBaseStages[levelIndex][Convert.ToInt32(splitLine[0])] = armor_car;
                        }
                    }
                }
                return true;
            }
        }
    }
}