using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Fakes
{
    public class StoriesServiceFake : IStoriesService
    {
        public async Task<IList<StoriesGroup>> GetStories()
        {
            return await Task.Run(() =>
            {
                return new List<StoriesGroup>
                {
                    new StoriesGroup(
                        "Книги:",
                        new List<Stories>()
                        {
                            GetNewStories("The bun", "stories_coffe", "#f5b43f"),
                            GetNewStories("The Old Man and The Sea", "stories_candle", "#503322"),
                            GetNewStories("Alice's Adventures in Wonderland", "stories_bread", "#68ad33"),
                            GetNewStories("The Little Prince", "stories_gift", "#de90d0")
                        }
                    )
                };
            });
        }

        private Stories GetNewStories(string name, string image, string shadowBottomColor)
        {
            return new Stories
            {
                Name = name,
                Image = image,
                ShadowBottomColor = shadowBottomColor
            };
        }
    }
}
