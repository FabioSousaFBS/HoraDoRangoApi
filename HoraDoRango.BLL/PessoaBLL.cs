using HoraDoRango.BLL.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoraDoRango.Entities;
using HoraDoRango.DAL;
using HoraDoRango.DAL.Infra;

namespace HoraDoRango.BLL
{
    class PessoaBLL : IPessoaBLL
    {
        /// <summary>
        /// Validação dos dados antes de serem consultados
        /// </summary>
        /// <param name="pess_RA"></param>
        /// <returns>Objeto pessoa</returns>
        public async Task<PESSOA> GetPessoaAsync(int pess_RA)
        {
            var pessoaRepository = new PessoaRepository();

            try
            {
                if (pess_RA == 0)
                {
                    throw new Exception("RA não informado!");
                }

                return await pessoaRepository.GetPessoaAsync(pess_RA);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Validação dos dados antes de serem salvos
        /// </summary>
        /// <param name="RA">RA do aluno</param>
        /// <returns>Objeto Pessoa</returns>
        public async Task<PESSOA> PostPessoaAsync(PESSOA pessoa)
        {
            var pessoaRepository = new PessoaRepository();
            try
            {
                if(pessoa.Pess_RA == 0)
                {
                    throw new Exception("RA não informado!");
                }

                return await pessoaRepository.PostPessoaAsync(pessoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Validação dos dados antes de serem atualizados
        /// </summary>
        /// <param name="RA">RA do aluno</param>
        /// <returns>Objeto Pessoa</returns>
        public async Task<bool> PutPessoaAsync(PESSOA pessoa)
        {
            var pessoaRepository = new PessoaRepository();
            try
            {
                if (pessoa.Pess_RA == 0)
                {
                    throw new Exception("RA não informado!");
                }

                return await pessoaRepository.PutPessoaAsync(pessoa);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
