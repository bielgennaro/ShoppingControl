using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ShoppingControl.Entities.Dto
{
    public class SellerDto
    {
        public string Name { get; set; }

        public string DepartmentName { get; set; }

        public double Salary { get; set; }
    }
}
