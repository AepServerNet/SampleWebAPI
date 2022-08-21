namespace SampleWebAPI.NET6.Models.Entities
{
    public class Person : Entity<int>
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
