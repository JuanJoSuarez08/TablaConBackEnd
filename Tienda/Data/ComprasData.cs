using Tienda.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tienda.Data
{
    public class ComprasData
    {
        public static bool RegistrarC(Compras oCompra)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Registrar_C '"+oCompra.ProductoID+"','"+oCompra.UserID+"','"+oCompra.FechaCompra+"'";

            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static bool ActualizarC(Compras oCompra)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Actualizar_C '"+oCompra.ComprasID+"','" + oCompra.ProductoID + "','" + oCompra.UserID + "','" + oCompra.FechaCompra + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static bool EliminarC(string id)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Eliminar_C '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static List<Compras> Listar()
        {
            List<Compras> oListaUsuario = new List<Compras>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Listar_C";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Compras()
                    {
                        ComprasID = Convert.ToInt32(dr["CompraID"].ToString()),
                        ProductoID = Convert.ToInt32(dr["ProductoID"].ToString()),
                        UserID = Convert.ToInt32(dr["UserID"].ToString()),
                        FechaCompra = Convert.ToDateTime(dr["FechaCompra"].ToString())
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }
        }
        public static List<Compras> Obtener(string id)
        {
            List<Compras> oListaUsuario = new List<Compras>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_C '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Compras()
                    {
                        ComprasID = Convert.ToInt32(dr["CompraID"]),
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        UserID = Convert.ToInt32(dr["UserID"]),
                        FechaCompra = Convert.ToDateTime(dr["FechaCompra"])
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }
        }
    }
}