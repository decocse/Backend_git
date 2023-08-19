using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.DB.Models
{
    public class EmployeeMaster
    {
        [Key]
        [Column(TypeName = "Guid")] public int EmployeeId { get; set; }
        [Column(TypeName = "varchar(20)")] public required string EmployeeName { get; set; }
        [Column(TypeName = "varchar(25)")] public required string Designation { get; set; }
        [Column(TypeName ="varchar(25)")] public required string Department { get; set; }
        [Column(TypeName = "char(1)")] public required string Gender { get; set; }
        [Required][Column(TypeName = "DATE")][DataType(DataType.Date)][DisplayFormat(DataFormatString ="{0:yyyy-MM-dd")] public DateTime DateOfJoining { get; set; }
        //[NotMapped][Column(TypeName = "DATE")][DataType(DataType.Date)][DisplayFormat(DataFormatString ="{0:yyyy-MM-dd")] public DateTime DateOfJoining { get; set; }
        [Required][Column(TypeName = "DATE")][DataType(DataType.Date)][DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")] public DateTime DateOfBirth { get; set; }



    }
}