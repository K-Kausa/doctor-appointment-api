using System.ComponentModel.DataAnnotations;

namespace doctor_appointment_api.Models.DTOs;

public class PatientDto
{
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    [Required]
    public DateTime DateOfBirth { get; set; }
}