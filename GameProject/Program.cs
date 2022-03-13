
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEstateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1989,
                FirstName = "Kaan",
                LastName = "Çolak",
                IdentityNumber = 12345
            });
        }
    }
}
