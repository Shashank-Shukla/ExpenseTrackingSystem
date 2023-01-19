using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackingSystem.Models.DatabaseModels
{
    public class ExpenseCategory
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CategoryName { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? CategoryDescription { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]
        public string? Icon { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(50)")]
        public string CategoryType { get; set; }
    }
}
