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
        public string atkMaxFou { get; set; }
        public string hpMaxFou { get; set; }
        public bool servantFound { get; set; }

        public Servant(string name, string id, string rarity, string cost, string atkBase, string atkMax, string hpBase, string hpMax)
        {
            try
            {
                this.name = name;
                this.id = id;
                this.rarity = rarity;
                this.cost = cost;
                this.atkBase = atkBase;
                this.atkMax = atkMax;
                this.hpBase = hpBase;
                this.hpMax = hpMax;
                this.atkMaxFou = atkMax + 1000;
                this.hpMaxFou = hpMax + 1000;
                this.servantFound = true;
            }
            catch (Exception)
            {
                this.servantFound = false;
            }
        }

        public Servant(bool errorBool)
        {
            this.servantFound = errorBool;
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Rarity: " + this.rarity + "*");
            Console.WriteLine("Cost: " + this.cost);
            Console.WriteLine("Starting HP: " + this.hpBase);
            Console.WriteLine("Starting Atk: " + this.atkBase);
            Console.WriteLine("Max HP: " + this.hpMax);
            Console.WriteLine("Max Atk: " + this.atkMax);
            Console.WriteLine("Fou HP: " + this.hpMaxFou);
            Console.WriteLine("Fou ATK: " + this.atkMaxFou);
        }
    }
}
