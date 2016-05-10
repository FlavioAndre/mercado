using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Mercado.classesIO.UnidadeMedidas
{
    class ListaUnidadeMedida
    {
        ArrayList listaUnidadeMedidas = new ArrayList();

        /// <summary>
        /// Adiciona um produto na lista
        /// </summary>
        /// <param name="unidadeMedidas"></param>
        public void addUnidadeMedida(UnidadeMedida unidadeMedidas)
        {
            this.listaUnidadeMedidas.Add(unidadeMedidas);
        }

        /// <summary>
        /// retorna um lista de unidadeMedidas
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllUnidadeMedidas()
        {
            return this.listaUnidadeMedidas;
        }

        public UnidadeMedida getUnidadeMedida(int index)
        {
            return (UnidadeMedida)this.listaUnidadeMedidas[index];
        }
    }
}
