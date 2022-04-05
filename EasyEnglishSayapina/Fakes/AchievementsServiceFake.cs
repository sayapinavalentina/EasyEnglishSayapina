using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Fakes
{
    public class AchievementsServiceFake : IAchievementsService
    {
        public async Task<IList<Achievement>> GetAchievementsAsync()
        {
            return await Task.Run(() =>
            {
                return new List<Achievement>
                {
                    GetAchievement(
                        "profile_achievements_01",
                        "Уровень 9",
                        "Царь",
                        "Изучить 80 тем",
                        0.9875,
                        "79/80",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_02",
                        "Уровень 8",
                        "Интеллект",
                        "Выучить 5000 слов",
                        0.863,
                        "3863/5K",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_03",
                        "Уровень 5",
                        "Всезнайка",
                        "Выполнить 100 уроков без ошибок",
                        0.81,
                        "81/100",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_04",
                        "Уровень 7",
                        "Работяга",
                        "Заработать 7500 XP",
                        0.72,
                        "5,4K/7,5K",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_05",
                        "Уровень 3",
                        "Огонь",
                        "Учиться 14 дней подряд",
                        0.5,
                        "7/14",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_06",
                        "Уровень 1",
                        "Новичок",
                        "Прочитать подсказки",
                        1,
                        string.Empty,
                        false
                    )
                };
            });
        }

        private Achievement GetAchievement(
            string icon,
            string level,
            string name,
            string description,
            double progress,
            string status,
            bool isActive)
        {
            return new Achievement
            {
                Icon = icon,
                Level = level,
                Name = name,
                Description = description,
                Progress = progress,
                Status = status,
                IsActive = isActive
            };
        }
    }
}
