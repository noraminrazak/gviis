using Newtonsoft.Json;
using Rg.Plugins.Popup.Extensions;
using SmartSchoolsV2.Class;
using SmartSchoolsV2.Models;
using SmartSchoolsV2.Services;
using SmartSchoolsV2.Popup;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartSchoolsV2.Resources;
using Plugin.HybridWebView.Shared.Delegates;
using SmartSchoolsV2.Customs;
using Xamarin.Essentials;
using System.Net;

namespace SmartSchoolsV2.Views
{
    public interface IBaseUrl { string Get(); }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        //public static string CurrentUrl { get; set; }
        Connection conn = new Connection();
        ServiceWrapper srvc = new ServiceWrapper();
        public string requestUrl = Settings.requestUrl;
        private decimal _topup_amount;
        string _current_url;
        bool isLoading = false;
        public string current_url
        {
            get
            {
                return _current_url;
            }
            set
            {
                if (_current_url != value)
                {
                    _current_url = value;
                    OnPropertyChanged("current_url");
                }
            }
        }
        public PaymentPage(decimal topup_amount)
        {
            InitializeComponent();
            BindingContext = this;
            _topup_amount = topup_amount;

        }

        private void OnLoadFinished(object sender, EventArgs args) 
        {
            System.Diagnostics.Debug.WriteLine(string.Format("Load Complete: {0}", args));
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await activity_indicator.ProgressTo(0.9, 900, Easing.SpringIn);

            WalletTopup();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            GC.Collect();
        }

        public async void WalletTopup() 
        {
            if (conn.IsConnected() == true)
            {
                try
                {
                    ShowLoadingPopup();

                    var t = srvc.PostPaymentRequest(Settings.devicePlatform, Settings.userName, Settings.walletId, Settings.walletNumber, _topup_amount, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), Settings.fullName);
                    string jsonStr = await t;
                    CrudProperty response = JsonConvert.DeserializeObject<CrudProperty>(jsonStr);
                    if (response.Success == true)
                    {
                        var htmlSource = new HtmlWebViewSource()
                        {
                            Html = response.Message,
                            BaseUrl = DependencyService.Get<IBaseUrl>().Get()
                        };

                        WebContent.Source = htmlSource;

                        Settings.topupRefId = response.Code;
                    }
                    else
                    {
                        await DisplayAlert(AppResources.SorryText, response.Message, "OK");
                        await Navigation.PopAsync();
                    }
                }
                catch (Exception)
                {
                    SnackB.Message = AppResources.SomethingWrongText;
                    SnackB.IsOpen = !SnackB.IsOpen;
                }
                finally
                {
                    HideLoadingPopup();
                }
            }
            else
            {
                SnackB.Message = AppResources.CheckInternetText;
                SnackB.IsOpen = !SnackB.IsOpen;
            }
        }

        public async Task GetTopupStatus()
        {
            if (conn.IsConnected() == true)
            {
                try
                {
                    //ShowLoadingPopup();

                    var t = srvc.PostAccountTopupStatus(Settings.userName, Settings.topupRefId, Settings.fullName);
                    string jsonStr = await t;
                    CrudProperty response = JsonConvert.DeserializeObject<CrudProperty>(jsonStr);
                    if (response.Success == true)
                    {
                        Settings.topupRefId = string.Empty;
                    }
                    else
                    {
                        await DisplayAlert(AppResources.SorryText, response.Message, "OK");
                        await Navigation.PopAsync();
                    }
                }
                catch (Exception)
                {
                    SnackB.Message = AppResources.SomethingWrongText;
                    SnackB.IsOpen = !SnackB.IsOpen;
                }
                finally
                {
                    //HideLoadingPopup();
                }
            }
            else
            {
                SnackB.Message = AppResources.CheckInternetText;
                SnackB.IsOpen = !SnackB.IsOpen;
            }
        }

        public void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            activity_indicator.IsVisible = true;
            //lblUrl.Text = e.Url.ToString();
        }

        public void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            activity_indicator.IsVisible = false;
            //lblUrl.Text = e.Url.ToString();
        }

        //private void FormsWebView_OnNavigationStarted(object sender, DecisionHandlerDelegate e)
        //{
        //    //activity_indicator.IsVisible = true;
        //    //lblUrl.Text = WebContent.CurrentUrl;
        //    System.Diagnostics.Debug.WriteLine("Navigation has started");

        //}

        //private void FormsWebView_OnNavigationCompleted(object sender, System.EventArgs e)
        //{
        //    //activity_indicator.IsVisible = false;
        //    //lblUrl.Text = WebContent.CurrentUrl;
        //    System.Diagnostics.Debug.WriteLine("Navigation has completed");
        //    var obj = sender as WebView;
        //    Device.BeginInvokeOnMainThread(async () =>
        //    {
        //        //lblUrl.Text = e.ToString();
        //        if (e.ToString().Contains("action=indirect"))
        //        {
        //            await GetTopupStatus();
        //        }
        //    });
        //}

        //private void FormsWebView_OnContentLoaded(object sender, System.EventArgs e)
        //{
        //    //lblUrl.Text = WebContent.CurrentUrl;
        //    System.Diagnostics.Debug.WriteLine("Content has loaded");
        //}

        //private void FormsWebView_OnNavigationError(object sender, int e)
        //{
        //    System.Diagnostics.Debug.WriteLine($"An error was thrown with code: {e}");
        //}

        LoadingPopupPage loadingPage = new LoadingPopupPage();
        async void ShowLoadingPopup()
        {
            await Navigation.PushPopupAsync(loadingPage);
        }
        async void HideLoadingPopup()
        {
            await Task.Delay(500);
            await Navigation.RemovePopupPageAsync(loadingPage);
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}