using System;

namespace dio.filmes
{
    public class Serie:EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string Pais { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano, string pais)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Pais = pais;
            this.Excluido = false;
        }

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "País de Origem: " + this.Pais + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
			return retorno;
		}
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public void Exluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}
