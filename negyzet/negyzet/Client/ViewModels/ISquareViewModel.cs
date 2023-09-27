using ViewModels.BaseClass;

namespace SquareProject.Client.ViewModels
{
    public interface ISquareViewModel : IViewModelBase
    {
        public string Side { get; set; }
        public string Perimeter { get; }
        public string Area { get; }

        public void Compute();
    }
}