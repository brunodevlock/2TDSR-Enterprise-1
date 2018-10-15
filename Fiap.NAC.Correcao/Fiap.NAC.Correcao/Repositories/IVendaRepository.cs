using Fiap.NAC.Correcao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.NAC.Correcao.Repositories
{
    public interface IVendaRepository
    {
        void Cadastrar(Venda venda);
        void Atualizar(Venda venda);
        IList<Venda> Listar();
        IList<Venda> BuscarPor(Expression<Func<Venda, bool>> filtro);
    }
}
