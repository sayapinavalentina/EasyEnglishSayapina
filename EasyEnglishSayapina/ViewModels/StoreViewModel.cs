﻿using System;
using System.Linq;
using System.Collections.Generic;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.Models;
using Prism;
using System.Collections.ObjectModel;

namespace EasyEnglishSayapina.ViewModels
{
    public class StoreViewModel : ViewModelBase, IActiveAware
    {
        private readonly IStoreService _storeService;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        public event EventHandler IsActiveChanged;

        public ObservableCollection<StoreItemGroup> Groups { get; private set; }

        public StoreViewModel(IStoreService storeService)
        {
            _storeService = storeService;
            Groups = new ObservableCollection<StoreItemGroup>();
        }

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                if (!Groups.Any())
                {
                    var storeGroups = await _storeService.GetItems();

                    foreach (var group in storeGroups)
                        Groups.Add(group);
                }
            }
        }
    }
}
