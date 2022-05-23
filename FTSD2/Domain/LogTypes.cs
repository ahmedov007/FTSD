using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FTSD2.Domain
{
    public class LogTypes
    {
        public LogTypes()
        {
            Logs = new HashSet<Logs>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string NameArabic { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        [InverseProperty("LogType")]
        public virtual ICollection<Logs> Logs { get; set; }
    }
}
