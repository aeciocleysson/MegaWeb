﻿using System;

namespace MegaWeb.Shared.Models
{
    public class Funcionario : BaseModel
    {
        public string Nome { get; private set; }
        public long Matricula { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int SituacaoFuncionarioId { get; private set; }
        public int FuncaoId { get; private set; }
        public Funcao Funcao { get; set; }
        public SituacaoFuncionario SituacaoFuncionario { get; set; }

        public Funcionario(string nome, long matricula, DateTime dataNascimento, int situacaoFuncionarioId, int funcaoId)
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            SituacaoFuncionarioId = situacaoFuncionarioId;
            FuncaoId = funcaoId;
        }

        public void Update(string nome, DateTime dataNascimento, int situacaoFuncionarioId, int funcaoId)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            SituacaoFuncionarioId = situacaoFuncionarioId;
            FuncaoId = funcaoId;
            UpdateAt = DateTime.Now;
        }

        public void Delete(bool isDelete)
        {
            IsDelete = isDelete;
            UpdateAt = DateTime.Now;
        }
    }
}