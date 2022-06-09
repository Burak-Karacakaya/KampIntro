using System;

namespace GameMarket
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerRegisterManager gamerRegisterManager = new GamerRegisterManager(new RealPersonCheckManager());
            gamerRegisterManager.Register
                (new Gamer
                {BirthYear = 1991,
                 FirstName = "Burak",
                 Lastname = "Karacakaya",
                 IdentityNumber = 123456
                });
        }
    }
}
