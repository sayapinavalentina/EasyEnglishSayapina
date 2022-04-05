﻿using System;
using EasyEnglishSayapina.ContentViews;
using EasyEnglishSayapina.Enums;
using EasyEnglishSayapina.Models;
using Xamarin.Forms;

namespace EasyEnglishSayapina.Templates
{
    public class StoreItemDataTemplate : DataTemplateSelector
    {
        private readonly DataTemplate _sell;
        private readonly DataTemplate _ads;
        private readonly DataTemplate _normal;

        public StoreItemDataTemplate()
        {
            _sell = new DataTemplate(typeof(StoreItemSellContentView));
            _ads = new DataTemplate(typeof(StoreItemAdsContentView));
            _normal = new DataTemplate(typeof(StoreItemNormalContentView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is StoreItem storeItem)
            {
                if (storeItem.Type == StoreItemType.Sell)
                    return _sell;

                if (storeItem.Type == StoreItemType.Ads)
                    return _ads;

                if (storeItem.Type == StoreItemType.Normal)
                    return _normal;

                return null;
            }

            return null;
        }
    }
}
