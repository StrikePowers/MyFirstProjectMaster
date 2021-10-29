using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Images.EmbeddedImagesView;
using MyFirstProject.ViewViewModel.Images.EmbeddedImagesViewProject;
using MyFirstProject.ViewViewModels;
using System.Windows.Input;
using Xamarin.Forms;
using MyFirstProject.ViewViewModel.Images.UrlImagesView;
using MyFirstProject.ViewViewModel.Images.UrlImageViewProject;
using MyFirstProject.ViewViewModel.Images.ImageCachingView;
using MyFirstProject.ViewViewModel.Images.ActivityIndicator;

namespace MyFirstProject.ViewViewModel.Image
{

    public class ImagesMenuViewModel : BaseViewModel
        {
            public ICommand OnEmbeddedImagesClicked { get; set; }
            public ICommand OnEmbeddedImagesProjectClicked { get; set; }
            public ICommand OnUrlImagesClicked { get; set; }
            public ICommand OnUrlImagesProjectClicked { get; set; }
            public ICommand OnImageCachingClicked { get; set; }
            public ICommand OnActivityImageClicked { get; set; }

        public ImagesMenuViewModel()
            {
                Title = Titles.ImageTitle;

                OnEmbeddedImagesClicked = new Command(OnEmbeddedImagesClickedAsync);
                OnEmbeddedImagesProjectClicked = new Command(OnEmbeddedImagesProjectClickedAsync);
                OnUrlImagesClicked = new Command(OnOnUrlImagesClickedAsync);
                OnUrlImagesProjectClicked = new Command(OnOnUrlImagesProjectClickedAsync);
                OnImageCachingClicked = new Command(OnImageCachingClickedAsync);
                OnActivityImageClicked = new Command(OnActivityImageClickedAsync);

        }
            private async void OnEmbeddedImagesClickedAsync(object obj)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesView());
            }

            private async void OnEmbeddedImagesProjectClickedAsync(object obj)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesViewProject());
            }

            private async void OnOnUrlImagesClickedAsync(object obj)
            {
              await Application.Current.MainPage.Navigation.PushAsync(new UrlImagesPageView());
            }
            
            private async void OnOnUrlImagesProjectClickedAsync(object obj)
            {
               await Application.Current.MainPage.Navigation.PushAsync(new UrlImagesViewProjectView());
            }
            private async void OnImageCachingClickedAsync(object obj)
            {
               await Application.Current.MainPage.Navigation.PushAsync(new ImageCachingView());
            }

            private async void OnActivityImageClickedAsync(object obj)
            {
              await Application.Current.MainPage.Navigation.PushAsync(new ActivityIndicatorView());
            }


    }

}
