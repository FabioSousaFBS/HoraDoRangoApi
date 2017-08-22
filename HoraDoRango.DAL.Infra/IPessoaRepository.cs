using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoraDoRango.Entities;

namespace HoraDoRango.DAL.Infra
{
    public interface IPessoaRepository
    {
        Task<PESSOA> PostPessoaAsync(PESSOA pessoa);
        Task<bool> PutPessoaAsync(PESSOA pessoa);
        Task<PESSOA> GetPessoaAsync(int Pess_RA);

    }
}
