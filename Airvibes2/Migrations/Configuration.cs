namespace Airvibes2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Airvibes2.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Airvibes2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Airvibes2.Models.ApplicationDbContext context)
        {
            //var Artists = new List<Artists>
            //{
            //    new Artists {Photo = "nothingmore.jpg",Name = "Nothing More", Bio = "Lorem Ipsum"},
            //    new Artists {Photo = "setyourgoals.jpg",Name = "Set Your Goals", Bio = "Lorem Ipsum 2"}
            //};

            //Artists.ForEach(a => context.Artists.Add(a));
            //context.SaveChanges();
            //var Records = new List<Records>
            //{
            //    new Records { Artists_Id = 1, Cover = "nothingmore.jpg", Title = "Nothing More", ReleaseDate = new DateTime(2014,06,24), Genre = "Hard Rock", SongsFrom = null},
            //    new Records { Artists_Id = 2, Cover = "thiswillbethedeathofus.jpg", Title = "This will be the Death of Us", ReleaseDate = new DateTime(2009, 07, 21), Genre = "Punk Rock", SongsFrom = null},
            //    new Records { Artists_Id = 2, Cover = "mutiny.jpg", Title = "Mutiny!", ReleaseDate = new DateTime(2006,07,11), Genre = "Punk Rock", SongsFrom = null}
            //};
            //Records.ForEach(R => context.Records.Add(R));
            //context.SaveChanges();
            //var Songs = new List<Songs>
            //{
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "Ocean Floor", Duration = 60,  TimesPlayed = 5, FilePath="01. Ocean Floor.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "This is The Time", Duration = 220,  TimesPlayed = 5, FilePath="02. Ballast.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "Christ Copyright", Duration = 198,  TimesPlayed = 3, FilePath="03. Christ Copyright.mp3" },
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "Mr. MTV", Duration = 240,  TimesPlayed = 5, FilePath="04. Mr MTV.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "Gyre", Duration = 177,  TimesPlayed = 1, FilePath="05. First Punch.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "The Matthew Effect", Duration = 196,  TimesPlayed = 5, FilePath="06. Gyre.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "I'll be OK", Duration = 286,  TimesPlayed = 5, FilePath="07. The Matthew Effect.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "Here's to the Heartache", Duration = 60,  FilePath="08. Ill Be OK.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "If I were", Duration = 212,  TimesPlayed = 5, FilePath="09. Heres To The Heartache.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "Friendly Fire", Duration = 223,  TimesPlayed = 5, FilePath="10. If I Were.mp3"},
            //    new Songs {Artists_Id = 1, Records_Id = 1, Title = "Sex and Lies", Duration = 254,  TimesPlayed = 5, FilePath="11. Friendly Fire.mp3"},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "This will be the Death of us", Duration = 190,  TimesPlayed = 5,FilePath="12. Sex  Lies.mp3"},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "With Hoffman Lenses...", Duration = 43,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Look Closer", Duration = 231,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Summer Jam", Duration = 186,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Like You To Me", Duration = 266,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "The Fallen...", Duration = 204,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "The Few That Remain", Duration = 201,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Equals", Duration = 203,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Make Way For Men", Duration = 172,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Flawed Methods...", Duration = 250,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Arrival Notes", Duration = 69,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 2, Title = "Our Ethos", Duration = 190,  TimesPlayed = 5, FilePath=null},
            //    new Songs {Artists_Id = 2, Records_Id = 3, Title = "Work in Progress", Duration = 134,  TimesPlayed = 5, FilePath="01 Work In Progress.mp3"},
            //    new Songs {Artists_Id = 2, Records_Id = 3, Title = "We do it For the Money", Duration = 53,  TimesPlayed = 5, FilePath="02 We Do it For The Money Obviously.mp3"},
            //    new Songs {Artists_Id = 2, Records_Id = 3, Title = "Dead Men Tell No Tales", Duration = 58,  TimesPlayed = 5, FilePath="03 Dead Men Tell No Tales.mp3"},
            //    new Songs {Artists_Id = 2, Records_Id = 3, Title = "Mutiny !", Duration = 242,  TimesPlayed = 5, FilePath="04 Mutiny.mp3"}
            //};
            //Songs.ForEach(s => context.Songs.Add(s));
            //context.SaveChanges();
        }
    }
}
