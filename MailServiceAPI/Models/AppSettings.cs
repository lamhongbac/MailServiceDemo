namespace MailServiceAPI.Models
{
    public class AppSettings
    {
        public AppSettings()
        {
            EmailSetting = new EmailSettingModel();
        }
        public EmailSettingModel EmailSetting { get; set; }
    }
}
