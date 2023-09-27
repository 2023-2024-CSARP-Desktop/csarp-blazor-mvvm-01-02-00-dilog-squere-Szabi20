using System.ComponentModel;

namespace ViewModels.BaseClass
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }
    }
}
