using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormArmorCar
{
    public class MilitaryBaseAlreadyHaveException:Exception
    {
        public MilitaryBaseAlreadyHaveException() : base("На парковке уже есть такая машина")
        { }
    }
}