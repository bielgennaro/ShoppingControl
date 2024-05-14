using System.ComponentModel.DataAnnotations;

namespace ShoppingControl.Entities.Enum
{
    public enum SaleStatus
    {
        [Display(Name = "Pending")]
        PENDING,

        [Display(Name = "Paid")]
        PAID,

        [Display(Name = "Shipped")]
        SHIPPED,

        [Display(Name = "Canceled")]
        CANCELED
    }
}
