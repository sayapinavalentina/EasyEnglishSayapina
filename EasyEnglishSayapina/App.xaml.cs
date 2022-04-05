﻿using System;
using EasyEnglishSayapina.Fakes;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.ViewModels;
using EasyEnglishSayapina.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyEnglishSayapina
{
    public partial class App : PrismApplication
    {
        public App() : base(null) { }
        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var mainPage = $"{nameof(NavigationPage)}/{nameof(MainPage)}";
            await NavigationService.NavigateAsync(mainPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LessonsView, LessonsViewModel>();
            containerRegistry.RegisterForNavigation<StoriesView, StoriesViewModel>();
            containerRegistry.RegisterForNavigation<TrainingView, TrainingViewModel>();
            containerRegistry.RegisterForNavigation<ProfileView, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<RankingView, RankingViewModel>();
            containerRegistry.RegisterForNavigation<StoreView, StoreViewModel>();

            containerRegistry.Register<ILessonService, LessonServiceFake>();
            containerRegistry.Register<IStoriesService, StoriesServiceFake>();
            containerRegistry.Register<IAchievementsService, AchievementsServiceFake>();
            containerRegistry.Register<IFriendsService, FriendsServiceFake>();
            containerRegistry.Register<IStoreService, StoreServiceFake>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
