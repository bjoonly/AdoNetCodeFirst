using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCodeFirstPract27._01
{
    public class Genre
    {
        public Genre()
        {
            Albums = new HashSet<Album>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Album>Albums{ get; set; }
    }
}
