using System;
using System.ComponentModel.DataAnnotations;

namespace MegaWeb.Shared.Response
{
    public class FuncaoResponse
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime UpdateAt{ get; set; }
    }
}