using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class MilitaryBaseOverflowException:Exception
    {
        public MilitaryBaseOverflowException() : base("На военное базе нет свободных мест")
        { }
    }
}