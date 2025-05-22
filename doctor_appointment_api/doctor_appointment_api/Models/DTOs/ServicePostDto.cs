using System.ComponentModel.DataAnnotations;

namespace doctor_appointment_api.Models.DTOs;

public class ServicePostDto
{
    [Required]
    public string ServiceName { get; set; }
    [Required]
    public decimal ServiceFee { get; set; }
}