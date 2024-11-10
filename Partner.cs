namespace WindowsFormsApp1
{
    internal class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public string DirectorName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Rating { get; set; }
        public int TotalQuantity { get; set; } = 0; // Инициализация по умолчанию
    }
}