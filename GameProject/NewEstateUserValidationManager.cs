using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class NewEstateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
