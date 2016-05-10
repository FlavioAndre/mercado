using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Mercado.classesIO.ProdutosLista;

namespace ListaMercados.classesIO.ProdutosLista
{
    class ListaProdutosLista
    {
        ArrayList listaProdutos = new ArrayList();

        /// <summary>
        /// Adiciona um listaMercado na lista
        /// </summary>
        /// <param name="grupos"></param>
        public void addListaMercados(ProdutoLista produtoLista)
        {
            this.listaProdutos.Add(produtoLista);

        }

        /// <summary>
        /// retorna um lista de listaMercado
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllProdutosListas()
        {
            return this.listaProdutos;
        }

        public ProdutoLista getListaMercados(int index)
        {
            return (ProdutoLista)this.listaProdutos[index];
        }
    }

}
