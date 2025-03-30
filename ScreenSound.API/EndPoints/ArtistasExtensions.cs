using Microsoft.AspNetCore.Mvc;
using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.API.EndPoints
{
    public static class ArtistasExtensions
    {
        public static void AddEndpointsArtistas(this WebApplication app)
        {
            app.MapGet("/Artistas", ([FromServices] DAL<Artista> dal) =>
            {
                return Results.Ok(dal.Listar());
            });

            app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
            {
                var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
                if (artista == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(artista);
            });

            app.MapPost("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] Artista artista) =>
            {
                dal.Adicionar(artista);
                return Results.Ok();
            });

            app.MapDelete("/Artistas/{id}", ([FromServices] DAL<Artista> dal, int id) =>
            {
                var artista = dal.RecuperarPor(a => a.Id == id);
                if (artista == null)
                {
                    return Results.NotFound();
                }
                dal.Deletar(artista);
                return Results.NoContent();
            });

            app.MapPut("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] Artista artista) =>
            {
                var artistaExistente = dal.RecuperarPor(a => a.Id == artista.Id);
                if (artistaExistente == null)
                {
                    return Results.NotFound();
                }
                if (string.IsNullOrWhiteSpace(artista.Nome))
                {
                    return Results.BadRequest("O nome do artista não pode ser nulo ou vazio.");
                }

                artistaExistente.Nome = artista.Nome;
                artistaExistente.Bio = artista.Bio;
                artistaExistente.FotoPerfil = artista.FotoPerfil;

                dal.Atualizar(artistaExistente);
                return Results.Ok();
            });
        }
    }
}
