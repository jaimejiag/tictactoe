using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------
using System.Drawing;

namespace Ejercicio10
{
    class Casilla : frmPrincipal
    {
        private int _estado;

        public Casilla(int estado)
        {
            _estado = estado;
        }

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public Image GetImagen()
        {
            if (_estado == 1)
                return imgList1.Images[0];
            else if (_estado == 2)
                return imgList2.Images[0];
            else
                return null;
        }
    }
}
