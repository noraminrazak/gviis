//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("SmartSchoolsV2.Views.StaffCardReplacementPage.xaml", "Views/StaffCardReplacementPage.xaml", typeof(global::SmartSchoolsV2.Views.StaffCardReplacementPage))]

namespace SmartSchoolsV2.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\StaffCardReplacementPage.xaml")]
    public partial class StaffCardReplacementPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Grid searchBar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SmartSchoolsV2.Customs.CustomEntry txtSearchStudent;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Grid gridProfile;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::ImageCircle.Forms.Plugin.Abstractions.CircleImage userImage;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout userInitial;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label lblFullName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label lblSchoolName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Image dotImage;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label lblClassName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Frame btnRemove;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout cardDetail;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SmartSchoolsV2.Customs.CustomEntry txtCardNumber;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Plugin.InputKit.Shared.Controls.RadioButton radio1;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Plugin.InputKit.Shared.Controls.RadioButton radio2;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Plugin.InputKit.Shared.Controls.RadioButton radio3;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SmartSchoolsV2.Customs.CustomEntry txtNewCardNumber;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SmartSchoolsV2.Behaviors.CardNumberMaskBehavior NewCardNumberMask;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button btnReplace;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SmartSchoolsV2.SnackBar SnackB;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(StaffCardReplacementPage));
            searchBar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Grid>(this, "searchBar");
            txtSearchStudent = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SmartSchoolsV2.Customs.CustomEntry>(this, "txtSearchStudent");
            gridProfile = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Grid>(this, "gridProfile");
            userImage = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::ImageCircle.Forms.Plugin.Abstractions.CircleImage>(this, "userImage");
            userInitial = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "userInitial");
            lblFullName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "lblFullName");
            lblSchoolName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "lblSchoolName");
            dotImage = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Image>(this, "dotImage");
            lblClassName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "lblClassName");
            btnRemove = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Frame>(this, "btnRemove");
            cardDetail = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "cardDetail");
            txtCardNumber = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SmartSchoolsV2.Customs.CustomEntry>(this, "txtCardNumber");
            radio1 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Plugin.InputKit.Shared.Controls.RadioButton>(this, "radio1");
            radio2 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Plugin.InputKit.Shared.Controls.RadioButton>(this, "radio2");
            radio3 = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Plugin.InputKit.Shared.Controls.RadioButton>(this, "radio3");
            txtNewCardNumber = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SmartSchoolsV2.Customs.CustomEntry>(this, "txtNewCardNumber");
            NewCardNumberMask = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SmartSchoolsV2.Behaviors.CardNumberMaskBehavior>(this, "NewCardNumberMask");
            btnReplace = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "btnReplace");
            SnackB = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SmartSchoolsV2.SnackBar>(this, "SnackB");
        }
    }
}
