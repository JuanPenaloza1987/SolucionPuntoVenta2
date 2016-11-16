using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRATAPV.Utilerias;
using System.Data;

namespace SRATAPV.Seguridad.Negocio
{
    class clsPerfiles
    {
        private string _perfil_id;
        private string _perfil_nombre;
        private bool _activo;
        private string _usuario_id;
        private DataSet _dsPerfiles;
        private string _mensaje;

        public bool activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string perfil_id
        {
            get { return _perfil_id; }
            set { _perfil_id = value; }
        }

        public string perfil_nombre
        {
            get { return _perfil_nombre; }
            set { _perfil_nombre = value; }
        }

        public string usuario_id
        {
            get { return _usuario_id; }
            set { _usuario_id = value; }
        }

        public DataSet dsPerfiles
        {
            get { return _dsPerfiles; }
            set { _dsPerfiles = value; }
        }

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        //Metodos y funciones
        public DataSet leerPerfiles()
        {
            BD Objeto = new BD();
            DataSet Perfiles = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_seguperf]";
            Perfiles = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {                
                return Perfiles;
            }
            else
            {
                _mensaje = Objeto.mensaje;
                return null;
            }
        }

        public Boolean Guardar()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "exec [spguar_seguperf] '" + _perfil_id.Trim() + "'," +
                                                         "'" + _perfil_nombre.Trim() + "'," +
                                                         "'" + _activo + "'," +
                                                         "'" + Globals.Instance.usuario + "'";
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

        public DataSet leerPerfilPorUsuario()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();

            
            Objeto.sentenciaSQL = "exec [spleer_seguperf_usuario] '" + _usuario_id + "'";
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

        public DataSet leerUnicoPerfil()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_seguperf_unico] '" + _perfil_id + "'";
            Usuario = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return Usuario;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public DataSet leerPerfilesSinAsignarPorUsuario()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_seguperf_sinasignar] '" + _usuario_id + "'";
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

        public DataSet leerPerfilesAsignadosPorUsuario()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_seguperf_asignados] '" + _usuario_id + "'";
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

        public bool eliminarPerfilesPorUsuario()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "exec [spborr_usuaperf] '" + _usuario_id + "'";
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

        public bool guardarPerfilesPorUsuario()
        {
            bool flag = false;
            BD Objeto = new BD();
            
            foreach (DataRow renglon in _dsPerfiles.Tables[0].Rows)
            {
                Objeto.sentenciaSQL = "exec [spguar_usuaperf] '" + _usuario_id + "', '" + renglon["per_keyperf"] + "'";
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
