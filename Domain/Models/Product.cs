namespace APIProject.Domain.Models
{
    public class Product
    {
        public long ProductId { get; set; }

        public string? Name{ get; set; }

        public string? Description{get; set;}

        public decimal Price{ get; set; }

        public bool Status { get; set; }

        public long CategoryId { get; set; }

        public Category? Category {get; set;}                    
    }
}