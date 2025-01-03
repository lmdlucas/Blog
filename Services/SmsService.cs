using Blog.ViewModels.Accounts;

namespace Blog.Services
{
    public class SmsService
    {
        public async Task<bool> SendSms(SmsViewModel sms)
        {
            var http = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8000")
            };
            
            try
            {
                var response = await http.PostAsJsonAsync("/zdg-message", sms);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
