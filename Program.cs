namespace CSCI2910_Lab1
{
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

            //Choose a publisher (e.g., Nintendo) from the dataset and create a list of games from that developer from the list created in the first step. Then sort that list alphabetically and display each item inside.
            Console.Write("PLease enter a publisher: ");
            string userPublisher = Console.ReadLine();

            static List<VideoGame> SortByPublisher(string userPublisher, List<VideoGame> videogames)
            {
                string givenPublishers = Convert.ToString(videogames[4]);

                List<VideoGame> publisherCompared = new List<VideoGame>();

                foreach (var item in publisherCompared)
                {
                    videogames.Where(publisher => givenPublishers == userPublisher);
                    publisherCompared.Add(item);
                }

                return publisherCompared;
            }


            //For whichever publisher you chose, calculate and display the percentage of games that belong to that genre as well as how to many games are from that developer out of the total (e.g., “Out of 500 games, 400 are developed by Nintendo, which is 80%”) -- Make sure your percentage only has 2 decimal places when output

            //Choose a genre (e.g., Role-Playing) and create a list of games of that genre from the list created in the first step. Then sort that list alphabetically and display each item inside.

        }
    }
}