using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace testit
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            Debug.WriteLine("---------------------------------------------------------------------------------------");
            var state = Shell.Current?.CurrentState;
            var app = Application.Current?.MainPage;
            Debug.WriteLine(state);
            var sendee = sender;
            Debug.WriteLine("---------------------------------------------------------------------------------------");
            
        }

    }
}
