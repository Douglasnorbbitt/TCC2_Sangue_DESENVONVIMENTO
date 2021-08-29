using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCC2_Sangue.Models
{
    [Table("Doadores")]
    public class Doador
    {
        public int DoadorID { get; set; }

        [Display(Name = "Tipo Sanguineo")]
        public int SangueID { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [MaxLength(14)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        
        [Display(Name = "Sangue")]
        public string Sangue { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        public virtual Sangue ObjSangue { get; set; }

        public virtual ICollection<Sangue> ListaSangue { get; set; }
    }
}