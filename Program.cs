var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi); // Learn more about HTTP vs REST API on at https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-vs-rest.html

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // Lambda > Function > <YOUR-LAMBDA-FUNCTION-NAME> > Configuration > Environment Variables then Add: ASPNETCORE_ENVIRONMENT = Development
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
