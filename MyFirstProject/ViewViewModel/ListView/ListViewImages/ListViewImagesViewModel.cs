using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModel.ListView.ListViewImages
{
    public class ListViewImagesViewModel : BaseViewModel
    {
        public ObservableCollection<PersonImage> Movies { get; }

        private List<PersonImage> _movies;

        public ListViewImagesViewModel()
        {
            Title = Titles.ListViewTitle;
            Movies = new ObservableCollection<PersonImage>();
            _movies = PersonImage.GetName();
            this.LoadMovies();

        }
        private void LoadMovies()
        {
            try
            {
                Movies.Clear();
                foreach (PersonImage p in _movies)
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
