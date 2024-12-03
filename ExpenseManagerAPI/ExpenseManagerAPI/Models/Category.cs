using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManageAPI.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string CategoryName { get; set; }
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
