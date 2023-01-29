namespace MarsRover.Test.Utilities
{
    internal class RoverBuilder
    {
        public Orientation _orientation;
        public Point _positionDépart;
        public IPlanète _planète;

        public RoverBuilder Orienté(Orientation orientation)
        {
            _orientation = orientation;
            return this;
        }

        public RoverBuilder Positionné(ushort x, ushort y)
        {
            _positionDépart = new Point(x, y);
            return this;
        }

        public RoverBuilder SurUnePlanète(Func<PlanèteBuilder, PlanèteBuilder> configuration)
        {
            var planèteBuilder = new PlanèteBuilder();
            _planète = configuration(planèteBuilder).Build();
            return this;
        }

        public Rover Build()
        {
            return new Rover(_planète, _positionDépart, _orientation);
        }
    }
}
