using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Mercado.classesIO.Grupos
{
    /// <summary>
    /// Classe para manter um lista de grupos para serem serializados
    /// </summary>
    [Serializable]
    class ListaGrupos : IComparer
    {
        ArrayList listaGrupos = new ArrayList();

        /// <summary>
        /// Adiciona um grupo na lista
        /// </summary>
        /// <param name="grupos"></param>
        public void addGrupo(Grupo grupos)
        {
            this.listaGrupos.Add(grupos);
           
        }

        /// <summary>
        /// retorna um lista de grupos
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllGrupos()
        {
            return this.listaGrupos;
        }

        public Grupo getGrupo(int index)
        {
            return (Grupo)this.listaGrupos[index];
        }

        #region IComparer Members

        public int Compare(object x, object y)
        {
            Grupo grupo1 = (Grupo)x;
            Grupo grupo2 = (Grupo)y;

            return grupo1.Codigo.CompareTo(grupo2.Codigo);
        }

        #endregion
    }
}
