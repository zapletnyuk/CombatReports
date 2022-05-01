using CombatReports.Data.Models.Abstractions;

namespace CombatReports.Data.Models
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
