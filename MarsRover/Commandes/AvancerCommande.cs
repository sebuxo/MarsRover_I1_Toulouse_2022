namespace MarsRover.Commandes
{
    public class AvancerCommande : IRoverCommande
    {
        /// <inheritdoc />
        public (Orientation Orientation, Point Position, Point? ObstacleEventuel) Traiter(
            Orientation orientation, Point positionInitiale, IPlanète planète)
        {
            var positionFinale = positionInitiale + new Point(0, 1);
            positionFinale = planète.Canoniser(positionFinale);

            if (planète.PossèdeUnObstacle(positionFinale))
            {
              
                return (orientation, positionInitiale, positionFinale);
            }
            else
            {

               // Console.WriteLine("My position" + positionFinale);
               // Console.WriteLine("my orientation =" + orientation.GetOrientation());
                return (orientation, positionFinale, default);
                
            }
        }
    }
}
