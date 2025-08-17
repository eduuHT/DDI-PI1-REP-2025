using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Forms.Grupos
{
    internal class GrupoBLL
    {
        private GrupoDAL _grupoDAl;

        #region Constructors
        public GrupoBLL()
        {
            _grupoDAl = new GrupoDAL();
        }
        #endregion

        public Grupo GuardarGrupo(Grupo grupo)
        {
            _grupoDAl.InsertGrupo(grupo);

            return grupo;
        }

       public List<Grupo> GetGrupos()
        {
         return _grupoDAl.GetGrupos(); 
        }
    }
}
