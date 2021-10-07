using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayout;
using MyFirstProject.ViewViewModel.Main;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Layouts
{
    public class LayoutMenuViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteClicked { get; set; }

        public LayoutMenuViewModel()
        {
            OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
        }

        private async void OnAbsoluteClickedAsync(object obj)
        { 
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }
    }
}
