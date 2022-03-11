using Blazored.SessionStorage;
using Blazored.LocalStorage;
using HyperMarket.Client;
using HyperMarket.Data.Interfaces;
using HyperMarket.DB.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerDetailService, CustomerDetailService>();
builder.Services.AddScoped<IBusinessDetailService, BusinessDetailService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IConfigService, ConfigService>();
builder.Services.AddScoped<IFAQsService, FAQsService>();
builder.Services.AddScoped<IOffer, OfferService>();



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
