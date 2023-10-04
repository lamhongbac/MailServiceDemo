using MailServiceAPI.Interfaces;
using MailServiceAPI.Logic;
using MailServiceAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var mailsettings = builder.Configuration.GetSection("EmailSettings");  // đọc config
builder.Services.Configure<EmailSettingModel>(mailsettings);
// Add services to the container.
builder.Services.AddControllersWithViews();
// Đăng ký SendMailService với kiểu Transient, mỗi lần gọi dịch
// vụ ISendMailService một đới tượng SendMailService tạo ra (đã inject config)
builder.Services.AddTransient<ISendMailService, SendMailService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=SendMailDemo}/{action=SendMail}/{id?}");

app.Run();
