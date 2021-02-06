namespace AdoNetCodeFirstPract27._01
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class Category
    {
        public Category()
        {
            this.Playlists = new HashSet<Playlist>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}