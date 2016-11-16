using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRATAPV.Utilerias;
using System.Data;


namespace SRATAPV.Seguridad.Negocio
{
    class clsUsuarios
    {
        private string _usuario_id;
        private string _usuario_pwd;
        private string _usuario_nombre;
        private string _usuario_email;
        private DateTime _fecha_modificacion;
        private DateTime _fecha_alta;
        private bool _activo;
        private string _perfil;
        private string _almacenArea;
        private bool _usaAlmacenesBO;
        private string _textoBusqueda;
        private string _tipoBusqueda;
        private DataSet _dsPerfiles;
        private string _mensaje;

        public string usuario_id
        {
            get { return _usuario_id; }
            set { _usuario_id = value; }
        }

        public string usuario_pwd
        {
            get { return _usuario_pwd; }
            set { _usuario_pwd = value; }
        }

        public string usuario_nombre
        {
            get { return _usuario_nombre; }
            set { _usuario_nombre = value; }
        }

        public string usuario_email
        {
            get { return _usuario_email; }
            set { _usuario_email = value; }
        }

        public DateTime fecha_modificacion
        {
            get { return _fecha_modificacion; }
            set { _fecha_modificacion = value; }
        }

        public DateTime fecha_alta
        {
            get { return _fecha_alta; }
            set { _fecha_alta = value; }
        }

        public bool activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        public string almacenArea
        {
            get { return _almacenArea; }
            set { _almacenArea = value; }
        }

        public bool usaAlmacenesBO
        {
            get { return _usaAlmacenesBO; }
            set { _usaAlmacenesBO = value; }
        }       

        public string textoBusqueda
        {
            get { return _textoBusqueda; }
            set { _textoBusqueda = value; }
        }        

        public string tipoBusqueda
        {
            get { return _tipoBusqueda; }
            set { _tipoBusqueda = value; }
        }

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        
        public DataSet leerUnicoUsuario(string idUsuario)
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT [usu_keyusu] ,[usu_passwo] ,[usu_nombre] ,[usu_correo] ,[usu_activo] ,[usu_fecalt] ,[usu_fecmod] ,[usu_usumod] FROM[seguusua]" +
                "WHERE [usu_keyusu] = '" + idUsuario + "'";
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
