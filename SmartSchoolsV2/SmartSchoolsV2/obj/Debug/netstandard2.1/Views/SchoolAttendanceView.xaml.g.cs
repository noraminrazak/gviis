//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("SmartSchoolsV2.Views.SchoolAttendanceView.xaml", "Views/SchoolAttendanceView.xaml", typeof(global::SmartSchoolsV2.Views.SchoolAttendanceView))]

namespace SmartSchoolsV2.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\SchoolAttendanceView.xaml")]
    public partial class SchoolAttendanceView : global::Xamarin.Forms.ContentView {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SmartSchoolsV2.Customs.CustomEntry txtShift;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamForms.Controls.Calendar calendar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout btnStack;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Image btnDownload;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SmartSchoolsV2.SnackBar SnackB;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(SchoolAttendanceView));
            txtShift = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SmartSchoolsV2.Customs.CustomEntry>(this, "txtShift");
            calendar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamForms.Controls.Calendar>(this, "calendar");
            btnStack = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "btnStack");
            btnDownload = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Image>(this, "btnDownload");
            SnackB = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SmartSchoolsV2.SnackBar>(this, "SnackB");
        }
    }
}