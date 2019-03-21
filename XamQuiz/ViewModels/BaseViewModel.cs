using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamQuiz.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public ViewModelNavigation Navigation { get; set; }
        protected BaseViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
