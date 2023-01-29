namespace MarsRover.Commandes
{
    public class TournerADroiteCommande : IRoverCommande
    {
        /// <inheritdoc />
        public (Orientation Orientation, Point Position, Point? ObstacleEventuel) Traiter(Orientation orientation, Point position, IPlanète _planète)
        {

            orientation = orientation.MouvementDextrogyre;

            return (orientation, position, default);
        }
    }
}
