using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            if(gamer.GamerId ==1 && gamer.BirthYear == 1998 && gamer.GamerFirstName == "Burak" && gamer.GamerLastName == "Yıldırım" && gamer.IdentityNumber == "1234567890")
            {
                return true;
            }
            else if (gamer.GamerId == 2 && gamer.BirthYear == 2020 && gamer.GamerFirstName == "Çağrı" && gamer.GamerLastName == "Akça" && gamer.IdentityNumber == "0987654321")
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
