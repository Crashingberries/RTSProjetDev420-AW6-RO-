public class Archer : Unite
{
    public Archer() : base()
    {

    }

    public Archer(int unPv, int uneArmure, Position unePosition, string unNom, int unCoutOr, int unCoutBois, int uneVitesseDeplacement, int unePuissanceAttaque, int unePorteeMin, int unePorteeMax, int unePuissanceAttaque, int uneVitesseAttaque) : 
        base(unPv, uneArmure, unePosition, unNom, unCoutOr, unCoutBois, uneVitesseDeplacement, unePuissanceAttaque, unePorteeMin, unePorteeMax, unePuissanceAttaque, uneVitesseAttaque)
    {

    }

    public void Attaquer(Construction cible)
    {

    }
}