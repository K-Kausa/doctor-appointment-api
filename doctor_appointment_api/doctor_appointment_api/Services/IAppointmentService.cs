using doctor_appointment_api.Models.DTOs;

namespace doctor_appointment_api.Services;

public interface IAppointmentService
{
    Task<AppointmentDto> GetAppointment(int id);
    
    Task AddAppointment(AppointmentPostDto appointment);
}