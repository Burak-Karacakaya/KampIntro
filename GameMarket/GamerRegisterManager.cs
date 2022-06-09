using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarket
{
    internal class GamerRegisterManager : IGamerRegisterService
    {

        IRealPersonCheckService _realPersonCheckService;

        public GamerRegisterManager(IRealPersonCheckService realPersonCheckService)
        {
            _realPersonCheckService = realPersonCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Dear " + gamer.Lastname + "your registration has been successfully deleted from the system.");
        }

        public void Register(Gamer gamer)
        {
            if (_realPersonCheckService.AreYouRealPerson(gamer) == true)
            {
                Console.WriteLine("Dear " + gamer.Lastname + "your registration has been done successfully.");
            }
            else
            {
                Console.WriteLine("Dear " + gamer.Lastname + "your registration could not be performed because your information could not be verified.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Dear " + gamer.Lastname + "your information has been successfully updated.");
        }
    }
}
