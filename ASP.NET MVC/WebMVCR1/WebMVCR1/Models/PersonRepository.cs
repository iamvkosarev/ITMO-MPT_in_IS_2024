namespace WebMVCR1.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();

        public int NumberOfPerson => persons.Count;

        public IEnumerable<Person> GetAllResponses => persons;

        public void AddResponse(Person response)
        {
            persons.Add(response);
        }
    }
}
