﻿using MarsRover;
using MarsRover.Commandes;
using MarsRover.Test.Utilities;
using System.Xml.Serialization;
using System.Collections;
class MarsMain
{
    static void Main(string[] args)
    {


        Rover rover = new RoverBuilder()
               .SurUnePlanète(planète => planète.ToriqueDeTailleX(4).AyantUnObstacle(1,1))
               .Orienté(new Orientation())
               .Positionné(0, 0)
               .Build();
        int stop = 0;
        String commandLine ="";

        do
        {
            Console.WriteLine("Veuillez saisir la liste de commandes que vous voulez faire : (A : avancer , D : tourner droite , G : tourner gauche , Q : Quitter");
                 commandLine = Console.ReadLine();
            char[] commandsToChars = commandLine.ToCharArray();

            for (int i = 0; i < commandsToChars.Length; i++)
            {
                if (commandsToChars[i].ToString().ToLower().Equals("a"))
                {
                    Console.WriteLine("j'avance vers : " + rover.GetOrientation().GetOrientation());
                    rover.Traiter(new AvancerCommande());
                    Console.WriteLine("ma position " + rover.getCoordonnees());
                    continue;
                }
                if (commandsToChars[i].ToString().ToLower().Equals("g"))
                {
                    rover.Traiter(new TourneAGaucheCommande());
                    Console.WriteLine("je tourne vers  : " + rover.GetOrientation().GetOrientation());
                    continue;
                }
                if (commandsToChars[i].ToString().ToLower().Equals("d"))
                {
                    rover.Traiter(new TournerADroiteCommande());
                    Console.WriteLine("je tourne vers  : " + rover.GetOrientation().GetOrientation());
                    continue;
                }
                if (commandsToChars[i].ToString().ToLower().Equals("q"))
                {
                    Console.WriteLine("Le program va s'eteindre");
                    stop = 1;
                }
            }
        } while (stop != 1);
        
       

    }
   

}