
using Microsoft.EntityFrameworkCore;
using HarjoitusTyoBackEnd.Models;
using HarjoitusTyoBackEnd.Services;
using HarjoitusTyoBackEnd.Repositories;
using HarjoitusTyoBackEnd.Middleware;
using Microsoft.AspNetCore.Authentication;



    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Konsta Suomalainen
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddDbContext<MessageServiceContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MessageServiceDB")));
         builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
        });

        builder.Services.AddEndpointsApiExplorer();
        
        builder.Services.AddScoped<IMessageService, MessageService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IMessageRepository, MessageRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();
        

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            MessageServiceContext dbcontext = scope.ServiceProvider.GetRequiredService<MessageServiceContext>();
            dbcontext.Database.EnsureCreated();

        }



        // Configure the HTTP request pipeline.


        if (builder.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
        }

        app.UseMiddleware<ApiKeyMiddleware>();
        app.UseAuthentication();
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
        // Konsta Suomalainen
    }
