using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FTSD2.Domain
{
    public class Logs
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public string Notes { get; set; }
        public Guid? LogTypeId { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }
        [StringLength(450)]
        public string TableName { get; set; }


        [ForeignKey(nameof(LogTypeId))]
        [InverseProperty(nameof(LogTypes.Logs))]
        public virtual LogTypes LogType { get; set; }
    }
}
