﻿using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Images.EmbeddedImagesView;
using MyFirstProject.ViewViewModel.Images.EmbeddedImagesViewProject;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image
{

        public class ImagesMenuViewModel : BaseViewModel
        {
            public ICommand OnEmbeddedImagesClicked { get; set; }
            public ICommand OnEmbeddedImagesProjectClicked { get; set; }


        public ImagesMenuViewModel()
            {
                Title = Titles.ImageTitle;

                OnEmbeddedImagesClicked = new Command(OnEmbeddedImagesClickedAsync);
                OnEmbeddedImagesProjectClicked = new Command(OnEmbeddedImagesProjectClickedAsync);

        }
            private async void OnEmbeddedImagesClickedAsync(object obj)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesView());
            }

            private async void OnEmbeddedImagesProjectClickedAsync(object obj)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesViewProject());
            }

    }
    
}
