
namespace IEnumerableExercise
{
    internal class User
    {
        public User(int id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
