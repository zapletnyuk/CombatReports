using System;
using System.Collections.Generic;

namespace CombatReports.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    }
}
