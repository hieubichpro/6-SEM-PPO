namespace lab_03.BL.Models
{
    public class Match
    {
        private int id;
        private int goalHomeTeam;
        private int goalGuestTeam;
        private int idLeague;
        private int idHomeTeam;
        private int idGuestTeam;
        public Match(int idLeague, int idHomeTeam, int idGuestTeam, int goalHomeTeam = -1, int goalGuestTeam = -1, int id = 1)
        {
            this.id = id;
            this.goalHomeTeam = goalHomeTeam;
            this.goalGuestTeam = goalGuestTeam;
            this.idLeague = idLeague;
            this.idHomeTeam = idHomeTeam;
            this.idGuestTeam = idGuestTeam;
        }

        public int Id { get => id; set => id = value; }
        public int GoalHomeTeam { get => goalHomeTeam; set => goalHomeTeam = value; }
        public int GoalGuestTeam { get => goalGuestTeam; set => goalGuestTeam = value; }
        public int IdLeague { get => idLeague; set => idLeague = value; }
        public int IdHomeTeam { get => idHomeTeam; set => idHomeTeam = value; }
        public int IdGuestTeam { get => idGuestTeam; set => idGuestTeam = value; }
    }
}