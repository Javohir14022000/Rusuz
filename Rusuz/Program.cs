using Rusuz.Brokers.Storages;
using Rusuz.Services.Foundations.Categories;
using Rusuz.Services.Foundations.Sektions;
using Rusuz.Services.Foundations.Words;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        builder.Services.AddTransient<IStorageBroker, StorageBroker>();

        builder.Services.AddTransient<ICategoryService, CategoryService>();

        builder.Services.AddTransient<ISectionService, SectionService>();

        builder.Services.AddTransient<IWordService, WordService>();

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}