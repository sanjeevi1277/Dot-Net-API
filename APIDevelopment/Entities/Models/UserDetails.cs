using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("UserDetails")]
    public class UserDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [Column("Name", TypeName = "nvarchar(50)")]

        public string? Name { get; set; }
        [Required]
        [Column("EmailAddress", TypeName = "nvarchar(50)")]
        public string? EmailAddress { get; set; }
        //Identity: ValueGeneratedOnAdd
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreatedOn { get; set; } = DateTime.UtcNow;
        //Computed: ValueGeneratedOnAddOrUpdate
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;

    }
}
