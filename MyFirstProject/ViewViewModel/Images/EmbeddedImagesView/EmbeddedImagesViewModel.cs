using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Images.EmbeddedImagesView
{
    class EmbeddedImagesViewModel : BaseViewModel
    {
        public ImageSource EmbeddedImageSrc { get; set; }

        public EmbeddedImagesViewModel()
        {
            Title = Titles.EmbeddedImageTitle;
            this.GetEmbeddedImageSrc();
        }
        
        private void GetEmbeddedImageSrc()
        {
            EmbeddedImageSrc = ImageSource.FromResource("MyFirstProject.Images.Nissan.jpg");
        }
    }
}
