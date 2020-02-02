using CombatReports.DAL.Models.Abstractions;

namespace CombatReports.DAL.Models
{
    public partial class Orders : IEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    }
}
