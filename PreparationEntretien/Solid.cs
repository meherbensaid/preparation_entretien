namespace PreparationEntretien
{
    public class Rectangle
    {
        protected int Longeur => _longeur;
        public int Largeur => _largeur;

        protected int _longeur;
        private readonly int _largeur;
        public Rectangle(int largeur, int longeur)
        {
            _largeur = largeur;
            _longeur = longeur;
        }

        public int CalculSurface()
        {
            return _longeur * _largeur;
        }
    }
    public class Carre : Rectangle
    {
        public Carre(int longeur) : base(longeur, longeur)
        {
            _longeur = longeur;
        }
    }
}
