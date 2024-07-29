using System.Text.Json.Serialization;

namespace ServeBooks.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public byte[]? Password { get; set; }
        public DateTime? RegistrationDate { get; set; }
        [JsonIgnore]
        public ICollection<Loan>? Loans { get; set; }
    }
}