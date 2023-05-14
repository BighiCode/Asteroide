namespace CorposCelestes.Asteroides
{
    public struct AsteroidStatus
    {
        public AsteroidStatus(int life, int resistence, int size)
        {
            Life = life;
            Resistence = resistence;
            Size = size;
        }

        public int Life { get; set; }
        public int Resistence { get; set; }
        public int Size { get; set; }
    }
}