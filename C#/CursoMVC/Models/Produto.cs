using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models {
    public class Produto {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public int categoriaId { get; set; }
        public Categoria categoria { get; set; }

    }
}
