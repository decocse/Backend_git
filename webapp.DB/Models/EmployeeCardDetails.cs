using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapp.DB.Models
{
    public class EmployeeCardDetails
    {
        
        [Key][Column (TypeName ="Guid")] public int EmployeeId { get; set; }
   
        [Column(TypeName ="Guid")]public required string LoanId { get; set; }
        [Required][Column(TypeName = "DATE")][DataType(DataType.Date)][DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")] public DateTime CardIssueDate { get; set; }


        //[Column(TypeName ="DATE")]public required string CardIssueDate { get; set; }
    }
}
