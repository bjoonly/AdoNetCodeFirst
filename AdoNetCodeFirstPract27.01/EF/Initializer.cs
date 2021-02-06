using System.Collections.Generic;
using System.Data.Entity;

namespace AdoNetCodeFirstPract27._01
{
    public class Initializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            base.Seed(context);

            Genre punk = context.Genres.Add(new Genre() { Name = "Punk" });
            Genre blues = context.Genres.Add(new Genre() { Name = "Blues" });
            Genre techno = context.Genres.Add(new Genre() { Name = "Techno" });
            Genre hipHop = context.Genres.Add(new Genre() { Name = "Hip-Hop" });
            Genre jazz = context.Genres.Add(new Genre() { Name = "Jazz" });

            Genre pop = context.Genres.Add(new Genre() { Name = "Pop" });
            Genre reggae = context.Genres.Add(new Genre() { Name = "Reggae" });
            Genre rock = context.Genres.Add(new Genre() { Name = "Rock" });
            Genre alternativeRock = context.Genres.Add(new Genre() { Name = "Alternative rock" });
            Genre emoPop = context.Genres.Add(new Genre() { Name = "Emo pop" });
            context.SaveChanges();


            Category relax = context.Categories.Add(new Category() { Name = "Relax" });
            context.SaveChanges();



            Country gb = context.Countries.Add(new Country() { Name = "Great Britain" });
            Country usa = context.Countries.Add(new Country() { Name = "United States" });
            context.SaveChanges();

            Artist OliverTree = context.Artists.Add(new Artist() { CountryId = usa.Id, Name = "Oliver", Surname = "Nickell" });
            Artist CallMeKarizma = context.Artists.Add(new Artist() { CountryId = usa.Id, Name = "Morgan", Surname = "Parriott" });
            Artist BillieElish = context.Artists.Add(new Artist() {CountryId=gb.Id,Name= "Dominic",Surname= "Harrison" });
            context.SaveChanges();

            Song OTWasteMyTime = context.Songs.Add(new Song() {  Duration = new System.TimeSpan ( 0, 3, 27), Name = "Waste My Time" });
            Song OTLetMeDown = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 1, 51), Name = "Let Me Down" });
            Song OTCashMachine = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 56), Name = "Cash Machine" });
            Song OTMiracleMan = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 5), Name = "Miracle Man" });
         

            Song BEYouShouldSeeMeInACrown = context.Songs.Add(new Song() {Duration= new System.TimeSpan(0,3,1), Name = "You should see me in a crown" });
            Song BECopycat = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 39), Name = "Copycat" });
            Song BEBuryAFriend = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 33), Name = "Bury a friend" });
            Song BEBadGuy = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 26), Name = "Bad guy" });
            Song BEWhenThePartyOver = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 14), Name = "When the party's over" });
           

            Song CMKWaste = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 51), Name = "Waste" });
            Song CMKGetMeOutOfLA = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 7), Name = "Get me out of L.A." });
            Song CMKAmerica = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 39), Name = "America" });
            Song CMKRedRoses = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 50), Name = "Red Roses" });
            context.SaveChanges();


           
            Album albumCMK = context.Albums.Add(new Album() { Name = "To Hell With Hollywood", GenreId = alternativeRock.Id, Year = 2020, ArtistId = CallMeKarizma.Id});
            
            albumCMK.Songs.Add(CMKRedRoses);
            albumCMK.Songs.Add(CMKAmerica);
            albumCMK.Songs.Add(CMKWaste);
            albumCMK.Songs.Add(CMKGetMeOutOfLA);
            context.SaveChanges();



            Album albumOT = context.Albums.Add(new Album() { Name = "Ugly is Beautiful", GenreId = alternativeRock.Id, Year = 2020, ArtistId = OliverTree.Id });
            albumOT.Songs.Add(OTCashMachine);
            albumOT.Songs.Add(OTLetMeDown);
            albumOT.Songs.Add(OTMiracleMan);
            albumOT.Songs.Add(OTWasteMyTime);
            context.SaveChanges();


            
            Playlist playlist = context.Playlists.Add(new Playlist() { CategoryId = relax.Id, Name = "Chill music"});
            playlist.Songs.Add(BEBadGuy);
            playlist.Songs.Add(BEBuryAFriend);
            playlist.Songs.Add(BECopycat);
            playlist.Songs.Add(BEWhenThePartyOver);
            playlist.Songs.Add(BEYouShouldSeeMeInACrown);
            
            context.SaveChanges();

            
            }
    }
}