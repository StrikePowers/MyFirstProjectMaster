using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Images.ImageCachingView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCachingView : ContentPage
    {
        public ImageCachingView()
        {
            InitializeComponent();
            BindingContext = new ImageCachingViewModel();
        }
    }
}