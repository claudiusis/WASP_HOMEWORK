using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisicDVDStore
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        public void DiscountPrice(int percent)
        {
            Price *= 100-percent;
        }

    }
    public class Disk : IStoreItem
    {
        protected string _name, _genre;
        protected int _burnCount;

        public Disk()
        {
            _name = "Undefined";
            _genre = "Undefined";
        }

        public Disk(string name, string genre) : this()
        {
            _name = name;
            _genre = genre;
        }

        public string Name { get { return _name; } set { _name = value; }}
        public string Genre { get { return _genre; } set { _genre = value; } }

        public int BurnCount { get => _burnCount; }

        public virtual double DiskSize { get;}
        public double Price { get; set; }

        public virtual void Burn(params string[] values) { }

        public void DiscountPrice(int percent)
        {
            Price*=(double)(100-percent)/100;
        }
    }
    public class Audio :Disk
    {
        string _artist, _recordingStudio;
        int _songsNumber;

        public Audio(string artist, string recordingStudio, int songsNumber, string name,string genre)
            :base(name,genre)
        {
            _artist = artist;
            _recordingStudio = recordingStudio;
            _songsNumber = songsNumber;
        }

        public override double DiskSize { get => _songsNumber * 8;}

        public override void Burn(params string[] values)
        {
            _artist = values[0];
            _recordingStudio = values[1];
            _songsNumber = Convert.ToInt32(values[2]);
            _name = values[3];
            _genre = values[4];       
            _burnCount++;
        }
        public override string ToString()
        {
            string s = $"Название {_name}\nЖанр {_genre}\nИсполнитель {_artist}\nСтудия звукозвписи {_recordingStudio}\n" +
                $"Количнство песен {_songsNumber}\nКоличество прожигов {_burnCount}\n\n\n";
            return s;
        }

    }
    public class DVD : Disk
    {
        protected string _producer;
        protected string _filmCompany;
        protected double _minutesCount;

        public DVD(string producer, string filmCompany, int minetesCount, string name, string genre)
            :base(name,genre)
        {
            _producer = producer;
            _filmCompany = filmCompany;
            _minutesCount = minetesCount;
        }

        public string Producer { get => _producer; set => _producer = value; }
        public string FilmCompany { get => _filmCompany; set => _filmCompany = value; }
        public double MinutesCount{get=> _minutesCount; set => _minutesCount = value; }
        public override double DiskSize { get => (double)(_minutesCount / 64) * 2; }

        public override void Burn(params string[] values)
        {
            _producer = values[0];
            _filmCompany = values[1];
            _minutesCount = Convert.ToInt32(values[2]);
            _name =values[3];
            _genre=values[4];
            _burnCount++;
        }

        public override string ToString()
        {
            string s = $"Название {_name}\n" + $"Жанр {_genre}\n" +$"Режиссёр {_producer}\n"+$"Кинокомпания {_filmCompany}\n"+
                $"Количество минут {_minutesCount}\n" +$"Количество прожигов {_burnCount}\n\n\n";
            return s;
        }
    }
    public class Store
    {
        private string _storeName;
        private string _adress;
        private List<Audio> _audios;
        private List<DVD> _dvds;

        public string StoreName { get => _storeName; set => _storeName = value; }

        public string Adress { get => _adress; set => _adress = value; }

        public List<Audio> Audios { get => _audios; set => _audios = value; }
        public List<DVD> Dvds { get => _dvds; set => _dvds = value; }

        public Store() 
        { 
            _storeName = "Store";
            _adress = "Moskow";
        }
        public Store(string storeName, string adress)
        {
            _storeName = storeName;
            _adress = adress;
            _audios= new List<Audio>();
            _dvds= new List<DVD>();
        }
        public static List<Audio> operator +(Store item,Audio a)
        {
            item.Audios.Add(a);
            return item._audios;
        }

        public static List<Audio> operator -(Store item,Audio a) { 
            item._audios.Remove(a);
            return item._audios;
        }

        public static List<DVD> operator +(Store item,DVD a)
        {
            item._dvds.Add(a);
            return item._dvds;
        }

        public static List<DVD> operator -(Store item, DVD a)
        {
            item._dvds.Remove(a);
            return item._dvds;
        }

        public override string ToString()
        {
            string s = $"{_storeName}\n{_adress}\n\n";
            if(_audios.Count > 0) { s += "\nAudio:\n\n"; }
            foreach(Audio a in _audios)
            {
                s += a.ToString();
            }
            if (_dvds.Count > 0) { s += "\nFilms:\n\n"; }
            foreach(DVD dvd in _dvds)
            {
                s += dvd.ToString();
            }
            return s; 
        }
    }
}
