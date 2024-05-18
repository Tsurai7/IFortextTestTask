using TestTask.Enums;

namespace TestTask.Models
{
    /// <summary>
    /// Order.
    /// DO NOT change anything here.
    /// </summary>
    public class Order
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; } 

        public int UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public OrderStatus Status { get; set; }

        public virtual User User { get; set; }
    }
}
