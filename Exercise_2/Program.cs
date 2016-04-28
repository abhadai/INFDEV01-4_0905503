using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        interface ISong
        {
            void visit(IMusicLibraryVisitor IMusicLibraryVisitor);
        }

        class Jazz : ISong
        {
            public string song;

            public Jazz(string song)
            {
                this.song = song;
            }

            public void visit(IMusicLibraryVisitor IMusicLibraryVisitor)
            {
            }
        }

        class HeavyMetal : ISong
        {
            public string song;

            public HeavyMetal(string song)
            {
                this.song = song;
            }

            public void visit(IMusicLibraryVisitor IMusicLibraryVisitor)
            {
            }
        }

        interface IMusicLibraryVisitor
        {
            void onHeavyMetal(HeavyMetal HeavyMetal);
            void onJazz(Jazz Jazz);
        }

        // Wil visit the Jazz and HeavyMetal class
        class MusicLibaryVisitor : IMusicLibraryVisitor
        {
            public List<HeavyMetal> heavy_metal;
            public List<Jazz> jazz;

            public MusicLibaryVisitor(List<HeavyMetal> hm, List<Jazz> j)
            {
                this.heavy_metal = hm;
                this.jazz = j;
                Console.WriteLine("There are " + heavy_metal.Count().ToString() + " heavy metal songs ");
                Console.WriteLine("There are " + jazz.Count().ToString() + " jazz songs ");
            }

            public void onHeavyMetal(HeavyMetal HeavyMetal)
            {
                this.heavy_metal.Add(HeavyMetal);
            }

            public void onJazz(Jazz Jazz)
            {
                this.jazz.Add(Jazz);
            }
        }

        static void Main(string[] args)
        {
            List<Jazz> jazz_songs = new List<Jazz>();
            List<HeavyMetal> heavy_metal_songs = new List<HeavyMetal>();

            // Add songs the appropriate lists
            jazz_songs.Add(new Jazz("Take Five - Dave Brubeck"));
            jazz_songs.Add(new Jazz("What a Wonderful World - Louis Armstrong"));
            jazz_songs.Add(new Jazz("Acknowledgment - John Coltrane Quartet"));
            jazz_songs.Add(new Jazz("My Favorite Things - Dave Brubeck"));
            jazz_songs.Add(new Jazz("All Blues - Kenny Burrell"));

            heavy_metal_songs.Add(new HeavyMetal("Hallowed Be Thy Name - Iron Maiden"));
            heavy_metal_songs.Add(new HeavyMetal("Master of Puppets - Metallica"));
            //heavy_metal_songs.Add(new HeavyMetal("Paranoid - Black Sabbath"));
            //heavy_metal_songs.Add(new HeavyMetal("One - Metallica"));
            //heavy_metal_songs.Add(new HeavyMetal("Holy Wars... The Punishment Due - Megadeth"));

            MusicLibaryVisitor mv = new MusicLibaryVisitor(heavy_metal_songs, jazz_songs);
            mv.onHeavyMetal(new HeavyMetal(""));
            mv.onJazz(new Jazz(""));

            Console.Read();
        }
    }
}
