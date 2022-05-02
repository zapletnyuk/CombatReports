using CombatReports.Data.Models.Abstractions;

namespace CombatReports.Data.Models
{
    public class Hash : IEntity
    {
        public int Id { get; set; }
        public byte[] Key { get; set; }
        public byte[] Vector { get; set; }
    }
}