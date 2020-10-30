using System;


namespace ServantInfo.Objects
{
    public class Servant
    {
        public string name { get; set; }
        public string id { get; set; }
        public string rarity { get; set; }
        public string cost { get; set; }
        public string atkBase { get; set; }
        public string atkMax { get; set; }
        public string hpBase { get; set; }
        public string hpMax { get; set; }
        public Servant(string name, string id, string rarity, string cost, string atkBase, string atkMax, string hpBase, string hpMax)
        {
            this.name = name;
            this.id = id;
            this.rarity = rarity;
            this.cost = cost;
            this.atkBase = atkBase;
            this.atkMax = atkMax;
            this.hpBase = hpBase;
            this.hpMax = hpMax;
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Rarity: " + this.rarity + "*");
            Console.WriteLine("Cost: " + this.cost);
            Console.WriteLine("Starting Atk: " + this.atkBase);
            Console.WriteLine("Starting HP: " + this.hpBase);
            Console.WriteLine("Max Atk: " + this.atkMax);
            Console.WriteLine("Max HP: " + this.hpMax);
        }
    }
}
