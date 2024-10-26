using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using mini_package_api.DbContexts;
using mini_package_api.Mappers;
using mini_package_api.Services.Auth;
using mini_package_api.Services.Clients;
using mini_package_api.Services.Employees;
using mini_package_api.Services.Users;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using System.Text.Json.Serialization;
using mini_package_api.Services.Addresses;
using mini_package_api.Services.Countries;
using mini_package_api.Services.Inquires;
using mini_package_api.Services.Notifications;
using mini_package_api.Configuration;
using Quartz;
using mini_package_api.Options;
using mini_package_api.Services.Schedulers.Jobs;
using mini_package_api.Utils;
using mini_package_api.Services.Offers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

// autentykacja JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration.GetSection("Audiences:api").Value, // <- twórca klucza
            ValidAudiences = new List<string>() {
                builder.Configuration.GetSection("Audiences:api").Value,
                builder.Configuration.GetSection("Audiences:gui").Value
            },
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("secretKey").Value))
        };
    });

// Database
builder.Services.AddDbContext<MiniPackageDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:MiniPackageDbConnection").Value);
    // disabling SQL logging
    options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.None)));
});

// Services 
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddTransient<IClientService, ClientService>();
builder.Services.AddTransient<IAddressService, AddressService>();
builder.Services.AddTransient<IInquireService, InquireService>();
builder.Services.AddTransient<IClientService, ClientService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<IClientMapper, ClientMapper>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddSingleton<ILogHelper, LogHelper>();
builder.Services.AddTransient<IOfferService, OfferService>();

builder.Configuration.AddJsonFile("secrets.json", optional: true, reloadOnChange: true);

// Quartz - scheduler
builder.Services.AddQuartz(opt =>
{
    opt.UseMicrosoftDependencyInjectionJobFactory();
    var jobKey = new JobKey("EmailSenderJob");
    opt.AddJob<EmailSenderJob>(options => options.WithIdentity(jobKey));
    opt.AddTrigger(options =>
    {
        options.ForJob(jobKey)
            .WithIdentity("EmailSenderJob-trigger")
            .WithCronSchedule(builder.Configuration.GetSection("EmailSenderJob:CronSchedule")
                .Value ?? "0/10 * * * * ?");
    });
});

builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
builder.Services.Configure<EmailSenderJob>(builder.Configuration.GetSection(EmailSenderOptions.Name));
builder.Services.AddTransient<IOfferService, OfferService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
