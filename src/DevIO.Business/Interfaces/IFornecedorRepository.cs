using Catalogo.Business.Models;
using System;
using System.Threading.Tasks;

namespace Catalogo.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);

        Task<Fornecedor> ObterFornecedorProdutoEndereco(Guid id);
    }
}
