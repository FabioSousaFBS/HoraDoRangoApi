using HoraDoRango.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoRango.BLL.Infra
{
    public interface IPessoaBLL
    {
        Task<PESSOA> PostPessoaAsync(PESSOA pessoa);
        Task<bool> PutPessoaAsync(PESSOA pessoa);
        Task<PESSOA> GetPessoaAsync(int pess_RA);


    }
}
