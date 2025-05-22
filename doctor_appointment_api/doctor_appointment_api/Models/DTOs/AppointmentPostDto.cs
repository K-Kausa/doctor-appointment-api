using System.ComponentModel.DataAnnotations;

namespace doctor_appointment_api.Models.DTOs;

public class AppointmentPostDto
{
    [Required]
    public int AppointmentId { get; set; }
    
    [Required]
    public int PatientId { get; set; }
    
    [Required]
    public string PWZ { get; set; }
    
    [Required]
    public List<ServicePostDto> Services { get; set; }
}