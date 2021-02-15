using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class SalesManager : ISalesService
    {
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " kullanıcısı " + game.GameName + " oyununu satın aldı!");
        }
        public void CampaignSales(Game game,Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerFirstName + " kullanıcısı " + campaign.Name + " kampanyası ile " + game.GameName + " oyununu satın aldı!");
        }
    }
}
