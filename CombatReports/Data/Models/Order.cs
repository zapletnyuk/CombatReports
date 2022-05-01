using CombatReports.Data.Models.Abstractions;

namespace CombatReports.Data.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public int UserId { get; set; }
        public int FormId { get; set; }
        public User User { get; set; }
        public Form Form { get; set; }
    }
}
