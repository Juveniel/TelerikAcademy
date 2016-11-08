using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatsSystem.Models
{
    public class Dealer
    {
        private ICollection<City> cities;

        public Dealer()
        {
            this.cities = new HashSet<City>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int CityId { get; set; }

        public virtual ICollection<City> Cities
        {
            get
            {
                return this.cities;                
            }

            set
            {
                this.cities = value;                
            }
        }
    }
}
