﻿using ConsoleApp;
using ConsoleApp.Contexts;
using ConsoleApp.Repositories;
using ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kusht\Desktop\ConsoleApp\ConsoleApp\Data\Local_Database.mdf;Integrated Security=True;Connect Timeout=30"));

    services.AddScoped<AddressRepository>();
    services.AddScoped<CategoryRepository>();
    services.AddScoped<RoleRepository>();
    services.AddScoped<ProductRepository>();
    services.AddScoped<CustomerRepository>();

    services.AddScoped<AddressService>();
    services.AddScoped<CategoryService>();
    services.AddScoped<RoleService>();
    services.AddScoped<ProductService>();
    services.AddScoped<CustomerService>();


    services.AddSingleton<ConsoleUI>();

}).Build();

var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();
//consoleUI.CreateProduct_UI();
//consoleUI.GetProduct_UI();
//consoleUI.UpdateProduct_UI();
//consoleUI.DeleteProduct_UI();

//consoleUI.CreateCustomer_UI();
//consoleUI.GetCustomer_UI();
//consoleUI.UpdateCustomer_UI();
//consoleUI.DeleteCustomer_UI();
