using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCodeFirstPract27._01
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                MusicCollection musicCollection = new MusicCollection();
                int action, showAction, addAction;
                string line, name, surname;
                int fId, sId;
                TimeSpan ts;
                bool parse;
                int year;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter action:\n1.Show\n2.Add\n3.Exit");
                    parse = int.TryParse(Console.ReadLine(), out action);
                    if (parse)
                    {
                        switch (action)
                        {
                            case 1:

                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Show menu:\n1.Genres\n2.Countries\n3.Categories\n4.Artists\n5.Songs\n6.Albums\n7.Playlists\n8.Exit");
                                    parse = int.TryParse(Console.ReadLine(), out showAction);
                                    Console.Clear();
                                    if (parse)
                                    {
                                        switch (showAction)
                                        {
                                            case 1:
                                                musicCollection.ShowGenres();
                                                Console.ReadKey();

                                                break;
                                            case 2:
                                                musicCollection.ShowCountries();
                                                Console.ReadKey();

                                                break;
                                            case 3:
                                                musicCollection.ShowCategories();
                                                Console.ReadKey();

                                                break;
                                            case 4:
                                                musicCollection.ShowArtists();
                                                Console.ReadKey();

                                                break;
                                            case 5:
                                                musicCollection.ShowSongs();
                                                Console.ReadKey();

                                                break;
                                            case 6:
                                                musicCollection.ShowAlbums();
                                                Console.ReadKey();

                                                break;
                                            case 7:
                                                musicCollection.ShowPlaylists();
                                                Console.ReadKey();

                                                break;
                                            case 8:
                                                break;
                                            default:
                                                Console.WriteLine("Invalid operation");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                } while (showAction != 8);
                                break;

                            case 2:

                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Add menu:\n1.Genre\n2.Country\n3.Category\n4.Artist\n5.Song\n6.Album\n7.Playlist\n8.Song to playlist\n9.Song to album\n10.Exit");
                                    parse = int.TryParse(Console.ReadLine(), out addAction);

                                    if (parse)
                                    {
                                        switch (addAction)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.Write("Enter genre name: ");
                                                line = Console.ReadLine();
                                                musicCollection.AddGenre(line);
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.Write("Enter country name: ");
                                                line = Console.ReadLine();
                                                musicCollection.AddCoutry(line);
                                                break;
                                            case 3:
                                                Console.Clear();
                                                Console.Write("Enter category name: ");
                                                line = Console.ReadLine();
                                                musicCollection.AddCategory(line);
                                                break;

                                            case 4:
                                                Console.Clear();
                                                Console.Write("Enter name: ");
                                                name = Console.ReadLine();
                                                Console.Clear();

                                                Console.Write("Enter surname: ");
                                                surname = Console.ReadLine();
                                                Console.Clear();
                                                do {
                                                    musicCollection.ShowCountries();
                                                    Console.Write("Enter country number: ");
                                                    parse = int.TryParse(Console.ReadLine(), out fId);
                                                } while (!parse);
                                                musicCollection.AddArtist(name, surname, fId);
                                                break;

                                            case 5:
                                                Console.Clear();
                                                Console.Write("Enter name: ");
                                                name = Console.ReadLine();
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.Write("Enter duration: ");
                                                    parse = TimeSpan.TryParse(Console.ReadLine(), out ts);
                                                } while (!parse);
                                                musicCollection.AddSong(name, ts);
                                                break;

                                            case 6:
                                                Console.Clear();
                                                Console.Write("Enter name: ");
                                                name = Console.ReadLine();
                                                do
                                                {
                                                    Console.Clear();
                                                    musicCollection.ShowArtists();
                                                    Console.WriteLine("Enter number of artist: ");
                                                    parse = int.TryParse(Console.ReadLine(), out fId);
                                                } while (!parse);
                                                do
                                                {
                                                    Console.Clear();
                                                    musicCollection.ShowGenres();
                                                    Console.WriteLine("Enter number of genre: ");
                                                    parse = int.TryParse(Console.ReadLine(), out sId);
                                                } while (!parse);
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.Write("Enter year: ");
                                                    parse = int.TryParse(Console.ReadLine(), out year);
                                                } while (!parse);
                                                musicCollection.AddAlbum(name, fId, sId, year);
                                                break;

                                            case 7:
                                                Console.Clear();
                                                Console.Write("Enter name: ");
                                                name = Console.ReadLine();
                                                do
                                                {
                                                    Console.Clear();
                                                    musicCollection.ShowCategories();
                                                    Console.WriteLine("Enter number of category: ");
                                                    parse = int.TryParse(Console.ReadLine(), out fId);
                                                } while (!parse);
                                                musicCollection.AddPlaylist(name, fId);
                                                break;
                                            case 8:
                                                do
                                                {
                                                    Console.Clear();
                                                    musicCollection.ShowPlaylistsNames();
                                                    Console.Write("Enter number of playlist: ");
                                                    parse = int.TryParse(Console.ReadLine(), out fId);
                                                } while (!parse);
                                                do
                                                {
                                                    Console.Clear();
                                                    musicCollection.ShowSongs();
                                                    Console.Write("Enter number of song: ");
                                                    parse = int.TryParse(Console.ReadLine(), out sId);
                                                } while (!parse);
                                                musicCollection.AddSongToPlayList(fId, sId);
                                                break;
                                            case 9:
                                                do
                                                {
                                                    Console.Clear();
                                                    musicCollection.ShowAlbumsNames();
                                                    Console.Write("Enter number of album: ");
                                                    parse = int.TryParse(Console.ReadLine(), out fId);
                                                } while (!parse);
                                                do
                                                {
                                                    Console.Clear();
                                                    musicCollection.ShowSongs();
                                                    Console.Write("Enter number of song: ");
                                                    parse = int.TryParse(Console.ReadLine(), out sId);
                                                } while (!parse);
                                                musicCollection.AddSongToAlbum(fId, sId);
                                                break;
                                            case 10:
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("Invalid operation");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                } while (addAction != 10);





                                break;
                            case 3:

                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid operation");
                                Console.ReadKey();
                                break;
                        }


                    }
                } while (action != 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
    }
}
