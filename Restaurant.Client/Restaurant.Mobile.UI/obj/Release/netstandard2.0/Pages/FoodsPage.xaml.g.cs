//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Restaurant.Mobile.UI.Pages.FoodsPage.xaml", "Pages/FoodsPage.xaml", typeof(global::Restaurant.Mobile.UI.Pages.FoodsPage))]

namespace Restaurant.Mobile.UI.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\FoodsPage.xaml")]
    public partial class FoodsPage : global::Restaurant.Mobile.UI.Pages.FoodsXamlPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Restaurant.Mobile.UI.Views.FoodsListView FoodsList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(FoodsPage));
            FoodsList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Restaurant.Mobile.UI.Views.FoodsListView>(this, "FoodsList");
        }
    }
}