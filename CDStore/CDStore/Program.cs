using System;
using System.Linq;

namespace CDStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CDStoreDbContext();
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Write("\n\nEnter 1 to add an Artist \n2 to List Artists \n3 Find artist \n4 List Songs in a CD\n5 Add a song to a artist \n9 to Quit : ");
                char key = Console.ReadLine()[0];
                switch (key)
                {
                    case '1':
                        AddArtist(context);
                        break;
                    case '2':
                        ListArtists(context);
                        break;
                    case '3':
                        FindArtist(context);
                        break;
                    case '4':
                        FindCDByTitle(context);
                        break;
                    case '5':
                        AddSongToArtist(context);
                        break;
                    case '6':
                        ListCdsByTitle(context);
                        break;
                    case '9':
                        keepGoing = false;
                        break;
                }
            }
        }

        private static void FindArtist(CDStoreDbContext context)
        {
            Console.WriteLine("Enter Artist's name: ");
            var name = Console.ReadLine();
            var artist = context.Artists.FirstOrDefault(a => a.Name.Contains(name));
            Console.WriteLine("Artist: " + artist.Name);
        }

        private static void ListArtists(CDStoreDbContext context)
        {
            foreach (Artist a in context.Artists)
            {
                Console.WriteLine(a.Name + " " + a.ArtistId);
                foreach (Song s in a.Songs)
                {
                    Console.WriteLine(s.Title + "\t" + s.MusicType);
                }

            }
            Console.WriteLine();
        }

        private static void AddArtist(CDStoreDbContext context)
        {
            Console.Write("Enter name of new Artist: ");
            string name = Console.ReadLine();
            Artist a = new Artist() { Name = name };
            Console.WriteLine("Saving ...");
            context.Artists.Add(a);
            context.SaveChanges();
        }
        private static void FindCDByTitle(CDStoreDbContext context)
        {
            Console.Write("Enter the name of the CD from this list:\n");
            foreach (CD a in context.CDs)
            {
                Console.WriteLine(a.Title + " " + a.CDID);
            }
            string NameOfCD = Console.ReadLine();
            var cd = context.CDs.FirstOrDefault(cdTitle => cdTitle.Title.Contains(NameOfCD));
            foreach (Song s in cd.Songs)
            {
                Console.WriteLine(s.Title + "\t" + s.MusicType);
            }
        }
        private static void AddSongToArtist(CDStoreDbContext context)
        {
            Console.WriteLine("Enter Artist's name: ");
            var name = Console.ReadLine();
            var artist = context.Artists.FirstOrDefault(a => a.Name.Contains(name));

            Console.WriteLine("Enter the name of the new song");
            var NewName = Console.ReadLine();
            var Song = new Song() { Title = NewName, Artist = artist };
            context.Songs.Add(Song);
            context.SaveChanges();

        }
        private static void ListCdsByTitle(CDStoreDbContext context)
        {
            Console.WriteLine("Enter the match string");
            var Count = 0;
            foreach(CD a in context.CDs)
            {
                 var CDNameList = a.Title.Split();
                for (int i = 0; i < CDNameList.Length; i++)
                {

                }
            }
            




        }
    }
}
