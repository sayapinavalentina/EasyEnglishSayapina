﻿using System;
using System.Collections.Generic;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.Views.TitleViews;
using Xamarin.Forms;

namespace EasyEnglishSayapina.Views
{
    public partial class StoriesView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private View _title;

        public StoriesView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_stories";
        }

        public string GetSelectedIcon()
        {
            return "tab_stories_selected";
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new StoriesTitleView();

            return _title;
        }
    }
}
