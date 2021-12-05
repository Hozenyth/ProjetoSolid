using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Models.Services
{
    public interface IAdminService
    {
        IEnumerable<Categoria> ConsultaCategorias();
        IEnumerable<Leilao> ConsultaLeiloes();
        Leilao ConsultaLeilaoPorId(int id);
        void CadastraLeilao(Leilao leilao);
        void ModificaLeilao(Leilao leilao);
        void RemoveLeilao(Leilao leilao);
        void IniciaPregaoDoLeilaoComId(int id);
        void FinalizaPregaoDoLeilaoComId(int id);


    }
}
