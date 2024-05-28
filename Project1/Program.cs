using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Project1;
using Project1.Data;
using UseASPNETCoreIdentity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectDbContext")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//wayne:註冊 客製化註冊時的錯誤訊息
builder.Services.AddScoped<IdentityErrorDescriber, CustomIdentityErrorDescriber>();

<<<<<<< HEAD
//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddRoles<IdentityRole>() //wayne:建立角色管理服務
//    .AddEntityFrameworkStores<ApplicationDbContext>();

//Wayne:註冊客製化後的會員資料與權限                               註冊後需要確認其帳戶（通常是通過電子郵件確認）。
builder.Services.AddIdentity<ProjectUser, ApplicationRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders(); //方法註冊一些預設的令牌提供者，用於生成和驗證令牌，例如用於密碼重置、帳戶確認等功能。

=======
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() //wayne:建立角色管理服務
    .AddEntityFrameworkStores<ApplicationDbContext>();
>>>>>>> main

//wayne:註冊EmailSender類別
builder.Services.AddTransient<IEmailSender, EmailSender>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//wayne:Identity相關設定
builder.Services.Configure<IdentityOptions>(options =>
{
    //密碼原則
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 8;
    options.Password.RequiredUniqueChars = 1;
    //鎖定原則(預設關閉)
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.AllowedForNewUsers = true;
    //帳號原則
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedEmail = true;
});
//Coolie設定
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});

//wayne:設定驗證信用
//builder.WebHost.UseUrls("https://localhost:7177");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

//啟動時，通過使用範圍 (scope) 創建角色並將用戶分配給角色
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        var userManager = services.GetRequiredService<UserManager<ProjectUser>>();
        var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
        await SeedData.Initialize(services, userManager, roleManager); // 初始化數據庫並添加角色
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}

app.Run();

