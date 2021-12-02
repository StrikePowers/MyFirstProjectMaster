using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.ListView.ListViewButtons;
using MyFirstProject.ViewViewModel.ListView.ListViewImages;
using MyFirstProject.ViewViewModel.ListView.ListViewNames;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView
{
    public class ListViewMenuViewModel : BaseViewModel
    {
        public ICommand OnListNamesClicked { get; set; }
        public ICommand OnListImagesClicked { get; set; }
        public ICommand OnListButtonsClicked { get; set; }
        public ListViewMenuViewModel()
        {
            Title = Titles.ListViewTitle;
            OnListNamesClicked = new Command(OnListNamesClickedAsync);
            OnListImagesClicked = new Command(OnListImagesClickedAsync);
            OnListButtonsClicked = new Command(OnListButtonsClickedAsync);
        }

        private async void OnListNamesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewNamesView());
        }

        private async void OnListImagesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewImagesView());
        }
        private async void OnListButtonsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewButtonsView());
        }

    }
}
