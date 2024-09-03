namespace lab_03.BL.Models
{
    public class Feedback
    {
        private int id;
        private int grade;
        private int idLeague;

        public Feedback(int grade, int id_league, int id = 1)
        {
            this.id = id;
            this.grade = grade;
            this.idLeague = id_league;
        }

        public int Id { get => id; set => id = value; }
        public int Grade { get => grade; set => grade = value; }
        public int IdLeague { get => idLeague; set => idLeague = value; }
    }
}