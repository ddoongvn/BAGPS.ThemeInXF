using BAGPS.ThemeInXF.ViewModels;
using BAGPS.ThemeInXF.Views;
using Prism;
using Prism.Ioc;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace BAGPS.ThemeInXF
{
    public partial class App
    {
        /*
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor.
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */

        public App() : this(null)
        {
        }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "RadioButton_Experimental", "AppTheme_Experimental" });
            NewMethod();
            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        private void NewMethod()
        {
            RequestedThemeChanged += Current_RequestedThemeChanged;
        }

        protected override  void OnResume()
        {
            base.OnResume();
            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            //OnRequestedThemeChanged(AppThemeChangedEventArgs e);
        }
       
        private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            switch (e.RequestedTheme)
            {
                case OSAppTheme.Unspecified:
                    break;

                case OSAppTheme.Light:
                    break;

                case OSAppTheme.Dark:
                    break;

                default:
                    break;
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}