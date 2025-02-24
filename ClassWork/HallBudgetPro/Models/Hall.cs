using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HallBudgetPro.Models
{
    [Table("hall")]
    public class Hall
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("hallname")]
        public string HallName { get; set; }

        [Column("ownername")]
        public string OwnerName { get; set; }

        [Column("costperday")]
        public int CostPerDay { get; set; }

        [Column("mobile")]
        public string Mobile { get; set; }

        [Column("address")]
        public string Address { get; set; }
    }
}
