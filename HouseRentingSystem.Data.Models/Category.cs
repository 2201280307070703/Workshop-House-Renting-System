using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Common.EntityValidations.Category;
namespace HouseRentingSystem.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Houses = new HashSet<House>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<House> Houses { get; set; }
    }
}
