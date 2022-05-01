using CombatReports.Data.Models.Abstractions;

namespace CombatReports.Data.Models
{
    public class Form : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FormTypeId { get; set; }
        public FormType FormType { get; set; }
    }
}