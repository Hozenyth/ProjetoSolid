using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Leilao> BuscarTodosLeiloes();
        IEnumerable<Categoria> BuscarTodasCategorias();
        Leilao BuscarLeilaoPorId(int id);
        void IncluirLeilao(Leilao leilao);
        void AlterarLeilao(Leilao leilao);
        void ExcluirLeilao(Leilao leilao);

    }
}
