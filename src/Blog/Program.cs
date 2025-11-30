var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureOptions<FilePostServiceOptionsSetup>();
builder.Services.AddSingleton<IFileSystem, FileSystem>();
builder.Services.AddScoped<IPostService, FilePostService>();

builder.Services.AddRazorComponents()
   .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
   app.UseExceptionHandler("/Error", createScopeForErrors: true);
   app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();