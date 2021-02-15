using System;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer() { GamerId = 1, BirthYear = 1998, GamerFirstName = "Burak", GamerLastName = "Yıldırım", IdentityNumber = "1234567890" };
            GamerManager gamerManager2 = new GamerManager(new GamerCheckManager());
            Gamer gamer2 = new Gamer() { GamerId = 2, BirthYear = 2020, GamerFirstName = "Çağrı", GamerLastName = "Akça", IdentityNumber = "0987654321" };

            Game game1 = new Game() { GameId = 1, GameName = "CS:GO", GamePrice = 98 };
            Game game2 = new Game() { GameId = 2, GameName = "FIFA21", GamePrice = 450 };
            Game game3 = new Game() { GameId = 3, GameName = "NBA2K21", GamePrice = 300 };

            Campaign campaign1 = new Campaign() { Name = "Yılbaşı ", DiscountRate = 25, Id = 1 };
            Campaign campaign2 = new Campaign() { Name = "Yeni Üye ", DiscountRate = 10, Id = 2 };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game2, gamer1);
            salesManager.CampaignSales(game3, gamer2, campaign2);
        }
    }
}
