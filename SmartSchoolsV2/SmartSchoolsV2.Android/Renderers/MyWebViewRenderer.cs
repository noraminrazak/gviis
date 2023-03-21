
using Android.Content;
using SmartSchoolsV2.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WebView), typeof(MyWebViewRenderer))]

namespace SmartSchoolsV2.Droid.Renderers
{
    class MyWebViewRenderer : WebViewRenderer
    {
        public MyWebViewRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.JavaScriptEnabled = true;
            Control.Settings.DomStorageEnabled = true;
            //Control.Settings.AllowFileAccessFromFileURLs = true;
            //Control.Settings.JavaScriptCanOpenWindowsAutomatically = true;
            Control.SetWebViewClient(new MyWebViewClient());
        }
    }
    internal class MyWebViewClient : Android.Webkit.WebViewClient
    {
        public override Android.Webkit.WebResourceResponse ShouldInterceptRequest(Android.Webkit.WebView view, Android.Webkit.IWebResourceRequest request)
        {
            return base.ShouldInterceptRequest(view, request);
        }
        public override bool ShouldOverrideUrlLoading(Android.Webkit.WebView view, Android.Webkit.IWebResourceRequest request)
        {
            return base.ShouldOverrideUrlLoading(view, request);
        }
    }
}