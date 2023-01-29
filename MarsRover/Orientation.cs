namespace MarsRover
{
    public class Orientation
    {
        public static Orientation Nord = new();
        public static Orientation Est = new();
        public static Orientation Sud = new();
        public static Orientation Ouest = new();

        private Orientation() {
            this.orientationActuel = Nord;
       
        }

        public Orientation orientationActuel { get; set; } 


        public override string ToString()
        {

            if (orientationActuel.Equals(Nord))
            {
                return "Nord";
            }
            else if (orientationActuel.Equals(Sud))
            {
                return "Sud";
            }
            else if (orientationActuel.Equals(Est))
            {
                return "Est";
            }
           else if (orientationActuel.Equals(Ouest))
            {
                return "Ouest";
            }
            return "";
        }
        public String GetOrientation()
        {
            return this.orientationActuel.ToString();
        }
        public Orientation MouvementDextrogyre
        {
            
            get
            {
               
                if (this.orientationActuel.Equals(Nord))
                {
           
                    orientationActuel = Est;
                    
                    return Est;
                }
                if (this.orientationActuel.Equals(Est))
                {
                    orientationActuel = Sud;
                    return Sud;
                }
                if (this.orientationActuel.Equals(Sud))
                {
                    orientationActuel = Ouest;
                    return Ouest;
                }
                if (this.orientationActuel.Equals(Ouest))
                {
                    orientationActuel = Nord;
                    return Nord;
                }
                throw new NotSupportedException();
            }
        }

        public Orientation MouvementSinistrogyre
        {
            get
            {
                if (this == Nord) return Ouest;
                if (this == Est) return Nord;
                if (this == Sud) return Est;
                if (this == Ouest) return Sud;

                throw new NotSupportedException();
            }
        }
    }
}