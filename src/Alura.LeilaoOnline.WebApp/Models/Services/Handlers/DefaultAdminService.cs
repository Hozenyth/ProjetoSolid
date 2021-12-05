using Alura.LeilaoOnline.WebApp.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Models.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        ILeilaoDao _dao;

        public DefaultAdminService(ILeilaoDao dao)
        {
            _dao = dao;
        }

        public void CadastraLeilao(Leilao leilao)
        {
           _dao.IncluirLeilao(leilao);
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _dao.BuscarTodasCategorias();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _dao.BuscarLeilaoPorId(id);
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            return _dao.BuscarTodosLeiloes();
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarLeilaoPorId(id);
            if(leilao != null && leilao.Situacao == SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Termino = DateTime.Now;
                _dao.AlterarLeilao(leilao);
            }
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarLeilaoPorId(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Inicio = DateTime.Now;
                _dao.AlterarLeilao(leilao);
            }
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _dao.AlterarLeilao(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
            _dao.ExcluirLeilao(leilao);
        }
    }
}
