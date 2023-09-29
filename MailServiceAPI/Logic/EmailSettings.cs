using MailServiceAPI.Models;

namespace MailServiceAPI.Logic
{
    public class EmailSettings
    {
        public EmailSettings()
        {
            EmailSettingModels = new List<EmailSettingModel>();
        }
        public List<EmailSettingModel> EmailSettingModels { get; set; } 
    }
}
