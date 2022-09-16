using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;

namespace Project1.EntityFramework.Core.Models;

[Table("QV_REPORT")]
public class QV_Report:IEntity
{
    [Column("REPORT_ID")]
    [Key]
    public long Id { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }
}