using CombatReports.Data.Models.Abstractions;

namespace CombatReports.Data.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
    }
}