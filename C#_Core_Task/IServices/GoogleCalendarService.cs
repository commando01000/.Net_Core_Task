using C__Core_Task.DTO;
using Google.Apis.Calendar.v3.Data;

namespace C__Core_Task.IServices
{
    public interface IGoogleCalendarService
    {
        string GetAuthCode();
        
        Task<GoogleTokenResponse> GetTokens(string code);
        string AddToGoogleCalendar(GoogleCalendarReqDTO googleCalendarReqDTO);
    }
}
