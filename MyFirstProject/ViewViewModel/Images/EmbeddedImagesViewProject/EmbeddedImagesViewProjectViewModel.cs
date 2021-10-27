using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Images.EmbeddedImagesViewProject
{
    public class EmbeddedImagesViewProjectViewModel : BaseViewModel
    {

        public ImageSource EmbeddedImage { get; set; }
        public  EmbeddedImagesViewProjectViewModel()
        {
           Title = Titles.EmbeddedImagesProjectTitle;
           EmbeddedImage = LocalImages.EmbeddedImagesProjectImageSrc;
        }
    }
}
