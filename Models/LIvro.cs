using Chapter.Contexts;
using Chapter.Repositories;

var builder = WebApplication.CreateBuilder(args);
//Add web services to the container
builder.Services.AddControllers();

builder.Services.AddScoped<ChapterContext, ChapterContext>();

builder.Services.AddTransient<LivroRepository, LivroRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

{
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }    
        public int QtdPaginas { get; set; }
        public bool Disponivel { get; set; }
    }
}