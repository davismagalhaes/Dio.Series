using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set;}

        // Métodos

      
        public Serie(int Id, Genero Genero, string titulo, string descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Excluido = false;

        }
        public override string ToString()
        {
            string retorno  = "";
            retorno += "    Gênero: "+ this.Genero + Environment.NewLine;
            retorno += "    Título: "+ this.Titulo + Environment.NewLine;
            retorno += " Descrição: "+ this.Descricao + Environment.NewLine;
            retorno += "Ano Inicio: "+ this.Ano + Environment.NewLine;
            retorno += "  Excluido: "+ this.Excluido ; 

            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}