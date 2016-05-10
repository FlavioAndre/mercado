using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Mercado.classesIO.Mercados
{
    class ListaSuperMercado
    {
        ArrayList listaMercados = new ArrayList();

        /// <summary>
        /// Adiciona um mercado na lista
        /// </summary>
        /// <param name="grupos"></param>
        public void addMercado(SuperMercado mercado)
        {
            this.listaMercados.Add(mercado);

        }

        /// <summary>
        /// retorna um lista de mercado
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllMercados()
        {
            return this.listaMercados;
        }

        public SuperMercado getMercado(int index)
        {
            return (SuperMercado)this.listaMercados[index];
        }
    }
}
