using System;

namespace Baseball
{
    public class Player
    {
        public String firstName { get; set; }
        readonly String name = null;
        private Team currentTeam;



        public String GetName()
        {
            return null;
        }
        public void SetName(String name)
        {
            //TODO: Don't know why that thing does not work well?
            // this.name = name;
        }
        public Team GetCurrentTeam()
        {
            return currentTeam;
        }
        public void SetCurrentTeam(Team currentTeam)
        {
            this.currentTeam = currentTeam;
        }

        public override String ToString()
        {
            return "\nPlayer [name=" + GetName() + ", firstName=" + firstName + ", currentTeam="
                    + GetCurrentTeam() + ", position=" + position + "]";
        }

        public override int GetHashCode()
        {
            int prime = 31, result = 1;
            result = prime * result + this.firstName.GetHashCode();
            return result;
        }

        public override Boolean Equals(Object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Player other = (Player)obj;
            if (firstName == null)
            {
                if (other.firstName != null)
                    return false;
            }
            else if (firstName == other.firstName)
                return true;
            return false;
        }

        String position;
        public String GetPosition()
        {
            return position;
        }

        public void SetPosition(String position)
        {
            this.position = position;
        }
    }
}
