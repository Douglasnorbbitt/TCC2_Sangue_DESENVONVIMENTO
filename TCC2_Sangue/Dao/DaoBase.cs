using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC2_Sangue.Context;

namespace TCC2_Sangue.Dao
{
    public class DaoBase
    {
        protected readonly DataContext banco;

        public DaoBase()
        {
            banco = new DataContext();
        }
        public void Dispose()
        {
            banco.Dispose();
        }
    }
}