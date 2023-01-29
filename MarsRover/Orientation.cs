using System.Runtime.CompilerServices;

namespace MarsRover
{
    public class Orientation
    {
        public String orientationActuel { get; set; } 

        public Orientation() {
            this.orientationActuel = "Nord";
       
        }
        
        public String GetOrientation()
        {
            return this.orientationActuel;
        }
        public Orientation MouvementDextrogyre
        {
            
            get
            {
               
                if (this.orientationActuel.Equals("Nord"))
                {
           
                    orientationActuel = "Est";

                    return this;
                }
                if (this.orientationActuel.Equals("Est"))
                {
                    orientationActuel = "Sud";
                    return this;
                }
                if (this.orientationActuel.Equals("Sud"))
                {
                    orientationActuel = "Ouest";
                    return this;
                }
                if (this.orientationActuel.Equals("Ouest"))
                {
                    orientationActuel = "Nord";
                    return this;
                }
                throw new NotSupportedException();
            }
        }

        public Orientation MouvementSinistrogyre
        {
            get
            {/*
                if (this == Nord) return Ouest;
                if (this == Est) return Nord;
                if (this == Sud) return Est;
                if (this == Ouest) return Sud;

                throw new NotSupportedException();*/
                return this;

            }
        }
    }
}