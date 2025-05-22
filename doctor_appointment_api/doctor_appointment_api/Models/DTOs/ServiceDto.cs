using System.ComponentModel.DataAnnotations;

namespace doctor_appointment_api.Models.DTOs;

public class ServiceDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public decimal ServiceFee { get; set; }
}