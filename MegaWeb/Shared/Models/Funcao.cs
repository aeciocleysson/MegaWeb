namespace MegaWeb.Shared.Models
{
    public class Funcao : BaseModel
    {
        public string Descricao { get;  set; }

        public Funcao(string descricao)
        {
            Descricao = descricao;
        }

        public Funcao()
        {

        }
    }
}