using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "Kampanyası %" + campaign.DiscountRate + " indirim ile eklendi!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "Kampanyası güncellendi!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "Kampanyası silindi!");
        }
    }
}
