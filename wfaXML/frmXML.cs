using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using STRATA.Entities;
using System.Data.SqlClient;
using System.Xml;

namespace wfaXML
{
    public partial class frmXML : Form
    {

        public List<entProcVent> lstVns = new List<entProcVent>();
        public List<entProcVent1> lstDvs = new List<entProcVent1>();
        public List<int> lstKey;

        public entProcVent entVns;
        public entProcVent1 entDvs;

        public frmXML()
        {
            InitializeComponent();
        }

        private void frmXML_Load(object sender, EventArgs e)
        {
            ntfXML.Icon = this.Icon;
            ntfXML.Visible = true;
            //this.WindowState = FormWindowState.Minimized;
            tmrXML.Start();
        }

        private void tmrXML_Tick(object sender, EventArgs e)
        {
            string con = string.Empty;
            lstVns = new List<entProcVent>();
            lstDvs = new List<entProcVent1>();
            tmrXML.Stop();
            #region conexion servidor
            con = "Server=172.16.0.8;Database=STRATA_PV;uid=sa;pwd=sap@dmin625;";
            try
            {
                #region obtencion de los encabezados
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM procvent where ven_enviad is null";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            #region
                            entVns = new entProcVent();
                            entVns.ven_keyven = Convert.ToInt32(dr["ven_keyven"].ToString());
                            entVns.ven_caja = dr["ven_caja"].ToString();
                            entVns.ven_usrven = dr["ven_usrven"].ToString();
                            entVns.ven_cliente = dr["ven_cliente"].ToString();
                            entVns.ven_estado = dr["ven_estado"].ToString();
                            entVns.ven_fecreg = Convert.ToDateTime(dr["ven_fecreg"].ToString());
                            entVns.ven_iva = Convert.ToDecimal(dr["ven_iva"].ToString());
                            entVns.ven_ieps = Convert.ToDecimal(dr["ven_ieps"].ToString());
                            entVns.ven_retencion = Convert.ToDecimal(dr["ven_retencion"].ToString());
                            entVns.ven_descue = Convert.ToDecimal(dr["ven_descue"].ToString());
                            entVns.ven_subtot = Convert.ToDecimal(dr["ven_subtot"].ToString());
                            entVns.ven_total = Convert.ToDecimal(dr["ven_total"].ToString());
                            entVns.ven_porcdesc = Convert.ToDecimal(dr["ven_porcdesc"].ToString());
                            entVns.ven_porciva = Convert.ToDecimal(dr["ven_porciva"].ToString());
                            entVns.ven_porcieps = Convert.ToDecimal(dr["ven_porcieps"].ToString());
                            entVns.ven_porcretencion = Convert.ToDecimal(dr["ven_porcretencion"].ToString());
                            entVns.ven_almace = dr["ven_almace"].ToString();
                            entVns.ven_keypos = Convert.ToInt32(dr["ven_keypos"].ToString());
                            lstVns.Add(entVns);
                            #endregion
                        }
                    }
                }
                #endregion
                #region obtencion de los detalles de la venta
                foreach (entProcVent ent in lstVns)
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                        conn.ConnectionString = con;
                        conn.Open();

                        string command = "SELECT * FROM procvent1 where ven1_keyven = " + ent.ven_keyven;

                        using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            int lin = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                #region
                                entDvs = new entProcVent1();
                                entDvs.ven1_keyven = Convert.ToInt32(dr["ven1_keyven"].ToString());
                                entDvs.ven1_numlin = lin;
                                entDvs.ven1_articulo = dr["ven1_articulo"].ToString();
                                entDvs.ven1_artdes = dr["ven1_artdes"].ToString();
                                entDvs.ven1_cantidad = Convert.ToDecimal(dr["ven1_cantidad"].ToString());
                                entDvs.ven1_precio = Convert.ToDecimal(dr["ven1_precio"].ToString());
                                entDvs.ven1_iva = Convert.ToDecimal(dr["ven1_ieps"].ToString());
                                entDvs.ven1_ieps = Convert.ToDecimal(dr["ven1_ieps"].ToString());
                                entDvs.ven1_totallinea = Convert.ToDecimal(dr["ven1_totallinea"].ToString());
                                entDvs.ven1_moneda = dr["ven1_moneda"].ToString();
                                entDvs.ven1_tipocambio = Convert.ToDecimal(dr["ven1_tipocambio"].ToString());
                                entDvs.ven1_escompues = Convert.ToBoolean(dr["ven1_escompues"].ToString());
                                entDvs.ven1_idpaquete = dr["ven1_idpaquete"].ToString();
                                entDvs.ven1_porcdesc = Convert.ToDecimal(dr["ven1_porcdesc"].ToString());
                                entDvs.ven1_descuento = Convert.ToDecimal(dr["ven1_descuento"].ToString());
                                entDvs.ven1_keyalm = "";
                                entDvs.ven1_keypro = "";
                                entDvs.ven1_OcrCode = "";
                                lstDvs.Add(entDvs);
                                lin++;
                                #endregion
                            }
                        }
                    }
                }
                #endregion

                foreach (entProcVent vns in lstVns)
                {
                    CrearXmlTransacciones(vns.ven_keyven.ToString("000"));
                    List<entProcVent1> lst = new List<entProcVent1>();
                    lst = lstDvs.FindAll(x => x.ven1_keyven.Equals(vns.ven_keyven));
                    NodoTransacciones(vns.ven_keyven.ToString("000"), vns, lst);
                    #region update en el servidor
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                            SqlCommand cmd = new SqlCommand();

                            cmd.CommandText = "Update procvent set ven_enviad = 1 where ven_keyven = " + vns.ven_keyven;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;

                            if (connection.State == ConnectionState.Closed)
                                connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                    }
                    #endregion

                }
            }
            catch
            {
            }
            #endregion

            tmrXML.Start();
        }

        private void ntfXML_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void frmXML_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        public static bool CrearCarpetaXml(string Ruta)
        {
            bool Respuesta = false;
            try
            {
                if (Directory.Exists(Ruta))
                {
                    Respuesta = true;
                }
                else
                {
                    Directory.CreateDirectory(Ruta);
                    Respuesta = true;
                }
                return Respuesta;
            }
            catch (Exception ex)
            {
                //logger.Error("Error en CrearCarpetaXml, ClaseXml:" + ex.Message);
                return Respuesta;
                //No fue posible crear el directorio...
            }

        }

        public static bool ArchivoExiste(string Ruta)
        {
            try
            {
                if (File.Exists(Ruta))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //logger.Error("Error en ArchivoExiste, ClaseXml:" + ex.Message);
                return false;
            }
        }

        private static bool CrearXmlTransacciones(string valor)
        {
            bool rta = false;

            try
            {
                XmlTextWriter EscribirRec = new XmlTextWriter("C:\\export\\OINVxml\\xmlOINV" + valor + ".xml", System.Text.Encoding.UTF8);

                EscribirRec.Formatting = Formatting.Indented;
                EscribirRec.Indentation = 2;
                EscribirRec.WriteStartDocument(false);
                EscribirRec.WriteComment("Venta Creada desde POS Strata");

                EscribirRec.WriteStartElement("BO");

                EscribirRec.WriteStartElement("Documents");
                EscribirRec.WriteEndElement();

                EscribirRec.WriteStartElement("Document_Lines");
                EscribirRec.WriteEndElement();

                EscribirRec.WriteEndElement();
                EscribirRec.WriteEndDocument();
                EscribirRec.Close();
                rta = true;
            }
            catch (Exception ex)
            {
                rta = false;
            }

            return rta;
        }

        public static bool NodoTransacciones(string valor, entProcVent ent, List<entProcVent1> lst)
        {
            XmlDocument XmlDoc;
            XmlNode Raiz;
            XmlNode ident;
            bool rta = false;

            try
            {
                XmlDoc = new XmlDocument();
                XmlDoc.Load("C:\\export\\xmlOINV" + valor + ".xml");
                Raiz = XmlDoc.DocumentElement;

                ident = Raiz.FirstChild;

                XmlElement NuevaTransaccion = XmlDoc.CreateElement("row"); //Como vamos a llamar el nuevo nodo
                NuevaTransaccion.InnerXml = "<Venta></Venta><CardCode></CardCode><CardName></CardName><Docdate></Docdate><DocDueDate></DocDueDate><TaxDate></TaxDate><DocCur></DocCur>" +
                    "<DocTotal></DocTotal><Comments></Comments>"; // Este es el contenido que va a tener el nuevo nodo

                NuevaTransaccion.AppendChild(XmlDoc.CreateWhitespace("\r\n"));
                NuevaTransaccion["Venta"].InnerText = ent.ven_keyven.ToString();
                NuevaTransaccion["CardCode"].InnerText = "1000061";
                NuevaTransaccion["CardName"].InnerText = "VENTAS AL PUBLICO EN GENERAL MOSTRADOR MATRIZ";
                NuevaTransaccion["Docdate"].InnerText = ent.ven_fecreg.ToString("yyyyMMdd");
                NuevaTransaccion["DocDueDate"].InnerText = ent.ven_fecreg.ToString("yyyyMMdd");
                NuevaTransaccion["DocCur"].InnerText = "MXP";
                NuevaTransaccion["TaxDate"].InnerText = ent.ven_fecreg.ToString("yyyyMMdd");
                NuevaTransaccion["DocTotal"].InnerText = ent.ven_total.ToString();
                NuevaTransaccion["Comments"].InnerText = "Este factura esta creado desde el B1if que viene desde el POS Strata de la venta " + ent.ven_keyven;

                ident.InsertAfter(NuevaTransaccion, ident.LastChild);
                XmlTextWriter EscribirRec = new XmlTextWriter("C:\\export\\OINVxml\\xmlOINV" + valor + ".xml", System.Text.Encoding.UTF8);
                XmlDoc.WriteTo(EscribirRec);

                EscribirRec.Close();

                foreach (entProcVent1 dvs in lst)
                {
                    ident = Raiz.FirstChild.NextSibling;

                    NuevaTransaccion = XmlDoc.CreateElement("row"); //Como vamos a llamar el nuevo nodo
                    NuevaTransaccion.InnerXml = "<ItemCode></ItemCode><Dscription></Dscription><Quantity></Quantity><Price></Price><Currency></Currency><LineTotal></LineTotal>" +
                        "<WarehouseCode></WarehouseCode><TaxCode></TaxCode>"; // Este es el contenido que va a tener el nuevo nodo

                    NuevaTransaccion.AppendChild(XmlDoc.CreateWhitespace("\r\n"));
                    NuevaTransaccion["ItemCode"].InnerText = dvs.ven1_articulo;
                    NuevaTransaccion["Dscription"].InnerText = dvs.ven1_artdes;
                    NuevaTransaccion["Quantity"].InnerText = dvs.ven1_cantidad.ToString();
                    NuevaTransaccion["Price"].InnerText = dvs.ven1_precio.ToString();
                    NuevaTransaccion["Currency"].InnerText = "MXP";
                    NuevaTransaccion["LineTotal"].InnerText = dvs.ven1_totallinea.ToString();
                    NuevaTransaccion["WarehouseCode"].InnerText = "0107";
                    NuevaTransaccion["TaxCode"].InnerText = "102";

                    ident.InsertAfter(NuevaTransaccion, ident.LastChild);
                    EscribirRec = new XmlTextWriter("C:\\export\\OINVxml\\xmlOINV" + valor + ".xml", System.Text.Encoding.UTF8);
                    XmlDoc.WriteTo(EscribirRec);

                    EscribirRec.Close();
                }
                rta = true;

                string con = string.Empty;
            }
            catch (Exception ex)
            {
                rta = false;
                //logger.Error("Error en NodoTransacciones, ClaseXml:" + ex.Message);
            }
            return rta;
        }



    }
}
