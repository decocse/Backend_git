using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapp.DB.Models
{
    public class ItemDB
    {
        [Key]
        [Column(TypeName = "Guid")] public int ItemId { get; set; }
        [Column(TypeName = "varchar(25)")] public required string ItemDescription { get; set; }
        // [Column(TypeName = "")] public required string ItemName { get; set; } 
        [Column(TypeName = "char(1)")] public required string IssueStatus { get; set; }
        [Column(TypeName = "varchar(25)")] public required string ItemMake { get; set; }
        [Column(TypeName = "varchar(20)")] public required string ItemCategory { get; set; }
        [Column(TypeName = "int(6)")] public required int ItemValue { get; set; }
    }
}
