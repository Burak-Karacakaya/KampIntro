using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarket
{
    internal class CampaingManager : ICampignService
    {
        public void DeleteCampign(Game game)
        {
            Console.WriteLine("The campaign has been removed in the" + game.Name);
        }

        public bool InsertCampign(Game game)
        {
            Console.WriteLine("A campaign has been started in the" + game.Name);
            return true;
        }

        public void UpdateCampign(Game game)
        {
            Console.WriteLine("The campaign has been updated in the" + game.Name);
        }
    }
}
