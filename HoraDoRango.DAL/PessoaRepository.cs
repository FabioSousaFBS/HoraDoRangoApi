using HoraDoRango.DAL.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoraDoRango.Entities;
using System.Data.Entity;

namespace HoraDoRango.DAL
{
    public class PessoaRepository : IPessoaRepository
    {
        public async Task<PESSOA> GetPessoaAsync(int Pess_RA)
        {
            try
            {
                using (HoraDoRangoDbContext db = new HoraDoRangoDbContext())
                {
                    return await db.Pessoa.Where(x => x.Pess_RA.Equals(Pess_RA)).FirstOrDefaultAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Message: " + ex.Message + Environment.NewLine + "InnerException: " + ex.InnerException);
            }
        }

        public async Task<PESSOA> PostPessoaAsync(PESSOA PESSOA)
        {
            try
            {
                using (HoraDoRangoDbContext db = new HoraDoRangoDbContext())
                {
                    db.Pessoa.Add(PESSOA);
                    await db.SaveChangesAsync();
                    return PESSOA;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Message: " + ex.Message + Environment.NewLine + "InnerException: " + ex.InnerException);
            }
        }

        public async Task<bool> PutPessoaAsync(PESSOA pessoa)
        {
            try
            {
                using (HoraDoRangoDbContext db = new HoraDoRangoDbContext())
                {
                    // forma 1
                    var obj = db.Pessoa.Where(x => x.Pess_RA == 0).FirstOrDefault();
                    obj.Pess_nome = "BRUNO";

                    // forma 2
                    //db.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Message: " + ex.Message + Environment.NewLine + "InnerException: " + ex.InnerException);
            }
        }
    }
}
