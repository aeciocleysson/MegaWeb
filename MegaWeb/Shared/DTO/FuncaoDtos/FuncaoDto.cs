using System;

namespace MegaWeb.Shared.DTO.FuncaoDtos
{
    public class FuncaoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Inserted { get; set; }  

        public void Edit(string descricao)
        {
            Descricao = descricao;
        }
    }
}