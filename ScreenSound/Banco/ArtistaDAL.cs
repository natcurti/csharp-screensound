using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class ArtistaDAL
{   
    private readonly ScreenSoundContext context = new ScreenSoundContext();

    public ArtistaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<Artista> Listar()
    {
        return context.Artistas.ToList();
    }

    public void AdicionarArtista(Artista artista)
    {
        context.Artistas.Add(artista);
        context.SaveChanges();
    }

    public void AtualizarArtista(Artista artista)
    {
        context.Artistas.Update(artista);
        context.SaveChanges();
    }

    public void DeletarArtista(Artista artista)
    {
        context.Artistas.Remove(artista);
        context.SaveChanges();
    }

    public Artista? RecuperarPeloNome(string nome)
    {
        Artista artistaParaBuscar = context.Artistas.First(artista => artista.Nome == nome);
        return artistaParaBuscar;
    }
}
