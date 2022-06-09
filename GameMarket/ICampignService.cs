using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarket
{
    internal interface ICampignService
    {
        bool InsertCampign(Game game);
        void UpdateCampign(Game game);
        void DeleteCampign(Game game);


    }
}
