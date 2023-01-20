namespace ProductDisplayApp
{
    internal class Product
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int Quantity { get; internal set; }
        public double Price { get; internal set; }
        public string Category { get; internal set; }
        public int OrderCount { get; internal set; }
    }
}