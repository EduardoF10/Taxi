using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using Taxi.Common.Helpers;
using Taxi.Common.Services;
using Taxi.Prism.ViewModels;
using Taxi.Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Taxi.Prism
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MjczNzQ5QDMxMzgyZTMxMmUzMG4waFFCOTJDQTBPKy9YWnZiWGFlQnhZb2FMZVRNWGpQbXA5UllkSWpnQWM9");
            InitializeComponent();

            await NavigationService.NavigateAsync("/TaxiMasterDetailPage/NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IGeolocatorService, GeolocatorService>();
            containerRegistry.Register<IRegexHelper, RegexHelper>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.Register<IFilesHelper, FilesHelper>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<TaxiMasterDetailPage, TaxiMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<TaxiHistoryPage, TaxiHistoryPageViewModel>();
            containerRegistry.RegisterForNavigation<GroupPage, GroupPageViewModel>();
            containerRegistry.RegisterForNavigation<ModifyUserPage, ModifyUserPageViewModel>();
            containerRegistry.RegisterForNavigation<ReportPage, ReportPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<TripDetailPage, TripDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<RememberPasswordPage, RememberPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<ChangePasswordPage, ChangePasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<StartTripPage, StartTripPageViewModel>();
            containerRegistry.RegisterForNavigation<EndTripPage, EndTripPageViewModel>();
            containerRegistry.RegisterForNavigation<MyTripsPage, MyTripsPageViewModel>();
            containerRegistry.RegisterForNavigation<MyTripPage, MyTripPageViewModel>();
        }
    }
}
