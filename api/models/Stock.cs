
using System.ComponentModel.DataAnnotations.Schema;


namespace api.models
{
    public class Stock
    {
        public int Id { get; set; }

        public string Symbol { get; set; } = string.Empty; // empty as of now not null

        public string CompanyName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")] // 18 digits with 2 digits after decimal points for database
        public decimal Purchase { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Lastdiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = [];

        





    }
}