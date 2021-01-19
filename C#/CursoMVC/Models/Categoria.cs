using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models{
    public class Categoria{
        public int id { get; set; }
        public string descricao { get; set; }
        [Display(Name = "Descrição")]
        public List<Produto> Produtos { get; set; }
    }
}
