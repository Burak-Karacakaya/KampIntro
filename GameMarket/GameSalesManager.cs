using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarket
{
    internal class GameSalesManager : IGameSalesService
    {
        ICampignService _campignService;
        public GameSalesManager(ICampignService campingService)
        {
            _campignService = campingService;
        }

        public void ApplyCampaing(Game game, Gamer gamer)
        {
            Console.WriteLine("Dear " + gamer.Lastname + ", you can take advantage of the campaign.");
        }

        

        public void Sale(Game game, Gamer gamer)
        {
            if (_campignService.InsertCampign(game) == true)
            {
                Console.WriteLine("You can benefit from the defined campaign in this game.");
                
            }
            else
            {
                Console.WriteLine("There is no defined campaign in this game.");
                
            }
            Console.WriteLine("Dear " + gamer.Lastname + " your game purchase has been successfully completed.");
        }
    }
}
