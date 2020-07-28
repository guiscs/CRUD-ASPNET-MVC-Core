using Catalogo.Business.Interfaces;
using Catalogo.Business.Models;
using Catalogo.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Catalogo.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking().SingleOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
