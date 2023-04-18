using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicAndBookStore.Data;
using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Data.Repositories.Repository;
using MusicAndBookStore.Data.Services;
using MusicAndBookStore.Entities;
using MusicAndBookStore.FluentValidation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

//builder.Services.AddAutoMapper(typeof(Program));
//builder.Services.AddAutoMapper(config =>
//{
//    config.CreateMap<PurchasedProductDto, PurchasedProduct>();
//    config.CreateMap<PurchasedProduct, PurchasedProductDto>();
//}, AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMusicAlbumRepository, MusicAlbumRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICampaignRulesService, CampaignService>();

//Validation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidator<Book>, BookValidator>();
builder.Services.AddScoped<IValidator<Movie>, MovieValidator>();
builder.Services.AddScoped<IValidator<MusicAlbum>, MusicAlbumValidator>();




// Add services to the container.

var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
