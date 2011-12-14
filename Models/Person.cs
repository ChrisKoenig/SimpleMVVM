using System;
using System.ComponentModel;

namespace PhoneApp85.Models
{
    public class Person : INotifyPropertyChanged
    {
        // Fields...
        private string _FavoriteColor;
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string FavoriteColor
        {
            get { return _FavoriteColor; }
            set
            {
                if (_FavoriteColor == value)
                    return;
                _FavoriteColor = value;
                RaisePropertyChanged("FavoriteColor");
            }
        }

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}