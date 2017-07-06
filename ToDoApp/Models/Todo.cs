using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Criado em")]
        public DateTime? DataCriacao { get; set; }

        [Display(Name = "Concluído em")]
        public DateTime? DataConclusao { get; set; }

        [Display(Name = "Concluído?")]
        public bool Status { get; set; }

        public Todo()
        {
            //Valores default
            this.Descricao = "";
            this.Status = false;
        }
    }
}