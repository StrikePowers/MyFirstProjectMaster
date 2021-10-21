using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Images.EmbeddedImagesView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImagesView : ContentPage
    {
        public EmbeddedImagesView()
        {
            InitializeComponent();
            BindingContext = new EmbeddedImagesViewModel();
        }
    }
}