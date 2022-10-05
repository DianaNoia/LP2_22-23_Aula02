namespace ClassVsStruct
{
    public struct Player
    {
        // Propriedades auto-implementadas
        public float Health { get; set; }
        public float Armor { get; set; }

        public Player(float health)
        {
            Health = health;
            Armor = 101f;
        }
    }
}