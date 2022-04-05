using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Interfaces
{
    public interface IFriendsService
    {
        Task<IList<Friend>> GetFriends();
    }
}
