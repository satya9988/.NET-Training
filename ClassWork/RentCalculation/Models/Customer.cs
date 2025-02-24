using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RentCalculation.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Name must be Entred")]
        [MinLength(3)]
        [StringLength(10)]

        public string Name { get; set; }

        [Required(ErrorMessage = "OwnerName must be Entred")]
        [MinLength(3)]
        [StringLength(10)]
        public string OwnerNmae { get; set; }


        [Required(ErrorMessage = "Cost must be Entred")]
        [Range (500,int.MaxValue)]
        public int cost { get; set; }

        [Required(ErrorMessage = "Start Date must be Entred")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date must be Entred")]
        public DateTime EndDate { get; set; }

       
        
        public double TotatCost { get; set; }
            
            

    }
}
