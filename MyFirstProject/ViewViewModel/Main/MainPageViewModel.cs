using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls;
using MyFirstProject.ViewViewModel.Image;
using MyFirstProject.ViewViewModel.Layouts;
using MyFirstProject.ViewViewModel.ListView;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Main
{

    public class MainPageViewModel : BaseViewModel
    {
        public ICommand OnControlsMenuClicked { get; set;}

        public ICommand OnLayoutsMenuClicked { get; set; }
        public ICommand OnImageMenuClicked { get; set; }

        public ICommand OnListsViewMenuClicked { get; set; }

        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;
            Subtitle = Titles.MainPageSubtitle;

            OnControlsMenuClicked = new Command(OnControlsMenuClickedAsync);
            OnLayoutsMenuClicked = new Command(OnLayoutsMenuClickedAsync);
            OnImageMenuClicked = new Command(OnImageMenuClickedAsync);
            OnListsViewMenuClicked = new Command(OnListsViewMenuClickedAsync);

        }
        private async void OnControlsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlsMenuView());
        }
        private async void OnLayoutsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutMenuView());
        }
        private async void OnImageMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageMenuView());
        }
        private async void OnListsViewMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewMenuView());
        }

    }
}
