using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Images.UrlImageViewProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrlImagesViewProjectView : ContentPage
    {
        public UrlImagesViewProjectView()
        {
            InitializeComponent();
            BindingContext = new UrlImagesViewProjectViewModel();
        }
    }
}