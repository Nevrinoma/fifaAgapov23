namespace fifaAgapov23.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

      
        public int TeamId { get; set; }
        public Team Team { get; set; }


        public CountryEnum Country { get; set; }
    }
}
