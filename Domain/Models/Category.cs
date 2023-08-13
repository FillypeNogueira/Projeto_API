using System.Text.Json.Serialization;

namespace APIProject.Domain.Models
{
    public class Category
    {
        public long CategoryId { get; set; }

        public string? Name {get; set;}

        public bool Status {get; set; }
        
        [JsonIgnore]
        public IList<Product> Products {get; set; }  
    }
}

