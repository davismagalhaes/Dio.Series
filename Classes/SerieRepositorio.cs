using System;
using System.Collections.Generic;
using DIO.Series.interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaserie = new List<Serie>();
        public void Atualiza(int Id, Serie objeto)
        {
            listaserie[Id] = objeto;
        }

        public void Exclui(int Id)
        {
            listaserie[Id].Excluir();
        }

        public void Insere(Serie Objeto)
        {
            listaserie.Add(Objeto);
        }

        public List<Serie> Lista()
        {
            return listaserie;
        }

        public int ProximoId()
        {
           return listaserie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
           return listaserie[Id];
        }
    }
}