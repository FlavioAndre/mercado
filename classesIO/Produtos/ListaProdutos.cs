using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Mercado.classesIO.Produtos
{
    [Serializable]
    class ListaProdutos 
    {
        ArrayList listaProdutos = new ArrayList();

        /// <summary>
        /// Adiciona um produto na lista
        /// </summary>
        /// <param name="produtos"></param>
        public void addProduto(Produto produtos)
        {
            this.listaProdutos.Add(produtos);
        }

        /// <summary>
        /// retorna um lista de produtos
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllProdutos()
        {
            return this.listaProdutos;
        }

        public Produto getProduto(int index)
        {
            return (Produto)this.listaProdutos[index];
        }

       
    }
}
