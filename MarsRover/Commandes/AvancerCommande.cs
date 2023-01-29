namespace MarsRover.Commandes
{
    public class AvancerCommande : IRoverCommande
    {
        /// <inheritdoc />
        public (Orientation Orientation, Point Position, Point? ObstacleEventuel) Traiter(
            Orientation orientation, Point positionInitiale, IPlanète planète)
        {
            var positionFinale = positionInitiale + new Point(0, 0);

            if (orientation.GetOrientation().Equals("Nord"))
            {
                positionFinale = positionInitiale + new Point(0, 1);
                
            }
            else if (orientation.GetOrientation().Equals("Est"))
            {
                positionFinale = positionInitiale + new Point(1, 0);
               
            }
            else if (orientation.GetOrientation().Equals("Sud"))
            {
                positionFinale = positionInitiale - new Point(0, 1);

            }
            else if (orientation.GetOrientation().Equals("Ouest"))
            {
                positionFinale = positionInitiale - new Point(1, 0);

            }
            positionFinale = planète.Canoniser(positionFinale);


            if (planète.PossèdeUnObstacle(positionFinale))
            {
                Console.WriteLine("l'obstacle est dans les coordoonée : "+positionFinale);
                return (orientation, positionInitiale, positionFinale);
            }
            else
            {

             
                return (orientation, positionFinale, default);
                
            }
        }
    }
}
