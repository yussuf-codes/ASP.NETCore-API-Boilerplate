using Scalar.AspNetCore;

namespace API;

public static class Program
{
	public static async Task Main()
	{
		WebApplicationBuilder builder = WebApplication.CreateBuilder();

		builder.Services.AddControllers();
		builder.Services.AddOpenApi();

		WebApplication app = builder.Build();

		if (app.Environment.IsDevelopment())
		{
			app.MapOpenApi();
			app.MapScalarApiReference();
		}

		if (app.Environment.IsProduction())
			app.UseHttpsRedirection();

		app.MapControllers();

		await app.RunAsync();
	}
}
