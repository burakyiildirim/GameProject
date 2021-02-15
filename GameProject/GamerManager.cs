using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if(_gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.GamerFirstName + "Sisteme kayıt oldu!");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı");
            }
        }

        public void Update(Gamer gamer)
        {
            if(_gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.GamerFirstName + "ın bilgileri güncellendi!");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı!");
            }
        }

        public void Delete(Gamer gamer)
        {
            if(_gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.GamerFirstName + "ın kaydı silindi!");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı!");
            }
        }
    }
}
