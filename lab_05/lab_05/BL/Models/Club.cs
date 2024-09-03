namespace lab_03.BL.Models
{
    public class Club
    {
        private int id;
        private string name;

        public Club(string name, int id = 1)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}