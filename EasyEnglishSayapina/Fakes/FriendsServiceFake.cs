using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Fakes
{
    public class FriendsServiceFake : IFriendsService
    {
        public async Task<IList<Friend>> GetFriends()
        {
            return await Task.Run(() =>
            {
                return new List<Friend>()
                {
                    GetNewFriend("profile_friends_lisa", "Stasia Luminarskaya", "200 XP"),
                    GetNewFriend("profile_friends_bart", "Asya Ostwald", "500 XP"),
                    GetNewFriend("profile_friends_homer", "Gera Savinov", "2000 XP"),
                    GetNewFriend("profile_friends_marge", "Vlad Sushkov", "10000 XP")
                };
            });
        }

        private static Friend GetNewFriend(
            string photo,
            string name,
            string experience)
        {
            return new Friend
            {
                Photo = photo,
                Name = name,
                Experience = experience
            };
        }
    }
}
