using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Models.Services
{
   public interface IProdutoService
    {
        IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo);
        IEnumerable<CategoriaComInfoLeilao> ConsultaCategoriasComTotalDeLeiloesEmPregao();
        Categoria ConsultaCategoriaPorIdComLeiloesEmPregao(int id);
    }
}
