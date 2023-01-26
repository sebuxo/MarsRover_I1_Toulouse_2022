using MarsRover;
using MarsRover.Commandes;
using MarsRover.Test.Utilities;
using System.Xml.Serialization;
using System.Collections;
class MarsMain
{
    static void Main(string[] args)
    {


        Rover rover = new RoverBuilder()
               .SurUnePlanète(planète => planète.ToriqueDeTailleX(4))
               .Orienté(Orientation.Nord)
               .Positionné(0, 0)
               .Build();
        String commandLine = Console.ReadLine();
        char[] commandsToChars = commandLine.ToCharArray();

        for(int i = 0;i< commandsToChars.Length;i++)
        {
            if (commandsToChars[i].ToString().ToLower().Equals("a"))
            {
                
                Console.WriteLine("ma position est : " + rover.Traiter(new AvancerCommande()).Position);
                continue;
            }
            if (commandsToChars[i].ToString().ToLower().Equals("g"))
            {
                
                Console.WriteLine("ma position est : " + rover.Traiter(new TourneAGaucheCommande()).Position);
                continue;
            }
            if (commandsToChars[i].ToString().ToLower().Equals("d"))
            {
                Console.WriteLine("ma position est : " + rover.Traiter(new TournerADroiteCommande()).Position);
                continue;
            }
        }

        
       

    }
   

}