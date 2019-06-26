using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace testit
{
    public partial class Content1 : ContentPage
    {
        public Content1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
        }

        public bool NavVisible { get; private set; }
        public bool HasNav { get; private set; }
        public bool TabVisible { get; private set; }

        void OnButtonTapped(object sender, EventArgs args)
        {
            NavVisible = !NavVisible;
            Shell.SetNavBarIsVisible(this, NavVisible);

        }

        void OnNoTabBarTapped(object sender, EventArgs args)
        {
            TabVisible = !TabVisible;
            Shell.SetTabBarIsVisible(this, TabVisible);
        }

        async void OnNoNavBarTapped(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new AfterShellPage());
            await Shell.Current.GoToAsync("Item1/Tab1/Content2");
            
        }

        async void OnMoveWithShellTapped(object sender, EventArgs args)
        {
            //await Shell.Current.GoToAsync("//Item1/Tab1/Content2");
            var shell = Application.Current.MainPage as Shell;
            if (shell != null)
            {
                //await shell.GoToAsync("Item1/Tab1/Content2");
                await shell.GoToAsync("//Content2");
            }
        }
    }
}
