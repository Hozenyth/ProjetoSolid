using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore : ILeilaoDao   // classe resposavel de acesso aos objetos(responsável por manter as operações) 
   
    {
        AppDbContext _context;

        public LeilaoDaoComEfCore()
        {
            _context = new AppDbContext();
        }


        public Leilao BuscarLeilaoPorId(int id)
        {
            return _context.Leiloes.Find(id);
        }

        public IEnumerable<Leilao> BuscarTodosLeiloes() => _context.Leiloes.Include(l => l.Categoria);

        public IEnumerable<Categoria> BuscarTodasCategorias() => _context.Categorias;

        public void IncluirLeilao(Leilao obj)
        {
            _context.Leiloes.Add(obj);
            _context.SaveChanges();
        }

        public void AlterarLeilao(Leilao obj)
        {
            _context.Leiloes.Update(obj);
            _context.SaveChanges();
        }

        public void ExcluirLeilao(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}
