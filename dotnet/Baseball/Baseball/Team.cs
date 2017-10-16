using System;
using System.Collections.Generic;
namespace Baseball
{
    public class Team
    {
        String name;
        String cityLocation;
        String stadiumName;
        Boolean isMajorLeagueTeam;
        HashSet<Player> players;

        public Team(String name, String cityLocation, String stadiumName, Boolean isMajorLeagueTeam)
        {
            this.name = name;
            this.cityLocation = cityLocation;
            this.stadiumName = stadiumName;
            this.isMajorLeagueTeam = isMajorLeagueTeam;
        }

        public String GetName()
        {
            return null;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public String GetCityLocation()
        {
            return cityLocation;
        }

        public void SetCityLocation(String cityLocation)
        {
            this.cityLocation = cityLocation;
        }

        public String GetStadiumName()
        {
            return stadiumName;
        }

        public void SetStadiumName(String stadiumName)
        {
            this.stadiumName = stadiumName;
        }

        public Boolean GetIsMajorLeagueTeam()
        {
            return isMajorLeagueTeam;
        }

        public void SetIsMajorLeagueTeam(Boolean isMajorLeagueTeam)
        {
            this.isMajorLeagueTeam = isMajorLeagueTeam;
        }

        public HashSet<Player> GetPlayers()
        {
            return players;
        }

        public void SetPlayers(HashSet<Player> players)
        {
            this.players = players;
        }

        public HashSet<Player> AddAPlayerToATeam(HashSet<Player> players, Player playerToAdd)
        {
            // All safe man I know my job
            HashSet<Player> playersTmp = players == null ? new HashSet<Player>() : players;
            playersTmp.Add(playerToAdd);
            return playersTmp;
        }


        public override String ToString()
        {
            return "Team [name=" + GetName() + ", cityLocation=" + GetCityLocation() + ", statiumName=" + GetStadiumName()
                    + ", isMajorLeagueTeam=" + GetIsMajorLeagueTeam() + ", players=" + GetPlayers() + " \n]";
        }

        public HashSet<Player> GetPitchers()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "pitcher")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

        public HashSet<Player> GetCatchers()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "catcher")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }


        public HashSet<Player> GetInfields()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "infield")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

        public HashSet<Player> GetOutfields()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "outfield")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

        public HashSet<Player> GetDesignatedHitters()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "designated hitter")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

    }
}

