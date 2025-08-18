using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Forms.Materias
{
    internal class MateriaBLL
    {
        private MateriaDAL _materiaDAL;

        #region Constructors
        public MateriaBLL()
        {
            _materiaDAL = new MateriaDAL();
        }
        #endregion

        public Materia GuardarMateria(Materia materia)
        {
            _materiaDAL.InsertMateria(materia);

            return materia;
        }

        public List<Materia> GetMaterias()
        {
            return _materiaDAL.GetMaterias();
        }

        public void ActualizarMateria(Materia materia)
        {
            _materiaDAL.UpdateMateria(materia);
        }

        public void EliminarMateria(int materiaId)
        {
            _materiaDAL.DeleteMateria(materiaId);
        }
    }
}
