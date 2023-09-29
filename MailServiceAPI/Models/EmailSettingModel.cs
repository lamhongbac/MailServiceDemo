namespace MailServiceAPI.Models
{
    public class EmailSettingModel
    {
        public EmailSettingModel()
        {
            Code = "SS";
            Mail = "app.sasin@gmail.com";
            DisplayName = "Sasin Việt Nam ";
            Password = "Hello@123";
            Host = "smtp.gmail.com";
            Port = 587;
        }
        public string Code { get; set; } //CompanyCode
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
