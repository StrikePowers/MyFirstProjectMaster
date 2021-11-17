using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModel.ListView.ListViewNames
{
    public class ListViewNamesViewModel : BaseViewModel
    {
        public ObservableCollection<Person> Persons { get; }

        private List<Person> _person;

        public ListViewNamesViewModel()
        {
            Title = Titles.ListViewTitle;
            Persons = new ObservableCollection<Person>();
            _person = Person.GetName();
            this.LoadPersons();
        }

        private void LoadPersons()
        {
            try
            {
                Persons.Clear();
                foreach (Person p in _person)
                {
                    Persons.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
    

