using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace SRATAPV.Seguridad.Negocio
{
    class clsPantallas
    {
        private string _perfil_id;
        private DataSet _dsPantallas;
        private string _mensaje;
        
        public string perfil_id
        {
            get { return _perfil_id; }
            set { _perfil_id = value; }
        }

        public DataSet dsPantallas
        {
            get { return _dsPantallas; }
            set { _dsPantallas = value; }
        }

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public DataSet leerPantallasSinAsignarPorPerfil()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_perfperm_sinasignar] '" + _perfil_id + "'";
            ds = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return ds;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public DataSet leerPantallasAsignadasPorPerfil()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_perfperm_asignados] '" + _perfil_id + "'";
            ds = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return ds;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public bool eliminarPantallasPorPerfil()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "exec [spborr_perfperm] '" + _perfil_id + "'";
            Objeto.ejecutaTransaccion();
            if (!Objeto.hayError)
            {
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public bool guardarPantallasPorPerfil()
        {
            bool flag = false;
            BD Objeto = new BD();
            
            foreach (DataRow renglon in _dsPantallas.Tables[0].Rows)
            {
                Objeto.sentenciaSQL = "exec [spguar_perfperm] '" + _perfil_id + "', '" + renglon["pan_keypan"] + "'";
                Objeto.ejecutaTransaccion();
                if (!Objeto.hayError)
                {
                    flag = true;
                }
                else
                {
                    mensaje = Objeto.mensaje;
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
