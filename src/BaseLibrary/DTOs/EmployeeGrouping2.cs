using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.DTOs
{
    public class EmployeeGrouping2
    {
        [Required]
        public string JobName { get; set; } = string.Empty;
        [Required, Range(1, 9999, ErrorMessage = "You must select branch")]
        public int BranchId { get; set; }   
        public int DepartmentId { get; set; }
        public int GeneralDepartmentId { get; set; }
        [Required, Range(1, 9999, ErrorMessage = "You must select town")]
        public int TownId { get; set; } 
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string? Other { get; set; }
    }
}
