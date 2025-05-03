using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuMusicasPorAno : Menu
    {
        public override void Executar(DAL<Musica> musicaDAL)
        {
            base.Executar(musicaDAL);
            ExibirTituloDaOpcao("Exibir músicas por ano de lançamento: ");
            Console.Write("Digite o ano que deseja buscar: ");
            string anoLancamento = Console.ReadLine()!;
            var listaMusicasPorAno = musicaDAL.MusicasPorAno(musica => musica.AnoLancamento == Convert.ToInt32(anoLancamento));
            if (listaMusicasPorAno is not null)
            {
                Console.WriteLine("\nMúsicas lançadas no ano buscado:");
                foreach (var musica in listaMusicasPorAno)
                {
                    musica.ExibirFichaTecnica();
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nNão há nenhuma música cadastrada lançada no ano {anoLancamento}");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
