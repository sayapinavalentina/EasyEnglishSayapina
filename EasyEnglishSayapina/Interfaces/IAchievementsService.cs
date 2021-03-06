using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Interfaces
{
    public interface IAchievementsService
    {
        Task<IList<Achievement>> GetAchievementsAsync();
    }
}
