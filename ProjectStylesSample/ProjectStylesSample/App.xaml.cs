﻿using ProjectStyles.Resources;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectStylesSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ProjectStyle.Init(this); // Use default styles
            //ProjectStyle.Init(this, customConfiguration); // Use Custom styles configuration

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
