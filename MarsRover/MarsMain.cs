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
               .SurUnePlanète(planète => planète.ToriqueDeTailleX(4))
               .Orienté(Orientation.Sud)
               .Positionné(0, 0)
               .Build();
        String commandLine = Console.ReadLine();
        char[] commandsToChars = commandLine.ToCharArray();

        for(int i = 0;i< commandsToChars.Length;i++)
        {
            if (commandsToChars[i].ToString().ToLower().Equals("a"))
            {
                Console.WriteLine("mon orientation est : "+rover.GetOrientation().GetOrientation()+" ma position"+rover.getCoordonnees());
                rover.Traiter(new AvancerCommande());     
                continue;
            }
            if (commandsToChars[i].ToString().ToLower().Equals("g"))
            {
                rover.Traiter(new TourneAGaucheCommande());
                continue;
            }
            if (commandsToChars[i].ToString().ToLower().Equals("d"))
            {
                rover.Traiter(new TournerADroiteCommande());
                Console.WriteLine("mon orientation est : " + rover.GetOrientation().GetOrientation());
                continue;
            }
        }

        
       

    }
   

}