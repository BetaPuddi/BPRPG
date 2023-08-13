namespace BPRPG
{
    public abstract class Location
    {
        public string Name { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public int ZoneLevel { get; set; }

        //public abstract void StartCombat();
        public abstract void EnterZone();
    }
}