
namespace WarehouseManagmentSystem_API.infrastructure.Entities
{
    /// <summary> 
    /// One Category can have many products @oneToMany
    /// </summary>
    /// 

    [Index(nameof(Category_Name),IsUnique =true)]
    public class CategoriesEntity //using Fluent API
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Category_Id { get; set;}
        [Required(ErrorMessage ="This field is required!!")]
        [MaxLength(15, ErrorMessage = "Category Name shouldn't be more than 15 characters.")]
        public int Category_Name { get; set;}
        [MaxLength(50, ErrorMessage = "Category Description shouldn't be more than 50 characters.")]
        public string? Category_Description { get; set;}
        public List<ProductsEntity> Products { get; set; }

    }
}
