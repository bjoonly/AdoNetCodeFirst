namespace AdoNetCodeFirstPract27._01
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public Country()
        {
            this.Artists = new HashSet<Artist>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
     
        public virtual ICollection<Artist> Artists { get; set; }

        
    }
}