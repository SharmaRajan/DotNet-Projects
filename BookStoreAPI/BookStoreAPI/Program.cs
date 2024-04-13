﻿using BookStoreAPI.Repository;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Connect to Database
builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);

// alternate way to connect to DB
//builder.Services.AddTransient<MySqlConnection>(_ => { 
    //new MySqlConnection(builder.Configuration.GetConnectionString["Default"]));


builder.Services.AddTransient<IBookRepo, BookRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

