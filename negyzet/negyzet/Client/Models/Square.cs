namespace SquareProject.Models
{
    public class Square
    {
        private double _side;
        public double Side
        {
            get => _side;
            set
            {
                if (value <= 0)
                    throw new SqueraSideCannotBeNagativOrZero(value + " méretre a négyzet oldalát nem lehet változtatni. A négyzet oldala maradt " + _side + ".");
                else
                    _side = value;
            }
        }

        public Square(double side)
        {
            if (side <= 0)
                throw new SqueraSideCannotBeNagativOrZero(side + " oldalú négyzet nincs. A négyzetet nem jön létre.");
            else
                _side = side;


        }

        public double Perimeter
        {
            get => 4 * _side;
        }

        public double Area
        {
            get => _side * _side;
        }

        public override string ToString()
        {
            return $"{Side} méter a négyzet oldala.\nKerülete {Area}.\nTerülete {Area}.";
        }

    }
}
