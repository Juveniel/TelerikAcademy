using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatsSystem.Models
{
    public class City
    {
        private ICollection<Dealer> dealers;

        public City()
        {
            this.dealers = new HashSet<Dealer>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Index("CityNameIndex", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Dealer> Dealers
        {
            get
            {
                return this.dealers;                
            }

            set
            {
                this.dealers = value;                
            }
        }
    }
}
