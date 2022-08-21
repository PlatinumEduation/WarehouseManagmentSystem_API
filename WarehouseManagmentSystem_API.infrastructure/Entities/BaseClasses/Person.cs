
namespace WarehouseManagmentSystem_API.infrastructure.Entities.BaseClasses
{
    public class Person:Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(10,ErrorMessage ="Please select a role !!")]
        public RoleEnum Role { get; set; }
        [MaxLength(10,ErrorMessage ="Please enter a valid number !!")]
        public string Number { get; set; }
        public Boolean Status { get; set; } = true;
    }
}
