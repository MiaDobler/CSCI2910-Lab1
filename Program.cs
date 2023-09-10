using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using System.Runtime.CompilerServices;

namespace CSCI2910_Lab1
{

    //DO ERROR HANDLING

    internal class Program
    {
        static void Main(string[] args)
        {        
            List<VideoGame> videogames = new List<VideoGame>();

            string projectRootFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.ToString();
            string filePath = projectRootFolder + "/videogames.csv";
            
            using (var sr = new StreamReader(filePath)) //from Will's code example
            {
                sr.ReadLine(); 

                while (!sr.EndOfStream)  
                {
                    string line = sr.ReadLine();

                    string[] lineData = line.Split(',');

                    //data is Name, Platform, Year, Genre, Publisher, NA_Sales, EU_Sales, JP_Sales, Other_Sales, Global_Sales order based on header row
                    videogames.Add(new VideoGame(lineData[0], lineData[1], Convert.ToInt16(lineData[2]), lineData[3], lineData[4], Convert.ToDouble(lineData[5]), Convert.ToDouble(lineData[6]), Convert.ToDouble(lineData[7]), Convert.ToDouble(lineData[8]), Convert.ToDouble(lineData[9])));
                }
            }
            videogames.Sort();


            // ----------------- STEPS 3-7 ----------------- //

            //Choose a publisher (e.g., Nintendo) from the dataset and create a list of games from that developer from the list created in the first step. Then sort that list alphabetically and display each item inside.

            //STILL NEED TO display
            //sorts alphabetically by videogame name

            ////Console.Write("PLease enter a publisher: ");
            ////string userPublisher = Console.ReadLine();


            ////static List<VideoGame> SortByPublisher(string userPublisher, List<VideoGame> videogames)
            ////{
            ////    string givenPublishers = Convert.ToString(videogames[4]);

            ////    List<VideoGame> publisherCompared = new List<VideoGame>();
            ////    var whatever = videogames.Where(publisher => givenPublishers == userPublisher);

            ////    foreach (var item in whatever)
            ////    {
            ////        publisherCompared.Add(item);
            ////    }

            ////    return publisherCompared;
            ////}


            //For whichever publisher you chose, calculate and display the percentage of games that belong to that publisher as well as how to many games are from that developer out of the total (e.g., “Out of 500 games, 400 are developed by Nintendo, which is 80%”) -- Make sure your percentage only has 2 decimal places when output

            //STILL NEED TO check if it displays
            ////List<VideoGame> publisherGames = SortByPublisher(userPublisher, videogames);

            ////double publisherPercentageCalc = (publisherGames.Count() / videogames.Count()) * 100;
            ////double publisherPercentage = Math.Round(publisherPercentageCalc,2);

            ////Console.Write($"Out of {videogames.Count()} games, {publisherGames.Count()} are devloped by {userPublisher}, which is {publisherPercentage}%.");


            //Choose a genre (e.g., Role-Playing) and create a list of games of that genre from the list created in the first step. Then sort that list alphabetically and display each item inside.

            //STILL NEED TO check if it returns anything

            //ADD SWICH STATEMENT IN CASE OF LOWER/UPPERCASE SPELLING OF GENRE -- toupper???
            ////Console.Write("PLase enter a genre: ");
            ////string userGenre = Convert.ToString(Console.ReadLine());

            ////static List<VideoGame> SortByGenre(string userGenre, List<VideoGame> videogames)
            ////{
            ////    string givenGenre = Convert.ToString(videogames[3]);

            ////    List<VideoGame> genreSort = new List<VideoGame>();

            ////    foreach (var item in genreSort)
            ////    {
            ////        videogames.Where(publisher => givenGenre == userGenre);
            ////        genreSort.Add(item);
            ////    }
            ////    return genreSort;
            ////}

            //For whichever genre you chose, calculate and display the percentage of games that belong to that genre as well as how many games belong to that genre out of the total(e.g., “Out of 500 games, 100 are Role - Playing games, which is 20 %”)

            ////List<VideoGame> genreGames = SortByGenre(userGenre, videogames);

            ////double genrePercentageCalc = (userGenre.Count() / videogames.Count()) * 100;
            ////double genrePercentage = Math.Round(genrePercentageCalc, 2);

            ////Console.Write($"Out of {videogames.Count()} games, {genreGames.Count()} are {userGenre} games, which is {genrePercentage}%.");



            // ----------------- METHODS ----------------- //

            //publisher data user thingy idk brain dead melting tired
            Console.Write("\nPLease enter a publisher: ");
            string userPublisher = Console.ReadLine();

            PublisherData(userPublisher, videogames);

            void PublisherData(string userPublisher, List<VideoGame> games2)
            {                  
                    IEnumerable<string> publishers = games2.Select(x => x.Publisher);
                    List<string> publishers2 = publishers.Distinct().ToList();

                    IEnumerable<VideoGame> publisherCompared = new List<VideoGame>();
                    publisherCompared = games2.Where(game  => game.Publisher == userPublisher);

                    foreach (var item in publisherCompared)
                    {
                        Console.WriteLine(item);
                    }

                double publisherPercentageCalc = (Convert.ToDouble(publisherCompared.Count()) / Convert.ToDouble(games2.Count()) * 100);
                double publisherPercentage = Math.Round(publisherPercentageCalc, 2);

                Console.Write($"\nOut of {games2.Count()} games, {publisherCompared.Count()} are devloped by {userPublisher}, which is {publisherPercentage}%.\n");
            }



            //genre data user thingy idk brain dead melting tired

            Console.Write("\nPLease enter a genre: ");
            string userGenre = Console.ReadLine();

            GenreData(userGenre, videogames);

            void GenreData(string userGenre, List<VideoGame> games3)
            {
                IEnumerable<string> genres = games3.Select(x => x.Genre);
                List<string> genres2 = genres.Distinct().ToList();

                IEnumerable<VideoGame> genreCompared = new List<VideoGame>();
                genreCompared = games3.Where(game => game.Genre == userGenre);

                foreach (var item in genreCompared)
                {
                    Console.WriteLine(item);
                }

                double genrePercentageCalc = (Convert.ToDouble(genreCompared.Count()) / Convert.ToDouble(games3.Count()) * 100);
                double genrePercentage = Math.Round(genrePercentageCalc, 2);

                Console.Write($"\nOut of {games3.Count()} games, {genreCompared.Count()} are {userGenre} games, which is {genrePercentage}%.\n");
            }

        }        

    }
}