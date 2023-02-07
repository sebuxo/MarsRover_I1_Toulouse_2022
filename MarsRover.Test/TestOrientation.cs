using MarsRover.Commandes;
using MarsRover.Test.Utilities;

namespace MarsRover.Test
{
    public class TestOrientation
    {




        [Fact]
        public void TestTourneDroite()
        {
            String origine = "Est";
            // ETANT DONNE un rover orienté vers <origine>
            var rover = new RoverBuilder().Orienté(new Orientation(origine)).Build();

            // QUAND on lui demande de tourner vers la droite
            var orientationFinale = rover.Traiter(new TournerADroiteCommande()).Orientation;

            // ALORS il répond qu'il est désormais orienté <destination>
            Assert.Equal(rover.GetOrientation().MouvementSinistrogyre.GetOrientation(), orientationFinale.GetOrientation());
        }


        [Fact]
        public void TestTourneGauche()
        {
            String origine = "Est";
            // ETANT DONNE un rover orienté vers <origine>
            var rover = new RoverBuilder().Orienté(new Orientation(origine)).Build();

            // QUAND on lui demande de tourner vers la droite
            var orientationFinale = rover.Traiter(new TourneAGaucheCommande()).Orientation;

            // ALORS il répond qu'il est désormais orienté <destination>
            Assert.Equal(rover.GetOrientation().MouvementDextrogyre.GetOrientation(), orientationFinale.GetOrientation());
        }

    }
}