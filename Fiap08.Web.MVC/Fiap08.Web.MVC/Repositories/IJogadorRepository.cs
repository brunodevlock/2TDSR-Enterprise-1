using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap08.Web.MVC.Repositories
{
    public interface IJogadorRepository
    {
        void Cadastrar(Jogador jogador);
        void Atualizar(Jogador jogador);
        void Remover(int id);
        Jogador BuscarPorId(int id);
        IList<Jogador> Listar();
        IList<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro);
    }
}
