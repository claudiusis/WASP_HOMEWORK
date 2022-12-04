using MisicDVDStore;
using System;

namespace WASP
{
    class Program
    {
        public static void Main()
        {
            Store mstore = new Store("POP","Vernadka");
            DVD dVD = new DVD("John Favro","MARVEL",150,"Iron Man","Adventure");
            DVD dVD1 = new DVD("Quentin Tarantino", "Columbia Pictures", 165, "Django Unchained", "Western");
            DVD dVD2 = new DVD("Robert Zemeckis", "ImageMovers", 143, "Cast Away", "Adventure");
            Audio audio = new Audio("Queen", "-", 15, "Yembley", "Rock");
            Audio audio2 = new Audio("LedZeppelin", "-", 10, "Yembley", "Rock");
            Audio audio3 = new Audio("RHCP", "-", 15, "The Getaway", "Rock");
            mstore.Audios = mstore + audio;
            mstore.Audios = mstore + audio2;
            mstore.Audios = mstore + audio3;
            mstore.Dvds = mstore + dVD;
            mstore.Dvds = mstore + dVD1;
            mstore.Dvds = mstore + dVD2;
            Console.WriteLine(mstore.ToString());
            dVD1.Burn("George Lukas", "ucasfilm Ltd.", "165", "Star Wars", "Space Opera");
            foreach(Audio i in mstore.Audios)
            {
                Console.WriteLine(i.Name + "->" + i.DiskSize);
            }
            foreach(DVD j in mstore.Dvds)
            {
                Console.WriteLine(j.Name + "->" + j.DiskSize);
            }
        }
    }
}