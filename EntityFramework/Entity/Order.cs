namespace EntityFramework.Entity
{
    public class Order: BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public Product Product { get; set; }
    }
}
