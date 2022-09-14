﻿using System;
using System.ComponentModel;

namespace MegaWeb.Shared.Models
{
    public class LogPonto : BaseModel
    {
        public enum ELog : int
        {
            [Description("Iniciou os trabalhos")]
            InicioTrabalho = 1,

            [Description("Saiu para o almoço/intervalo")]
            SaidaAlmoco = 2,

            [Description("Retonou do almoço/intervalo")]
            RetornoAlmoco = 3,

            [Description("Finalizou os trabalhos")]
            FinalizouTrabalho = 4,

            [Description("Trabalhado/Lançamento manual")]
            PontoManual = 5,

            [Description("Trabalhado")]
            Trabalhado = 6,

            [Description("Atestado médico")]
            Atestado = 7,

            [Description("Faltou")]
            Faltou = 8
        }

        public int StatusLogId { get; private set; }
        public int FuncionarioId { get; private set; }
        public Funcionario Funcionario { get; set; }

        public LogPonto()
        {
        }

        public LogPonto(int statusLogId, int funcionarioid, DateTime inserted)
        {
            StatusLogId = statusLogId;
            FuncionarioId = funcionarioid;
            Inserted = inserted;
        }
    }
}