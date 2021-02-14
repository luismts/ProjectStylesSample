using ProjectStyles.Resources;
using ProjectStyles.Resources.Configuration;
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

            /* Use default styles */
            ProjectStyle.Init(this);

            /* Use XAML styles in App.xaml file */
            //ProjectStyle.Init(this, "Style.Configuration");

            /* Use Custom styles configuration */
            //var customConfiguration = new StyleConfiguration
            //{
            //    ColorConfiguration = new ColorConfiguration
            //    {
            //        // Set properties
            //    },
            //    FontConfiguration = new FontConfiguration
            //    {
            //        // Set properties
            //    }
            //};
            //ProjectStyle.Init(this, customConfiguration); 

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
