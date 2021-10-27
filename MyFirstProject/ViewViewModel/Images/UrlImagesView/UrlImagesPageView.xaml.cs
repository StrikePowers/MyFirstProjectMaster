
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Images.UrlImagesView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrlImagesPageView : ContentPage
    {
        public UrlImagesPageView()
        {
            InitializeComponent();
            BindingContext = new UrlImagesPageViewModel();
        }
    }
}