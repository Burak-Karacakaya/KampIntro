using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarket
{
    internal interface IGameSalesService
    {
        void Sale(Game game, Gamer gamer);
    }
}
