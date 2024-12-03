using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManageAPI.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        [Required]
        public string Title { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
