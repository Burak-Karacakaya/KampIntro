using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarket
{
    internal class RealPersonCheckManager : IRealPersonCheckService
    {
        public bool AreYouRealPerson(Gamer gamer)
        {
            if (gamer.BirthYear == 1991 && gamer.FirstName == "Burak" && gamer.Lastname == "Karacakaya" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
