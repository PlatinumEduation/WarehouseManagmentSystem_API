


namespace WarehouseManagmentSystem_API.infrastructure.Entities
{
    /// <summary>
    /// many products can belong to one category
    /// </summary>
    public class ProductsEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Product_Id { get; set; }

        [MaxLength(15,ErrorMessage = "Product Name shouldn't be more than 15 characters.")]
        [Display(Name ="Product Name:")]
        [Required(ErrorMessage = "This field is required!!")]
        public string Product_Name{ get; set; }

        [Display(Name = "Product Quantity:")]
        [Required(ErrorMessage = "This field is required!!")]
        public int Product_Quantity { get; set; }

        [MaxLength(50, ErrorMessage = "Product Name shouldn't be more than 50 characters.")]
        [Display(Name = "Product Discription:")]
        [Required(ErrorMessage = "This field is required!!")]
        public string Product_Discription { get; set; }
        [Display(Name = "Product Unit Price:")]
        public decimal Product_UnitPrice { get; set; }

        [Display(Name = "Product restock quantity:")]
        [Required(ErrorMessage = "This field is required!!")]
        public int Product_Quantity_Warning { get; set; }

        // Nav props
        [Display(Name = "Product Category:")]
        public Guid Category_Id { get; set; }


        // Lazy loading
        [ForeignKey("Category_Id")]
        public virtual CategoriesEntity CategoriesEntity { get; set; }

        // Nav Props
        public List<OrderItems> OrderItems { get; set; }

    }
}
