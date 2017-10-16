using System;
namespace Baseball
{
    public class DisplayTheTeamUtils
    {
        public static void DisplayTheTeam(Team teamToDisplay ){
            Console.Out.WriteLine("\t\t ===== " + teamToDisplay.GetName().ToUpper() + " =====");
            Console.Out.WriteLine(" ");
            Console.Out.
                   WriteLine("I have " + teamToDisplay.GetPlayers().Count + " players in my team " + teamToDisplay.GetName().ToUpper());

            Console.Out.WriteLine(" ");
            Console.Out.WriteLine(" == Pitchers == ");
            Console.Out.WriteLine("" + teamToDisplay.GetPitchers());

            Console.Out.WriteLine(" ");
            Console.Out.WriteLine(" == Catchers == ");
            Console.Out.WriteLine(teamToDisplay.GetCatchers());

            Console.Out.WriteLine(" ");
            Console.Out.WriteLine(" == Infields == ");
            Console.Out.WriteLine(teamToDisplay.GetInfields());

            Console.Out.WriteLine(" ");
            Console.Out.WriteLine(" == Outfields == ");
            Console.Out.WriteLine(teamToDisplay.GetOutfields());

            Console.Out.WriteLine(" ");
            Console.Out.WriteLine(" == Designated Hitters == ");
            Console.Out.WriteLine(teamToDisplay.GetDesignatedHitters());

            Console.Out.WriteLine(" ");
            Console.Out.WriteLine("The hole team is composed of : " + teamToDisplay);

            Console.Out.WriteLine(" ");
            Console.Out.WriteLine(" ===== We will win the season : " + extractYear() + " ===== ");
        }

        private static int extractYear()
        {
            // The new date
            DateTime currentYear = new DateTime();

            return currentYear.Year;
        }
    }
}