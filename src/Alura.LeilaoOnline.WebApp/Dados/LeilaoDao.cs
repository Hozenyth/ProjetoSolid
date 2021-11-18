using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class LeilaoDao // classe resposavel de acesso aos objetos(responsável por manter as operações) 
   
    {
        AppDbContext _context;

        public LeilaoDao()
        {
            _context = new AppDbContext();
        }


        public IEnumerable<Categoria> BuscarCategorias()// Vai trazer uma lista de categorias, recupera lista
        {
            return _context.Categorias.ToList();
        }

        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes
                .Include(l => l.Categoria)
                .ToList();
        }
        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(l => l.Id == id);
        }
    }
}
