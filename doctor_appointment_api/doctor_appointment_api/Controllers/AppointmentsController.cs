using doctor_appointment_api.Exceptions;
using doctor_appointment_api.Models.DTOs;
using doctor_appointment_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace doctor_appointment_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController(IAppointmentService _appointmentService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAppointment(int id)
    {
        try
        {
            var visit = await _appointmentService.GetAppointment(id);
            return Ok(visit);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> AddAppointment([FromBody] AppointmentPostDto appointment)
    {
        if (!appointment.Services.Any())
        {
            return BadRequest("At least one Service is required");
        }
    
        try
        {
            await _appointmentService.AddAppointment(appointment);
        }
        catch (ConflictException e)
        {
            return Conflict(e.Message);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        return CreatedAtAction(nameof(GetAppointment), new { id = appointment.AppointmentId }, appointment);
    }
}