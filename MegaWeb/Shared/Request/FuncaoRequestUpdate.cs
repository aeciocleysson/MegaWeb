using System;
using System.ComponentModel.DataAnnotations;

namespace MegaWeb.Shared.Request
{
    public class FuncaoRequestUpdate
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [MinLength(2, ErrorMessage = "Descrição deve ter no minimo 2 caracteres")]
        [MaxLength(50, ErrorMessage = "Descrição deve ter no maximo 50 caracteres")]
        public string Descricao { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}