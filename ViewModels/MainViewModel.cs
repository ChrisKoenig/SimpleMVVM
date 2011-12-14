using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PhoneApp85.Models;

namespace PhoneApp85.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // Fields...
        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                RaisePropertyChanged("People");
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (!DesignerProperties.IsInDesignTool)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            People = new ObservableCollection<Person>()
            {
                new Person() { Name = "Dave Bost", FavoriteColor = "Purple" },
                new Person() { Name = "Chris Koenig", FavoriteColor = "Orange" },
                new Person() { Name = "Laura Koenig", FavoriteColor = "Yellow" },
                new Person() { Name = "David Koenig", FavoriteColor = "Green" },
                new Person() { Name = "Stephen Koenig", FavoriteColor = "Red" },
                new Person() { Name = "Christine Koenig", FavoriteColor = "Purple" },
                new Person() { Name = "Brian Koenig", FavoriteColor = "Blue" },
            };
        }

        #region INPC

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion INPC
    }
}