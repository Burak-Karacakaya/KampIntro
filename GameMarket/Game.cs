using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarket
{
    internal class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SalePrice { get; set; }
        public bool CampaingDefined { get; set; }
    }
}
