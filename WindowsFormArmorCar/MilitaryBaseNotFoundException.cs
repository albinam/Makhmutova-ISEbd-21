using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class MilitaryBaseNotFoundException:Exception
    {
        public MilitaryBaseNotFoundException(int i) : base("Не найдена машина по месту " + i)
        { }
    }
}