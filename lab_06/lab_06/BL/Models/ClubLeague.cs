namespace lab_03.BL.Models
{
    public class ClubLeague
    {
        private int id;
        private int idClub;
        private int idLeague;

        public int IdClub { get => idClub; set => idClub = value; }
        public int IdLeague { get => idLeague; set => idLeague = value; }
        public int Id { get => id; set => id = value; }

        public ClubLeague(int idClub, int idLeague, int id = 1)
        {
            this.Id = id;
            this.idClub = idClub;
            this.idLeague = idLeague;
        }
    }
}
