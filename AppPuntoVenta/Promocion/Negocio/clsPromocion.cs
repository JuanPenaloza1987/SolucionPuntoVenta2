
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AppPuntoVenta.Promocion.Negocio
{
    class clsPromocion
    {
        #region Cabeceera promoción
        private int _prom_id;
        public int prom_id
        {
            get { return _prom_id; }
            set { _prom_id = value; }
        }

        private string _prom_codigo;
        public string prom_codigo
        {
            get { return _prom_codigo; }
            set { _prom_codigo = value; }
        }

        private string _prom_descrip;
        public string prom_descrip
        {
            get { return _prom_descrip; }
            set { _prom_descrip = value; }
        }

        private DateTime _prom_fini;
        public DateTime prom_fini
        {
            get { return _prom_fini; }
            set { _prom_fini = value; }
        }

        private DateTime _prom_ffin;
        public DateTime prom_ffin
        {
            get { return _prom_ffin; }
            set { _prom_ffin = value; }
        }

        private string _prom_tpromo;
        public string prom_tpromo
        {
            get { return _prom_tpromo; }
            set { _prom_tpromo = value; }
        }

        private bool _prom_lun;
        public bool prom_lun
        {
            get { return _prom_lun; }
            set { _prom_lun = value; }
        }

        private bool _prom_mar;
        public bool prom_mar
        {
            get { return _prom_mar; }
            set { _prom_mar = value; }
        }

        private bool _prom_mie;
        public bool prom_mie
        {
            get { return _prom_mie; }
            set { _prom_mie = value; }
        }

        private bool _prom_jue;
        public bool prom_jue
        {
            get { return _prom_jue; }
            set { _prom_jue = value; }
        }

        private bool _prom_vie;
        public bool prom_vie
        {
            get { return _prom_vie; }
            set { _prom_vie = value; }
        }

        private bool _prom_sab;
        public bool prom_sab
        {
            get { return _prom_sab; }
            set { _prom_sab = value; }
        }

        private bool _prom_dom;
        public bool prom_dom
        {
            get { return _prom_dom; }
            set { _prom_dom = value; }
        }

        private string _mensaje;
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        private float _prom_cantr;
        public float prom_cantr
        {
            get { return _prom_cantr; }
            set { _prom_cantr = value; }
        }

        private float _prom_canta;
        public float prom_canta
        {
            get { return _prom_canta; }
            set { _prom_canta = value; }
        }
        #endregion

        #region Detalle de promoción
        private int _prar_id;
        public int prar_id
        {
            get { return _prar_id; }
            set { _prar_id = value; }
        }

        private string _prar_codprom;
        public string prar_codprom
        {
            get { return _prar_codprom; }
            set { _prar_codprom = value; }
        }

        private string _prar_keyart;
        public string prar_keyart
        {
            get { return _prar_keyart; }
            set { _prar_keyart = value; }
        }

        private decimal _prar_precio;
        public decimal prar_precio
        {
            get { return _prar_precio; }
            set { _prar_precio = value; }
        }

        private int _prar_porcdesc;
        public int prar_porcdesc
        {
            get { return _prar_porcdesc; }
            set { _prar_porcdesc = value; }
        }

        private decimal _prar_predesc;
        public decimal prar_predesc
        {
            get { return _prar_predesc; }
            set { _prar_predesc = value; }
        }

        private bool _prar_esnec;
        public bool prar_esnec
        {
            get { return _prar_esnec; }
            set { _prar_esnec = value; }
        }

        private bool _prar_esreg;
        public bool prar_esreg
        {
            get { return _prar_esreg; }
            set { _prar_esreg = value; }
        }
        #endregion

        public bool Guardar()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "INSERT INTO[procpromo](" +
           "[prom_codigo],[prom_descrip],[prom_fini],[prom_ffin],[prom_tpromo],[prom_lun],[prom_mar],[prom_mie],[prom_jue],[prom_vie],[prom_sab],[prom_dom],[prom_cantr],[prom_canta])" +
            "VALUES" +
           "(" + prom_codigo + ", " +
           prom_descrip + ", " +
           "'" + prom_fini.ToString("yyyyMMdd") + "', " +
           "'" + prom_ffin.ToString("yyyyMMdd") + "', " +
           prom_tpromo + ", " +
           (prom_lun ? 1 : 0).ToString() + ", " +
           (prom_mar ? 1 : 0).ToString() + ", " +
           (prom_mie ? 1 : 0).ToString() + ", " +
           (prom_jue ? 1 : 0).ToString() + ", " +
           (prom_vie ? 1 : 0).ToString() + ", " +
           (prom_sab ? 1 : 0).ToString() + ", " +
           (prom_dom ? 1 : 0).ToString() + ", " +
           prom_cantr.ToString() + ", " +
           prom_canta.ToString() + ");";
            Objeto.ejecutaTransaccionConIdentityCE();
            if (!Objeto.hayError)
            {
                prom_id = int.Parse(Objeto.identity);
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }


        public bool Actualizar()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "UPDATE [procpromo]  SET [prom_descrip]= " +
            prom_descrip + ",[prom_fini] = '" + prom_fini.ToString("yyyyMMdd") + "',[prom_ffin] = '" + prom_ffin.ToString("yyyyMMdd") + "',[prom_tpromo] = " +
            prom_tpromo + " ,[prom_lun] = " +
            (prom_lun ? 1 : 0).ToString() + ",[prom_mar] = " +
            (prom_mar ? 1 : 0).ToString() + ",[prom_mie] = " +
            (prom_mie ? 1 : 0).ToString() + ",[prom_jue] = " +
            (prom_jue ? 1 : 0).ToString() + ",[prom_vie] = " +
            (prom_vie ? 1 : 0).ToString() + ",[prom_sab] = " +
            (prom_sab ? 1 : 0).ToString() + ",[prom_dom] = " +
            (prom_dom ? 1 : 0).ToString() + ",[prom_cantr]= " +
            prom_cantr.ToString() + ",[prom_canta] = " +
            prom_canta.ToString() + " WHERE prom_codigo= " + prom_codigo + " ;";

            Objeto.ejecutaTransaccionConIdentityCE();
            if (!Objeto.hayError)
            {
                prom_id = int.Parse(Objeto.identity);
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public DataSet TraerPromociones()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM procpromo ORDER BY prom_id desc";
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

        public bool GuardarDetalle()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "INSERT INTO [promarti]([prar_codprom],[prar_keyart],[prar_precio],[prar_porcdesc],[prar_predesc],[prar_esnec],[prar_esreg])" +
           "VALUES(" + 
           prar_codprom +
           "," + prar_keyart +
           "," + prar_precio +
           "," + prar_porcdesc +
           "," + prar_predesc +
           "," + (prar_esnec?"1":"0") +
           "," + (prar_esreg ? "1" : "0") + ");";
            Objeto.ejecutaTransaccionConIdentityCE();
            if (!Objeto.hayError)
            {
                prar_id = int.Parse(Objeto.identity);
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public DataSet ValidarActualizacion()
        {
            BD Objeto = new BD();
            
            DataSet consulta = new DataSet();
            Objeto.sentenciaSQL = "SELECT [prom_fini],[prom_ffin] FROM procpromo WHERE [prom_codigo]= " + prar_codprom;
            consulta = Objeto.ejecutaConsulta();
            var consSql = consulta.Tables[0].Rows;
            DateTime fechaIni = Convert.ToDateTime(consSql[0].ItemArray[0].ToString());
            DateTime fechaFin = Convert.ToDateTime(consSql[0].ItemArray[1].ToString());

            BD Objeto1 = new BD();
            
            DataSet consulta1 = new DataSet();
            Objeto1.sentenciaSQL = "SELECT COUNT(T0.prom_codigo) FROM procpromo T0 INNER JOIN  [promarti] T1 ON (T0.prom_codigo = T1.prar_codprom) " +
            " WHERE   T0.prom_fini >= '" + fechaIni.ToString("yyyyMMdd") + "'" + " AND T0.prom_ffin <= '" + fechaFin.ToString("yyyyMMdd") + "'" +
            " AND T1.prar_keyart = " + prar_keyart + " AND  T0.prom_codigo != " + prar_codprom;
            consulta1 = Objeto1.ejecutaConsulta();

            
            if (!Objeto.hayError)
            {
                return consulta1;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public bool ActualizarDetalle()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "UPDATE [promarti] SET [prar_keyart] = " + prar_keyart +
           ",[prar_precio] = " + prar_precio +
           ",[prar_porcdesc] = " + prar_porcdesc +
           ",[prar_predesc] = " + prar_predesc +
           ",[prar_esnec] = " + (prar_esnec ? "1" : "0") +
           ",[prar_esreg] = " + (prar_esreg ? "1" : "0") + " WHERE [prar_codprom] = " +
           prar_codprom + ";";

            Objeto.ejecutaTransaccionConIdentityCE();
            if (!Objeto.hayError)
            {
                prar_id = int.Parse(Objeto.identity);
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public DataSet TraerDetallePromociones()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT [prar_keyart],[art_descripc],[prar_precio],[prar_porcdesc],[prar_predesc],[prar_esnec],[prar_esreg] FROM[promarti] JOIN[cataarti] ON[prar_keyart] = [art_keyart] WHERE prar_codprom = '" + prar_codprom + "' AND prar_esreg = 0";
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

        public DataSet TraerDetallePromocionesRegalo()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT [prar_keyart],[art_descripc],[prar_precio],[prar_porcdesc],[prar_predesc],[prar_esnec],[prar_esreg] FROM[promarti] JOIN[cataarti] ON[prar_keyart] = [art_keyart] WHERE prar_codprom = '" + prar_codprom + "'  AND prar_esreg = 1";
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

        public DataSet TraerPromocionesVigentes()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT [prom_codigo],[prom_descrip],[prom_tpromo],[prom_cantr],[prom_canta] FROM [procpromo] WHERE prom_fini <= GETDATE() AND prom_ffin >= GETDATE() " + TraerConsultaDia();
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

        string TraerConsultaDia()
        {
            int dia = DateTime.Now.DayOfWeek.GetHashCode();
            string consulta = "";
            switch (dia)
            {
                case 1:
                    consulta = "AND prom_lun = 1";
                    break;
                case 2:
                    consulta = "AND prom_mar = 1";
                    break;
                case 3:
                    consulta = "AND prom_mie = 1";
                    break;
                case 4:
                    consulta = "AND prom_jue = 1";
                    break;
                case 5:
                    consulta = "AND prom_vie = 1";
                    break;
                case 6:
                    consulta = "AND prom_sab = 1";
                    break;
                case 7:
                    consulta = "AND prom_dom = 1";
                    break;
            }
            return consulta;
        }

        public bool EliminarPromocion()
        {
            BD Objeto = new BD();
            
            if (EliminarDetallePromocion())
            {
                Objeto.sentenciaSQL = "DELETE procpromo WHERE prom_codigo = '" + prom_codigo + "'";
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
            else
            {
                return false;
            }
        }

        public bool EliminarDetallePromocion()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "DELETE FROM promarti WHERE prar_codprom = '" + prom_codigo + "'";
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

        public DataSet TraerPromocion()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT  [prom_codigo],[prom_descrip],[prom_fini],[prom_ffin],[prom_tpromo],[prom_lun],[prom_mar],[prom_mie],[prom_jue],[prom_vie],[prom_sab],[prom_dom],[prom_cantr],[prom_canta] FROM[procpromo] WHERE prom_codigo = '" + prar_codprom + "'";
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
