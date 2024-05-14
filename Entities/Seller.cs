using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShoppingControl.Entities
{
    public sealed class Seller
    {
        private int Id { get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field can't be null.", ErrorMessageResourceName = "Invalid name.")]
        private string Name { get; }

        private int SellerId { get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field can't be null.", ErrorMessageResourceName = "Invalid salary.")]
        private double Salary { get; }

        private DateTime createdDate { get; } = DateTime.Parse("dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

        private Department Department { get; }

        public Seller(int id, string name, int sellerId, double salary, Department department)
        {
            this.Id = id;
            this.Name = name;
            this.SellerId = sellerId;
            this.Salary = salary;
            Department = department;
        }
    }
}
