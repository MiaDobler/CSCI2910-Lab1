using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI2910_Lab1
{
    public class VideoGame :IComparable<VideoGame>
    {
        public string Name {  get; set; }
        public string Platform { get; set; }

        public int Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public double NA_Sales { get; set; }
        public double EU_Sales { get; set; }
        public double JP_Sales { get; set; }
        public double Other_Sales { get; set; }
        public double Global_Sales { get; set; }

        public VideoGame() 
        { 
            this.Name = Name;
            this.Platform = Platform;
            this.Year = Year;
            this.Genre = Genre;
            this.Publisher = Publisher;
            this.NA_Sales = NA_Sales;
            this.EU_Sales = EU_Sales;
            this.JP_Sales = JP_Sales;
            this.Other_Sales = Other_Sales;
            this.Global_Sales = Global_Sales;
        }

        public VideoGame(string name, string platform, int year, string genre, string publisher, double nA_Sales, double eU_Sales, double jP_Sales, double other_Sales, double global_Sales)
        {
            Name = name;
            Platform = platform;
            Year = year;
            Genre = genre;
            Publisher = publisher;
            NA_Sales = nA_Sales;
            EU_Sales = eU_Sales;
            JP_Sales = jP_Sales;
            Other_Sales = other_Sales;
            Global_Sales = global_Sales;
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Name:\t\t\t {Name}\n";
            msg += $"Platform:\t\t {Platform}\n";
            msg += $"Year:\t\t\t {Year}\n";
            msg += $"Genre:\t\t\t {Genre}\n";
            msg += $"Publisher:\t\t {Publisher}\n";
            msg += $"NA Sales:\t\t {NA_Sales}\n";
            msg += $"EU Sales:\t\t {EU_Sales}\n";
            msg += $"JP Sales:\t\t {JP_Sales}\n";
            msg += $"Other Sales:\t\t {Other_Sales}\n";
            msg += $"Global Sales:\t\t {Global_Sales}\n";
            msg += "------------------------------\n";
           
            return msg;
        }

        public int CompareTo(VideoGame obj) //Method help from Zach
        { 
            if(obj == null)
                return 1;
            return Comparer<string>.Default.Compare(Name, obj.Name);
        }
    }
}
