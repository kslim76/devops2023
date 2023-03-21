using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{
	//user2 modifying the code 
	// add sub catalog name

    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
	//rename catalog by user 3
        [Column("Catalog_Id")]
        public long CatalogId { get; set; }
        [Column("Catalog_Name")]
        [Required]
        [StringLength(50)]
	//user3 modifying the code
	//he wanat to additional constaint to catalog name as well
        public string? CatalogName { get; set; }

        //[JsonIgnore]       
       // public Collection<Product> ProductList { get; set; }


    }
}
