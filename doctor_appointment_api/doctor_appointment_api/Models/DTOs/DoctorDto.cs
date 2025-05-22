using System.ComponentModel.DataAnnotations;

namespace doctor_appointment_api.Models.DTOs;

public class DoctorDto
{
    [Required]
    public int DoctorId { get; set; }
    
    [Required]
    public string PWZ { get; set; }
}