using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModel.ListView.ListViewImages
{
    public class ListViewButtonsViewModel : BaseViewModel
    {
        public ObservableCollection<ItemButton> Movies { get; }

        private List<ItemButton> _movies;

        public ListViewButtonsViewModel()
        {
            Title = Titles.ListViewTitle;
            Movies = new ObservableCollection<ItemButton>();
            _movies = ItemButton.GetName();
            this.LoadMovies();

        }
        private void LoadMovies()
        {
            try
            {
                Movies.Clear();
                foreach (ItemButton p in _movies)
                {
                    Movies.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}