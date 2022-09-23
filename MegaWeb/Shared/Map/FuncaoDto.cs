using System;

namespace MegaWeb.Shared.Map
{
    public class FuncaoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Inserted { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsDelete { get; set; }

        public FuncaoDto()
        {
            Inserted = DateTime.Now;
        }
        public void Edit(string descricao)
        {
            Descricao = descricao;
        }
    }
}