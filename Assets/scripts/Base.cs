namespace RTS
{
    public class Base : Batiment
    {
        public Base() : base()
        {

        }

        public Base(int unPV, int uneArmure, Position unePosition, string unNom, int unCoutOr, int unCoutBois, int unTempsConstruction) :
            base(unPV, uneArmure, unePosition, unNom, unCoutOr, unCoutBois, unTempsConstruction)
        {

        }

        public void CreerOuvrier()
        {

        }
    }
}