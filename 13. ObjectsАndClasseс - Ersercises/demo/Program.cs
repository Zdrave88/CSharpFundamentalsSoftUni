namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character hero1 = new Character("Garrosh", "Horde", "Orc", "Warrior", 60, 5.8, true);
            //hero1.Charge();
            Character hero2 = new Character("Uther", "Alliance", "Human", "Paladin", 70, 9.9, true);
            //hero2.Judgement();
            Character hero3 = new Character("Blue", "Blonde", "Greathammer");
            //hero3.Apperamce();
            Car car1 = new Car("Tuscon", 188, 2016);
            Car car2 = new Car("BMW", "320", "Deutchland", 2.0, 177, 2008);
            //Console.WriteLine($"{car1.Model}, {car1.HorsePower}, {car1.Year}");

            List<string> words = new List<string>{ "koza", "kon", "koala", "rapani", "tigri" };
            string result = words.FirstOrDefault(w => w.Contains("kon"));
            if (result != null)
            {
                Console.WriteLine($"Result is not null\nFound word: {result}");
            }
            else
            {
                Console.WriteLine("Result is null\nThere is no such word");
            }
        }
    }
    public class Character
    {
        string Name { get; set; }
        string Faction { get; set; }
        string Race { get; set; }
        string Class { get; set; }
        int Level { get; set; }
        double Rating { get; set; }
        bool PvP { get; set; }
        string Eyes { get; set; }
        string Hair { get; set; }
        string Weapon { get; set; }

        public Character(string name, string faction, string race, string claass, int level, double rating, bool pvP)
        {
            this.Name = name;
            this.Faction = faction;
            this.Race = race;
            this.Class = claass;
            this.Level = level;
            this.Rating = rating;
            this.PvP = pvP;
        }
        public Character(string eyes, string hair, string weapon)
        {
            this.Eyes = eyes;
            this.Hair = hair;
            this.Weapon = weapon;
        }
        public void Charge()
        {
            Console.WriteLine($"{Name} is charging because he is an {Race}-{Class}");
        }
        public void Judgement()
        {
            Console.WriteLine($"{Name} is casting Judgement because he is an {Race}-{Class} and got: {Rating} arena rating");
        }
        public void Apperamce()
        {
            Console.WriteLine($"The hero got {Eyes} eyes and {Hair} hair. He is wielding a huge {Weapon}");
        }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Country { get; set; }
        public double Engine { get; set; }
        public int HorsePower { get; set; }
        public int Year { get; set; }
        public Car(string brand, string model, string country, double engine, int horsePower, int year)
        {
            Brand = brand;
            Model = model;
            Country = country;
        }
        public Car(string model, int horsePower, int year)
        {
            Model = model;
            HorsePower = horsePower;
            Year = year;
        }
    }
}
