using System;
using System.Collections.Generic;
using EasyEnglishSayapina.Interfaces;
using Xamarin.Forms;

namespace EasyEnglishSayapina.Views
{
    public partial class TrainingView : ContentPage, ITabPageIcons
    {
        public TrainingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_training";
        }

        public string GetSelectedIcon()
        {
            return "tab_training_selected";
        }
    }
}
