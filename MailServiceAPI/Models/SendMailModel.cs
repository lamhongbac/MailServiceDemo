namespace MailServiceDemo.Models
{
    public class SendMailModel
    {
        public SendMailModel()
        {
            CompanyCode = "SS";
        }
        public string CompanyCode { get; set; }              // Địa chỉ gửi đến
        public string To { get; set; }              // Địa chỉ gửi đến
        public string Subject { get; set; }         // Chủ đề (tiêu đề email)
        public string Body { get; set; }            // Nội dung (hỗ trợ HTML) của email

    }
}
