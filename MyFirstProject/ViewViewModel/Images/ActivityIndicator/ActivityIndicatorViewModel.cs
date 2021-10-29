using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Images.ActivityIndicator
{
    public class ActivityIndicatorViewModel : BaseViewModel
    {

        public ImageSource ImageSrc { get; set; }
        public ActivityIndicatorViewModel()
        {
            Title = Titles.ActivityImageTitle;
            ImageSrc = this.SetImgSrc();
        }

        private ImageSource SetImgSrc()
        {
            var imgsrc = new UriImageSource { Uri = new Uri("https://placeimg.com/640/480/people") };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }

    }
}
