namespace Model.Data
{
    public class OrderItemData
    {
        public DateTime Date { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
