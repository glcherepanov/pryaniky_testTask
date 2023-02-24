namespace Pryaniky_TestTask.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Product Product { get; set; }
    }
}
