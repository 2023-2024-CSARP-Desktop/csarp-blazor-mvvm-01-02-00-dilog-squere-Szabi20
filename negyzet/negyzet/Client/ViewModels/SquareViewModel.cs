using SquareProject.Client.ViewModels;
using SquareProject.Models;
using ViewModels.BaseClass;

namespace SquareProject.ViewModels
{
    public class SquareViewModel : ViewModelBase,ISquareViewModel
    {
        private Square _square;

        public SquareViewModel()
        {
            _square = new Square(1);
        }


        public string Side
        {
            get
            {
                return _square.Side.ToString();
            }
            set
            {
                try
                {
                    _square.Side = Convert.ToDouble(value);
                }
                catch (Exception e)
                {
                }
            }
        }

        public string Perimeter
        {
            get
            {
                double roundedPerimeter = Math.Round(_square.Perimeter, 2);
                return "A négyzet kerülete: " + roundedPerimeter.ToString() + " méter.";
            }
        }

        public string Area
        {
            get
            {
                double roundedArea = Math.Round(_square.Area, 2);
                return "A négyzet területe: " + roundedArea.ToString() + " négyzetméter.";
            }
        }

        public void Compute()
        {
            OnPropertyChanged(nameof(Perimeter));
            OnPropertyChanged(nameof(Area));
        }
    }
}
