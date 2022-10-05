using System;

namespace MegaWeb.Shared.DTO
{
    public class FuncaoDtoUpdate
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime UpdateAt { get; set; }

        public FuncaoDtoUpdate()
        {
            UpdateAt = DateTime.Now;
        }
    }
}