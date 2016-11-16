using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SRATAPV.Utilerias.Negocio;

namespace SRATAPV.Seguridad.Negocio
{
    class clsLogin
    {
        private string _usuario;
        private string _pwd;
        private string _perfil;
        private string _mensaje;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }

        public string perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
       
        //Autentifica al usuario
        public bool autentificar()
        {
            DataSet ds = new DataSet();
            BD Objeto = new BD();
            bool resp = false;

            Objeto.sentenciaSQL = "select usu_keyusu from seguusua u where u.usu_keyusu = '" + usuario + "' and u.usu_passwo = '" + pwd + "' and u.usu_activo = '1'";
            ds = Objeto.ejecutaConsulta();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    resp = true;
                }
                else
                {
                    mensaje = Objeto.mensaje;
                    resp = false;
                }
            }
            else
            {
                mensaje = Objeto.mensaje;
                resp = false;
            }
            return resp;
        }

        

        public bool tieneAccesoA(System.Windows.Forms.Form forma)
        {
            return true;
        }

        public List<clsPermisos> leerPermisosPorUsuario(String usuario_id)
        {
            DataTable dt = new DataTable();
            BD Objeto = new BD();
            try
            {                
                Objeto.sentenciaSQL = "SELECT DISTINCT pp.ppe_keypan, pp.ppe_keymod, p.pan_nombre  FROM usuaperf up, perfperm pp, segupant p " + 
                    "WHERE up.upe_keyperf = pp.ppe_keyperf  AND pp.ppe_keypan = p.pan_keypan  AND up.upe_keyusu = '" + usuario +"'";
                dt = Objeto.ejecutaConsulta().Tables[0];

                List<clsPermisos> lista = Conversiones.convertirEnLista<clsPermisos>(dt);

                return lista;
            }
            catch (Exception ex)
            {
                mensaje = Objeto.mensaje;
                throw new Exception(ex.Message.ToString());
            }
        }


        public DataSet leerAlmacenes()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();

            Objeto.sentenciaSQL = "SELECT * FROM cataalma";
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

        public DataSet leerCuentaContableCentroCostos()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();

            Objeto.sentenciaSQL = "SELECT * FROM confpara";
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

    }
}
