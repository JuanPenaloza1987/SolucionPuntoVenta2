
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AppPuntoVenta.Promocion.Negocio
{
    class clsTipoPromocion
    {
        private int _tpr_id;

        public int tpr_id
        {
            get { return _tpr_id; }
            set { _tpr_id = value; }
        }
        private string _tpr_nombre;

        public string tpr_nombre
        {
            get { return _tpr_nombre; }
            set { _tpr_nombre = value; }
        }
        private string _tpr_descrip;

        public string tpr_descrip
        {
            get { return _tpr_descrip; }
            set { _tpr_descrip = value; }
        }

        private string _mensaje;

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }


        public DataSet TraerTipoPromocion()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM catatprom";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return consulta;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }


    }
}
