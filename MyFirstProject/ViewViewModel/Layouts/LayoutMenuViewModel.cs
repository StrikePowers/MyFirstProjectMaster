using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayout;
using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayoutProject;
using MyFirstProject.ViewViewModel.Layouts.RelativeLayout;
using MyFirstProject.ViewViewModel.Layouts.RelativeLayoutProject;
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

        public ICommand OnRelativeClicked { get; set; }

        public ICommand OnAbsoluteProjectClicked { get; set; }

        public ICommand OnRelativeProjectClicked { get; set; }

        public LayoutMenuViewModel()
        {
            OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
            OnRelativeClicked = new Command(OnRelativeClickedAsync);
            OnAbsoluteProjectClicked = new Command(OnAbsoluteProjectClickedAsync);
            OnRelativeProjectClicked = new Command(OnRelativeProjectClickedAsync);
        }

        private async void OnRelativeClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutView());
        }

        private async void OnAbsoluteClickedAsync(object obj)
        { 
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }

        private async void OnAbsoluteProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutProjectView());
        }
        private async void OnRelativeProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutProjectView());
        }
    }
}
