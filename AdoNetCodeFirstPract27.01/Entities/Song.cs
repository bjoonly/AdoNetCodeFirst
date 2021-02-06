namespace AdoNetCodeFirstPract27._01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        public Song()
        {
            this.Playlists = new HashSet<Playlist>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? AlbumId { get; set; }
        public TimeSpan Duration { get; set; }


 
        public virtual Album Album { get; set; }
        public virtual ICollection<Playlist> Playlists{get;set;}

    }
}