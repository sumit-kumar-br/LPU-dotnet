using JWTAuthentication.Authentication; // Access ApplicationUser and authentication-related classes
using Microsoft.AspNetCore.Authentication.JwtBearer; // Enables JWT token-based authentication
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity; // Provides ASP.NET Identity features like users and roles
using Microsoft.EntityFrameworkCore; // Allows use of Entity Framework Core for database operations
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens; // Used for validating and signing JWT tokens
using System.Text; // Used to convert JWT secret key into byte format

var builder = WebApplication.CreateBuilder(args);

// Registers controllers so the application can handle API requests
builder.Services.AddControllers();

// Registers the database context and connects it to SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));

// Adds ASP.NET Identity services for user management and role management
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// Configures authentication settings for the application
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; // Sets JWT as the default authentication method
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; // Determines how unauthorized requests are handled
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme; // Sets the default scheme used for authentication
})

// Configures JWT token validation rules
.AddJwtBearer(options =>
{
    options.SaveToken = true; // Saves the token in the authentication properties
    options.RequireHttpsMetadata = false; // Allows token validation without HTTPS (commonly used in development)
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true, // Ensures the token was issued by a trusted issuer
        ValidateAudience = true, // Ensures the token is intended for the correct audience
        ValidAudience = builder.Configuration["JWT:ValidAudience"], // Specifies the valid audience from configuration
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"], // Specifies the valid issuer from configuration
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"])) // Secret key used to verify the token signature
    };
});

var app = builder.Build();

// Shows detailed error information during development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Enables routing so requests can be matched to endpoints
app.UseRouting();

// Activates authentication middleware to validate JWT tokens
app.UseAuthentication();

// Applies authorization rules to protected endpoints
app.UseAuthorization();

// Maps controller endpoints to handle HTTP requests
app.MapControllers();

// Starts the application
app.Run();