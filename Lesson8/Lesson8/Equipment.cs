namespace Lesson8
{
    struct Equipment
    {
        public string Sword { get; set; }
        public string Shield { get; set; }
        public string Armor { get; set; }

        public Equipment(string Sword, string Shield, string Armor)
        {
            this.Sword = Sword;
            this.Shield = Shield;
            this.Armor = Armor;
        }
    }
}
