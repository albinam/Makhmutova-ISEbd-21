using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class MilitatyBaseNotFoundException:Exception
    {
        public MilitatyBaseNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        { }
    }
}