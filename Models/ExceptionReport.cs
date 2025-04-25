using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineWebApp1.Models
{
    public class ExceptionReport
    {
        [Key]
        [Column(TypeName = "varchar(14)")]
        public string Id { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 14);

        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; } = string.Empty;

        public int Reply { get; set; }

        [Column(TypeName = "text")]
        public string Report { get; set; } = string.Empty;
    }
}
