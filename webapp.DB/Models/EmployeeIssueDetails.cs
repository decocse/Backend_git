using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapp.DB.Models
{
    public class EmployeeIssueDetails
    {
        [Key]
      [Column(TypeName ="Guid")]public int IssueId { get; set; }
      [Column(TypeName = "Guid")] public required int EmployeeId { get; set; }
      [Column(TypeName = "Guid")] public required int LoanId { get; set; }
      [Required][Column(TypeName = "DATE")][DataType(DataType.Date)][DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")] public DateTime IssueDate { get; set; }
      [Required][Column(TypeName = "DATE")][DataType(DataType.Date)][DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")] public DateTime ReturnDate {get;set; }


        //[Column(TypeName = "DATE")] public required string IssueDate { get; set; }
        //[Column(TypeName = "DATE")] public required string ReturnDate { get; set; }

    }
}
