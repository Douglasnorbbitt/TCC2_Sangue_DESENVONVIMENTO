using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TCC2_Sangue.Models;

namespace TCC2_Sangue.Dao
{
    public class SangueDao : DaoBase
    {
        public void Gravar(Sangue objSangue)
        {
            banco.Sangues.Add(objSangue);
            banco.SaveChanges();
        }

        public void Alterar(Sangue objSangue)
        {
            var entry = banco.Entry(objSangue);
            banco.Set<Sangue>().Attach(objSangue);
            entry.State = EntityState.Modified;
            banco.SaveChanges();

        }

        public void Excluir(int id)
        {
            Sangue sangue = Buscar(id);
            banco.Sangues.Remove(sangue);
            banco.SaveChanges();

        }

        public IEnumerable<Sangue> Buscar()
        {
            return banco.Sangues.ToList();
        }

        public Sangue Buscar(int id)
        {
            return banco.Sangues.FirstOrDefault(a => a.SangueID == id);
        }
    }
}
    