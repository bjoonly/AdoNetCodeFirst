using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCodeFirstPract27._01
{
    class MusicCollection
    {
        MyDbContext dbContext;

        public MusicCollection()
        {
            dbContext = new MyDbContext();
        }
        public void AddCoutry(string name)
        {
            if (dbContext.Countries.FirstOrDefault(c => c.Name == name) == null)
            {
                dbContext.Countries.Add(new Country() { Name = name });
                dbContext.SaveChanges();
            }
        }
        public void AddGenre(string name)
        {
            if (dbContext.Genres.FirstOrDefault(g => g.Name == name) == null)
            {
                dbContext.Genres.Add(new Genre() { Name = name });
                dbContext.SaveChanges();
            }
        }
        public void AddCategory(string name)
        {
            if (dbContext.Categories.FirstOrDefault(c => c.Name == name) == null)
            {
                dbContext.Categories.Add(new Category() { Name = name });
                dbContext.SaveChanges();
            }
        }
        public void AddArtist(string name, string surname, int countryId)
        {
            if (dbContext.Countries.Find(countryId) != null)
            {
                dbContext.Artists.Add(new Artist() { Name = name, Surname = surname, CountryId = countryId });
                dbContext.SaveChanges();
            }
        }
        public void AddSong(string name, TimeSpan duration, int albumId=-1)
        {
            if (dbContext.Albums.Find(albumId) != null || albumId==-1)
            {
                Song song=dbContext.Songs.Add(new Song() { Name = name, Duration = duration });
                if (albumId != -1)
                    song.AlbumId = albumId;
                dbContext.SaveChanges();
            }
        }
        public void AddAlbum(string name, int artistId, int genreId,int year, ICollection<Song> songs = null)
        {
            if (dbContext.Artists.Find(artistId) != null && dbContext.Genres.Find(genreId) != null)
            {
               Album album= dbContext.Albums.Add(new Album() { Name = name, ArtistId = artistId, GenreId = genreId,Year=year });
                if (songs != null)
                {
                    foreach (var item in songs)
                    {
                        album.Songs.Add(item);
                    }
                }

                dbContext.SaveChanges();
            }
        }
        public void AddSongToAlbum(int albumId,int songId)
        {
            if (dbContext.Albums.Find(albumId) != null && dbContext.Songs.Find(songId) != null)
            {
                Album album = dbContext.Albums.Find(albumId);
                Song song = dbContext.Songs.Find(songId);
                album.Songs.Add(song);
                dbContext.SaveChanges();
            }
        }
        public void AddPlaylist(string name, int categoryId, ICollection<Song> songs = null)
        {
            if (dbContext.Categories.Find(categoryId) != null)
            {
                Playlist playlist = new Playlist() { Name = name, CategoryId = categoryId };
                if (songs != null)
                {
                    foreach (var item in songs)
                    {
                        playlist.Songs.Add(item);
                    }
                }
                dbContext.Playlists.Add(playlist);
                dbContext.SaveChanges();
            }
        }
        public void AddSongToPlayList(int playlistId, int songId)
        {
            if (dbContext.Playlists.Find(playlistId) != null && dbContext.Songs.Find(songId) != null)
            {
                Playlist playlist = dbContext.Playlists.Find(playlistId);
                Song song = dbContext.Songs.Find(songId);
                playlist.Songs.Add(song);
                dbContext.SaveChanges();
            }
        }
        

        public void ShowGenres()
        {
            
            foreach (var item in dbContext.Genres)
            {
                Console.WriteLine("{0,3}.{1,-30}",item.Id, item.Name);
          
            }
        }
        public void ShowArtists()
        {

   

            foreach (var item in dbContext.Artists)
            {
                Console.WriteLine("{0,3}.{1,-20} {2,-20} {3,-15}", item.Id, item.Name, item.Surname, item.Country.Name);
             
            }
        }
        public void ShowPlaylists()
        {
            int count = 1;
            foreach (var item in dbContext.Playlists)
            {
                Console.WriteLine("{0,3}.{1,-20} {2,-35}", count, item.Name, item.Category.Name);
                count++;
                ShowSongs(item.Songs);
                Console.WriteLine(new string('-',120));

            }
        }
        public void ShowSongs()
        {
     

            foreach (var song in dbContext.Songs)
            {
                Console.WriteLine("{0,3}.{1,-50} {2,-10}",song.Id, song.Name, song.Duration);
         
            }
        }
        public void ShowCategories()
        {
      

            foreach (var item in dbContext.Categories)
            {
                Console.WriteLine("{0,3}.{1,-25}",item.Id, item.Name);
              
            }
        }
        public void ShowSongs(IEnumerable<Song> songs)
        {
            int count = 1;
            foreach (var song in songs)
            {
                Console.WriteLine("{0,3}.{1,-50} {2,-10}",count, song.Name, song.Duration);
                count++;
 
            }
        }
        public void ShowAlbums()
        {

            int count = 1;
            foreach (var item in dbContext.Albums)
            {
                Console.WriteLine("{0,3}.{1,-25} {2,-40} {3,-15}",count, item.Name, item.Year, item.Artist.Name + " " + item.Artist.Surname, item.Genre.Name);
                ShowSongs(item.Songs);
                count++;
                Console.WriteLine(new string('-', 120));

            }
        }
        public void ShowAlbumsNames()
        {
            int count = 1;
            foreach (var item in dbContext.Albums)
            {
                Console.WriteLine("{0,3}.{1,-30}", item.Id, item.Name);
                count++;
            }
        }
        public void ShowPlaylistsNames()
        {
     
            foreach (var item in dbContext.Playlists)
            {
                Console.WriteLine("{0,3}.{1,-20}", item.Id, item.Name);
         
            }
        }
        public void ShowCountries()
        {
            int count = 1;

            foreach (var item in dbContext.Countries)
            {
                Console.WriteLine("{0,3}.{1,-30}", item.Id, item.Name);
                count++;
            }
        }
    }
}
