using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Mercado.classesIO.ItensListaProdutos
{
    /// <summary>
    /// Classe Lista Itens Produtos da lista
    /// </summary>
    class ListaItensProdutosLista
    {
       ArrayList listaItensProdutos = new ArrayList();

        /// <summary>
        /// Adiciona um itensProdutos na lista
        /// </summary>
        /// <param name="grupos"></param>
        public void addItensProduto(ItensProdutosLista itensProdutos)
        {
            this.listaItensProdutos.Add(itensProdutos);

        }

        /// <summary>
        /// retorna um lista de itensProdutos
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllItensProdutos()
        {
            return this.listaItensProdutos;
        }

        /// <summary>
        /// Retorna um item de produto da lista
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ItensProdutosLista getItensProduto(int index)
        {
            return (ItensProdutosLista)this.listaItensProdutos[index];
        }
    }
}
