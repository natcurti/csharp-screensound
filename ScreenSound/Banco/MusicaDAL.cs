using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;
internal class MusicaDAL
{
    private readonly ScreenSoundContext context = new ScreenSoundContext();
    public MusicaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<Musica> Listar()
    {
        return context.Musicas.ToList();
    }

    public void AdicionarMusica(Musica musica)
    {
        context.Musicas.Add(musica);
        context.SaveChanges();
    }

    public void AtualizarMusica(Musica musica)
    {
        context.Musicas.Update(musica);
        context.SaveChanges();
    }

    public void DeletarMusica(Musica musica)
    {
        context.Musicas.Remove(musica);
        context.SaveChanges();
    }

    public Musica? RecuperarPeloNome(string nome)
    {
        Musica musicaParaBuscar = context.Musicas.First(m => m.Nome == nome);
        return musicaParaBuscar;
    }

}
