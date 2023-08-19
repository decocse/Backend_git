using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class LoanCardMaster
    {
        [Key]
        [Column(TypeName = "guid")] public int LoanId { get; set; }
        [Column(TypeName = "varchar(15)")] public required string LoanType { get; set; }
        [Column(TypeName = "int(2)")] public required  int Duration { get; set; }
    }
}
