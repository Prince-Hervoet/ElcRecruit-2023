using Serilog;
using System.Text;
using interviewer.Data;
using interviewer.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Information("Starting web application");

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", policyBuilder =>
    {
        policyBuilder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    }));

    builder.Services.AddHttpClient();

    builder.Services.AddControllers();
    builder.Services.AddRazorPages();

    builder.Services.AddDbContext<InterviewerDbContext>();
    builder.Services.AddIdentityCore<InterviewerUser>().AddRoles<IdentityRole>().AddSignInManager().AddEntityFrameworkStores<InterviewerDbContext>();

    var jwtSettings = builder.Configuration.GetSection(nameof(JwtSettings)).Get<JwtSettings>();
    if (jwtSettings is null)
        throw new Exception("JwtSettings is null");
    builder.Services.AddSingleton(jwtSettings);
    
    var messageSettings = builder.Configuration.GetSection(nameof(MessageSettings)).Get<MessageSettings>();
    if(messageSettings is null)
        throw new Exception("MessageSettings is null");

    builder.Services.AddSingleton(messageSettings);

    builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

    builder.Services.AddScoped<IUserService<InterviewerUser>, UserService>();

    //TODO: 非测试环境下更改！！
    builder.Services.AddScoped<IMessageService, FakeMessageService>();

    var tokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.SecurityKey)),
        ClockSkew = TimeSpan.Zero,
    };

    builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
        .AddJwtBearer(options => { options.TokenValidationParameters = tokenValidationParameters; });

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Interviewer.Api",
            Version = "v1",
            Description = "Interviewer.Api Swagger Doc"
        });
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = "Input the JWT like: Bearer {your token}",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            BearerFormat = "JWT",
            Scheme = "Bearer"
        });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
    });

    builder.Host.UseSerilog();

    var app = builder.Build();

    app.UseSerilogRequestLogging();

    // Configure the HTTP request pipeline.
    // if (app.Environment.IsDevelopment())
    // {
    //     app.UseSwagger();
    //     app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Interviewer.Api v1"));
    // }

    //TODO: 发布时移除！！
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Interviewer.Api v1"));
    //TODO: 发布时移除！！

    app.UseHttpsRedirection();

    app.MapControllers();

    app.MapRazorPages();

    app.UseRouting();

    app.UseCors("CorsPolicy");

    app.UseAuthentication();

    app.UseAuthorization();

    // app.MapDefaultControllerRoute().RequireAuthorization();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
