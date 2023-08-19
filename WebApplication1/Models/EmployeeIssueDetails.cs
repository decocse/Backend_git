using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeIssueDetails
    {
        [Key]
      [Column(TypeName ="Guid")]public int IssueId { get; set; }
      [Column(TypeName = "Guid")] public required int EmployeeId { get; set; }
      [Column(TypeName = "Guid")] public required int LoanId { get; set; }
      //[Column(TypeName = "DATE")] public required string IssueDate { get; set; }
      //[Column(TypeName = "DATE")] public required string ReturnDate { get; set; }
        
    }
}
