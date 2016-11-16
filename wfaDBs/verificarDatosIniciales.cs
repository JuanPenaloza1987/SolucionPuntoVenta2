using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRATA.wfaDBs
{
   public class verificarDatosIniciales
    {

        public int existenDatos() {

            int registrosCPU = 0;
            int registrosCNX = 0;
            int conexion = 0;

            //Buscar En CNX
            SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString());       
            string SqlAction = "SELECT * FROM CNX";
            SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            registrosCNX = dt.Rows.Count;

            //Buscar en CPU
            SqlCeConnection cnxCPU = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString());
            string SqlActionCPU = "SELECT * FROM CPU";
            SqlCeCommand cmd2 = new SqlCeCommand(SqlActionCPU, cnxCPU);
            SqlCeDataAdapter daCPU = new SqlCeDataAdapter(cmd2);
            DataTable dtCPU = new DataTable();
            daCPU.Fill(dtCPU);
            registrosCPU = dtCPU.Rows.Count;

            if (registrosCPU > 0 && registrosCNX > 0)
            {
                conexion = 1;
            }
            else
            {
                conexion = 0;
            }
                    
            return conexion;

        } 
    }
}
