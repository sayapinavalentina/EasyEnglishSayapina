using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Enums;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Fakes
{
    public class StoreServiceFake : IStoreService
    {
        public async Task<IList<StoreItemGroup>> GetItems()
        {
            return await Task.Run(() =>
            {
                var storeItems = GetStoreItems();
                return GroupStoreItems(storeItems);
            });
        }

        private List<StoreItem> GetStoreItems()
        {
            return new List<StoreItem>
            {
                GetStoreItem(
                    "store_item_1",
                    "Present Continuous",
                    "Процесс в настоящем",
                    50,
                    StoreItemType.Sell,
                    "Времена и формы"
                ),
                GetStoreItem(
                    "store_item_2",
                    "Present Perfect",
                    "Результат в настоящем",
                    200,
                    StoreItemType.Sell,
                    "Времена и формы"
                ),
                GetStoreItem(
                    "store_item_3",
                    "Present Perfect Continuous",
                    "Результат и процесс в настоящем",
                    null,
                    StoreItemType.Ads,
                    "Времена и формы"
                ),
                GetStoreItem(
                    "store_item_4",
                    "Past Continuous",
                    "Процесс в прошлом",
                    null,
                    StoreItemType.Normal,
                    "Времена и формы"
                ),
                GetStoreItem(
                    "store_item_5",
                    "Past Simple",
                    "Факт в прошлом",
                    400,
                    StoreItemType.Sell,
                    "Времена и формы"
                ),
                GetStoreItem(
                    "store_item_6",
                    "Future Simple",
                    "Факт в будущем",
                    600,
                    StoreItemType.Sell,
                    "Времена и формы"
                )
               
            };
        }

        private static StoreItem GetStoreItem(
            string icon,
            string name,
            string description,
            int? price,
            StoreItemType type,
            string groupName)
        {
            return new StoreItem {
                Icon = icon,
                Name = name,
                Description = description,
                Price = price,
                Type = type,
                GroupName = groupName
            };
        }

        private List<StoreItemGroup> GroupStoreItems(List<StoreItem> storeItems)
        {
            return storeItems
                    .GroupBy(item => item.GroupName)
                    .Select(group => new StoreItemGroup(group.Key, group.ToList()))
                    .ToList();
        }
    }
}
