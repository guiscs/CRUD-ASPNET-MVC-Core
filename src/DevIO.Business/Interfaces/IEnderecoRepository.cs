using Catalogo.Business.Models;
using System;
using System.Threading.Tasks;

namespace Catalogo.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
