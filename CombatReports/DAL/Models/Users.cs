using CombatReports.DAL.Models.Abstractions;

namespace CombatReports.DAL.Models
{
    public partial class Users : IEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
    }
}
