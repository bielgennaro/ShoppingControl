using System.ComponentModel.DataAnnotations;

namespace ShoppingControl.Entities
{
    public sealed class Department
    {
        private int Id { get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field can't be null.", ErrorMessageResourceName = "Invalid department name.")]
        private string Name { get; set; }

        [Required(AllowEmptyStrings = true)]
        private string Description { get; set; }

        private ICollection<Seller> Sellers = new List<Seller>();

        public Department(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}