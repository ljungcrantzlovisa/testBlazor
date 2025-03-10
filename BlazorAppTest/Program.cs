using BlazorAppTest.Components;
using BlazorAppTest.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorComponents(); 


builder.Services.AddSingleton<IStudentService, StudentService>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>();

app.Run();
