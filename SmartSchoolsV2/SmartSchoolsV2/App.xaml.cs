using Prism;
using Prism.Ioc;
using SmartSchoolsV2.Class;
using SmartSchoolsV2.Services;
using System;
using System.Globalization;
using System.Threading;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("font-awesome-5-free-solid.otf", Alias = "FontAwesomeSolid")]
[assembly: ExportFont("font-awesome-5-free-regular.otf", Alias = "FontAwesomeRegular")]
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SmartSchoolsV2
{
    public partial class App
    {
        public string requestUrl = Settings.requestUrl;
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            if (uri.Host.EndsWith("myedutech.my", StringComparison.OrdinalIgnoreCase))
            {

                if (uri.Segments != null && uri.Segments.Length == 3)
                {
                    var action = uri.Segments[1].Replace("/", "");
                    var msg = uri.Segments[2];

                    switch (action)
                    {
                        case "hello":
                            if (!string.IsNullOrEmpty(msg))
                            {
                                //Device.BeginInvokeOnMainThread(async () =>
                                //{
                                //    await Current.MainPage.DisplayAlert("hello", msg.Replace("&", " "), "ok");
                                //});
                                Xamarin.Forms.Device.OpenUri(uri);
                            }

                            break;

                        default:
                            Xamarin.Forms.Device.OpenUri(uri);
                            break;
                    }
                }
            }
        }

        public static bool IsActive = true;
        public App() : this(null) {

        }

        public App(IPlatformInitializer initializer) : base(initializer) { }


        protected override void OnInitialized()
        {
            if (Settings.cultureInfo == "en-US") 
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }
            else if (Settings.cultureInfo == "ms-MY") 
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ms-MY");
            }
            else 
            {
                Settings.cultureInfo = "en-US";
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InstalledUICulture;
            }

            InitializeComponent();

            DependencyService.Register<ChatService>();

            //Device.SetFlags(new[] {  });
            Device.SetFlags(new string[] { "CollectionView_Experimental", "SwipeView_Experimental" ,"Expander_Experimental" });
            Settings.requestUrl = "http://giis.myedutech.my";
            //Settings.requestUrl = "http://localhost/GviisAPIv2";
            Settings.androidPackageName = "com.emerging.virtualgiis";
            Settings.iOSApplicationId = "id284882215";
            //Settings.uwpProductId = "9wzdncrf0083";
            Settings.currentVersion = VersionTracking.CurrentVersion;
            Settings.currentBuild = VersionTracking.CurrentBuild;
            Settings.devicePlatform = DeviceInfo.Platform.ToString();

            var splashPage = new NavigationPage(new SplashPage());
            MainPage = splashPage;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<SplashPage>();
            //containerRegistry.RegisterForNavigation<LoginPage1>();
            //containerRegistry.RegisterForNavigation<LoginPage2>();
            //containerRegistry.RegisterForNavigation<MainPage>();
            //containerRegistry.RegisterForNavigation<StaffPage1>();
            //containerRegistry.RegisterForNavigation<StaffPage2>();
            //containerRegistry.RegisterForNavigation<StaffPage3>();
            //containerRegistry.RegisterForNavigation<StaffPage4>();
            //containerRegistry.RegisterForNavigation<StaffPage5>();
            //containerRegistry.RegisterForNavigation<MerchantPage>();
        }

        //private SmartSchoolsV2.MainPage mPage;
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            App.IsActive = false;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            App.IsActive = true;
        }
    }
}
