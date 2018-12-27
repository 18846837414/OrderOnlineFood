using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderOnlineFood.Models
{
    //public class Restaurant
    //{
    //    public int Id { get; set; }
    //    [Required,MaxLength(20)]
    //    [Display(Name = "Restaurant Name")]
    //    public String Name { get; set; }
    //}

    [Table("Restaurant", Schema = "dbo")]
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Department Id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Department Code")]
        public string DepartmentCode { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Department Description")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
    }
}
