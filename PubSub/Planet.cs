namespace PubSub
{
    public class Planet
    {
        public string Name { get; set; }

        public Radar Radar { get; set; }

        public Planet(string name)
        {
            Name = name;
            Radar = new Radar();
        }
    }
}
