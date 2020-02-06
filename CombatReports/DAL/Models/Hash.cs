using CombatReports.DAL.Models.Abstractions;

namespace CombatReports.DAL.Models
{
    public partial class Hash : IEntity
    {
        public int Id { get; set; }
        public byte[] HashValue { get; set; }
    }
}
