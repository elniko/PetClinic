using System;
using System.Collections.Generic;

namespace Baseball
{
    class MainClass
    {

        static String MLB_LOGO;

        public MainClass()
        {
            MLB_LOGO = "          Boston  Red Sox Baseball  Boston   Red Sox  Baseball \n"
                + "              BA                            SEB                   A \n"
                + "              LL                   S.F.Gia    BAS                 EB \n"
                + "              AL                  LBoston\"    A\'s                 \"B \n"
                + "              AS                 EBALLS.F.G      ia               nt \n"
                + "              sB                  ASEBALLS.       F.G             ia \n"
                + "              BA                   SEBALLOakland\"A\'s\"B            AS \n"
                + "              EB                 ALLS.F.GiantsBASEBALLS.          F. \n"
                + "              Gi   aBA          SEBALLOakland\"A\'s\"BASEBALL        S. \n"
                + "              F.   Gia         ntsBASEBALLS.F.GiaBASEBALLO        ak \n"
                + "               l                 and\"A\'s\"BASEBALLS.F.             Gi \n"
                + "                a                ntsBASEBALLS.F.GiaBA            S\n"
                + "                 S.F. Giants Baseball S.F. Giants Baseball'";
        }
        public static void Main(string[] args)
        {
            // David Ortiz
            String namePlayer1 = "Ortiz";
            String firstNamePlayer1 = "David";
            Player davidOrtiz = new Player();
            davidOrtiz.SetName(namePlayer1);
            davidOrtiz.firstName = firstNamePlayer1;
            davidOrtiz.SetPosition("Designated Hitter");

            // David Price
            String namePlayer2 = "Price";
            String firstNamePlayer2 = "David";
            Player davidPrice = new Player();
            davidPrice.SetName(namePlayer2);
            davidPrice.firstName = firstNamePlayer2;
            davidPrice.SetPosition("Pitcher");

            // David Wells
            String namePlayer3 = "Wells";
            String firstNamePlayer3 = "David";
            Player davidWells = new Player();
            davidWells.SetName(namePlayer3);
            davidWells.firstName = firstNamePlayer3;
            davidWells.SetPosition("Pitcher");

            // R
            Team redSox = new Team("Red Sox", "Boston", "Fenway Park", true);

            // Add David Price, David Ortiz and David Wells
            // We had such a great team now two super famous pitchers! We gonna win
            // the MLB.
            HashSet<Player> allPlayers1 = redSox.AddAPlayerToATeam(redSox.GetPlayers(), davidOrtiz);
            HashSet<Player> allPlayers2 = redSox.AddAPlayerToATeam(allPlayers1, davidPrice);
            HashSet<Player> allPlayers3 = redSox.AddAPlayerToATeam(allPlayers2, davidWells);

            redSox.SetPlayers(allPlayers3);

            // Set the team to the player
            davidPrice.SetCurrentTeam(redSox);
            davidOrtiz.SetCurrentTeam(redSox);
            davidWells.SetCurrentTeam(redSox);

            //TODO: Add Jhon Farrell as a Manager?! How can I do that? Java Is so complicated

            Console.Out.WriteLine(MLB_LOGO);
            Console.Out.WriteLine(" ");

            DisplayTheTeamUtils.DisplayTheTeam(redSox);
        }
    }
}
