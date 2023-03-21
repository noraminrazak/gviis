using SmartSchoolsV2.Droid.Services;
using SmartSchoolsV2.Views;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrlAndroid))]
namespace SmartSchoolsV2.Droid.Services
{
    public class BaseUrlAndroid : IBaseUrl
    {
        public string Get()
        {
            return "https://payment.ipay88.com.my";
        }
    }
}