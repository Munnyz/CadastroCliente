using System;
using System.Collections.Generic;
using DioSeries.Interfaces;

namespace DioSeries
{
    public class CliRepositorio : IRepositorio<Cliente>
    {
        private List<Cliente> listacliente = new List<Cliente>();
        public void Atualiza(int id, Cliente objeto)
        {
            listacliente[id] = objeto;
        }
        public void Excluir(int id)
        {
            listacliente[id].Excluir();
        }
        public void Insere(Cliente objeto)
        {
            listacliente.Add(objeto);
        }
        public List<Cliente> Lista()
        {
            return listacliente;
        }
        public int ProximoId()
        {
            return listacliente.Count;
        }
        public Cliente RetornaPorId(int id)
        {
            return listacliente[id];
        }
    }
}