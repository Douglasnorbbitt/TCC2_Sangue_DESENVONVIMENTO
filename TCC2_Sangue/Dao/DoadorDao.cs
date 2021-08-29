using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TCC2_Sangue.Models;

namespace TCC2_Sangue.Dao
{
    public class DoadorDao : DaoBase
    {
        public void Gravar(Doador objDoador)
        {
            banco.Doadores.Add(objDoador);
            banco.SaveChanges();
        }
        public void Alterar(Doador objdoador)
        {
            var entry = banco.Entry(objdoador);
            banco.Set<Doador>().Attach(objdoador);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Doador doador = Buscar(id);
            banco.Doadores.Remove(doador);
            banco.SaveChanges();

        }
        public IList<Doador> Buscar()

        {
            return banco.Doadores.ToList();
        }

        public Doador Buscar(int id)
        {
            return banco.Doadores.FirstOrDefault(a => a.DoadorID == id);
        }

    }
}