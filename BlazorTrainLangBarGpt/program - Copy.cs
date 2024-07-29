//using BlazorTrainLangBarGpt.Components;
//using Microsoft.AspNetCore.Localization;
//using System.Globalization;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorComponents()
//    .AddInteractiveServerComponents();

//// just ref:
////services.AddScoped<IRefreshService, RefreshService>();
////builder.Services.AddRazorPages();
////builder.Services.AddServerSideBlazor();
////builder.Services.AddHttpClient();
////builder.Services.AddMemoryCache(); // Add memory cache service
////builder.Services.AddControllers();

//// MHM
//builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
//builder.Services.AddControllers();
//builder.Services.Configure<RequestLocalizationOptions>(options =>
//{
//    // define the list of cultures your app will support
//    var supportedCultures = new List<CultureInfo>()
//                {
//                    new CultureInfo("tr-TR"),
//                    new CultureInfo("fa-IR"),
//                    new CultureInfo("en-US")
//                };

//    // set the default culture
//    options.DefaultRequestCulture = new RequestCulture("fa-IR");
//    options.SetDefaultCulture("fa-IR");
//    options.SupportedCultures = supportedCultures;
//    options.SupportedUICultures = supportedCultures;
//});
////MHM added: end

//var app = builder.Build();

//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error", createScopeForErrors: true);
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseAntiforgery();
//app.UseDefaultFiles(); //MHM added
//app.UseStaticFiles();  //MHM added
////app.UseRouting();
////app.MapBlazorHub();
////app.MapFallbackToPage("/_Host");

//app.MapRazorComponents<App>()
//    .AddInteractiveServerRenderMode();

//app.Run();