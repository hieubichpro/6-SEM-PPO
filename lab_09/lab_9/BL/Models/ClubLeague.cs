namespace lab_03.BL.Models
{
    public class ClubLeague
    {
        private int id;
        private int idClub;
        private int idLeague;


        public ClubLeague(int idClub, int idLeague, int id = 1)
        {
            this.Id = id;
            this.IdClub = idClub;
            this.IdLeague = IdLeague;
        }

        public int Id { get => id; set => id = value; }
        public int IdClub { get => idClub; set => idClub = value; }
        public int IdLeague { get => idLeague; set => idLeague = value; }
    }
}
