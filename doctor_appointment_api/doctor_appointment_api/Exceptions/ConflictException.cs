namespace doctor_appointment_api.Exceptions;

public class ConflictException : Exception
{
    public ConflictException(string message) : base(message)
    {
        
    }
}