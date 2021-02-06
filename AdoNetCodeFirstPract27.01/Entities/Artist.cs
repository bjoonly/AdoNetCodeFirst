namespace AdoNetCodeFirstPract27._01
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        public Artist()
        {
            this.Albums = new HashSet<Album>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
       
        public virtual ICollection<Album> Albums { get; set; }
    }
}