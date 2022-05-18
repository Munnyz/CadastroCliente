using DioSeries;
using System;

namespace DioSeries
{
    public class Cliente : EntidadeBase
    {
        private int dtn;
        private string nome;
        private string cpf;
        private string mae;
        private string end;

        public Cliente(int id, string nome, string cpf, int dtn, string mae, string end)
        {
            Id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.dtn = dtn;
            this.mae = mae;
            this.end = end;
        }

        public override string ToString()
            {
                string retorno = "";

                retorno += "Nome = " + this.nome + Environment.NewLine;
                retorno += "CPF = " + this.cpf + Environment.NewLine;
                retorno += "Data de Nascimento = " + this.dtn + Environment.NewLine;
                retorno += "Nome da Mãe = " + this.mae + Environment.NewLine;
                retorno += "Endereço = " + this.end + Environment.NewLine;

            return retorno;
            }

            public string retornaTitulo()
            {
                return this.nome;
            }
            public int retornaId()
            {
                return this.Id;
            }

    }
}