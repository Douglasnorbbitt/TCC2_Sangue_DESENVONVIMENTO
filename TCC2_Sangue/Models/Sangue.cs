using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCC2_Sangue.Models
{
    [Table("Sangues")]
    public class Sangue
    {
        public Sangue()
        {
            ListaSangue = new HashSet<Sangue>();
        }

        [Key]
        public int SangueID { get; set; }

        [MaxLength(13)]
        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "O campo Sangue é obrigatório")]
        public string TipoSangue { get; set; }
        public virtual ICollection<Sangue> ListaSangue { get; set; }
        
    }
}