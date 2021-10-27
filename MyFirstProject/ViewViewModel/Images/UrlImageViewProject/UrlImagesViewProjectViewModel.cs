using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Images.UrlImageViewProject
{
    public class UrlImagesViewProjectViewModel : BaseViewModel
    {

        public string Image { get; set; }
        public UrlImagesViewProjectViewModel()
        {

            Title = Titles.UrlImagesProjectTitle;
            this.GetImage();

        }

        private void GetImage()
        {
            Image = "https://placeimg.com/640/480/nature";
        }
    }
}
