using System;

namespace MegaWeb.Shared.DTO.FuncaoDtos
{
    public class FuncaoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Inserted { get; set; }

        //public FuncaoDto()
        //{
        //    Inserted = DateTime.Now;
        //}

        public void Edit(string descricao)
        {
            Descricao = descricao;
        }
    }
}