using System.ComponentModel.DataAnnotations;

namespace MegaWeb.Shared.DTO.Status
{
    public class StatusLancamentoPontoDto
    {
        [Required(ErrorMessage ="Descrição é obrigatório")]
        [StringLength(60, ErrorMessage = "Descricao deve ter no maximo {1} caracteres.")]
        public string Descricao { get; set; }
    }
}
