using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Proyecto
{
    public class Registros : MySql
    {
        public Registros()
        {
        }
        public ArrayList Mostrar()
        {
            this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), this.myConnection);

            MySqlDataReader myReader = myCommand.ExecuteReader();

            ArrayList registros = new ArrayList();
            while (myReader.Read())
            {

                registro registro = new registro();
                registro.id = myReader["id"].ToString();
                registro.nombre = myReader["nombre"].ToString();
                registro.apellp = myReader["apellp"].ToString();
                registro.apellm = myReader["apellm"].ToString();
                registro.telefono = myReader["telefono"].ToString();
                registro.correo = myReader["correo"].ToString();
                registro.calle = myReader["calle"].ToString();
                registro.numInt = myReader["numint"].ToString();
                registro.numExt = myReader["numInt"].ToString();
                registro.codigoPos = myReader["codigoPos"].ToString();
                registro.colonia = myReader["colonia"].ToString();
                registro.estado = myReader["estado"].ToString();
                registro.municipio = myReader["municipio"].ToString();
                registros.Add(registro);

            }
            myReader.Close();
            myReader = null;
            myCommand.Dispose();
            myCommand = null;
            this.cerrarConexion();
            return registros;

        }
        public bool insertarNuevoRegistro(string nombre, string apellp, string apellm, string telefono, string correo)
        {

            this.abrirConexion();
            string sql = "INSERT INTO `cliente` (`nombre`, `apellp`,`apellm`,`telefono`,`email`) VALUES ('" + nombre + "', '" + apellp + "', '" + apellm + "', '" + telefono + "','" + correo + "')";
            int afectadas = this.ejecutarComando(sql);
            this.cerrarConexion();
            return (afectadas > 0);
        }
        public void editarNombreRegistro(string id, string nombre)
        {
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarapellidosRegistro(string apellp, string apellm)
        {

            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `apellp`,`apellm`='" + apellp + "','" + apellm + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarTelefonoCorreoRegistro(string telefono, string correo)
        {
            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `telefono`,`correo`='" + telefono + "','" + correo + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarNombreCalle(string calle)
        {
            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `direccion` SET `calle`='" + calle + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarNumeroIntExt(string numInt, string numExt)
        {
            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `direccion` SET `numInt`,`numExt`='" + numExt + "','" + numInt + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarCodigoPosColonia(string codigoPos, string colonia)
        {
            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `direccion` SET `codigoPos`,`colonia`='" + codigoPos + "','" + colonia + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.abrirConexion();
        }
        public void editarEstadoMunicipio(string estado, string municipio)
        {
            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `direccion` SET `estado`,`municipio`='" + estado + "','" + municipio + "' WHERE (`id`='" + id + "')";
            this.cerrarConexion();
        }
        public bool eliminarRegistroPorId(string id)
        {
            this.abrirConexion();
            string sql = "DELETE FROM `alumno` WHERE (`id`='" + id + "')";
            int afectadas = this.ejecutarComando(sql);
            this.cerrarConexion();
            return (afectadas > 0);
        }

        public bool existeCodigo(string codigo)
        {
            this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM alumno WHERE codigo = '" + codigo + "'",
                                                      this.myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            return myReader.HasRows;
        }

        public registro obtenerPorId(string id)
        {
            this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM alumno WHERE id = '" + id + "'",
                                                      this.myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            registro registro = new registro();
            if (myReader.HasRows)
            {
                myReader.Read();
                registro.id = myReader["id"].ToString();
                registro.nombre = myReader["nobre"].ToString();
                registro.apellp = myReader["apellp"].ToString();
                registro.apellm = myReader["apellm"].ToString();
                registro.telefono = myReader["telefono"].ToString();
                registro.correo = myReader["correo"].ToString();
                registro.calle = myReader["calle"].ToString();
                registro.numInt = myReader["numint"].ToString();
                registro.numExt = myReader["numInt"].ToString();
                registro.codigoPos = myReader["codigoPos"].ToString();
                registro.colonia = myReader["colonia"].ToString();
                registro.estado = myReader["estado"].ToString();
                registro.municipio = myReader["municipio"].ToString();
            }
            myReader.Close();
            myReader = null;
            myCommand.Dispose();
            myCommand = null;
            this.cerrarConexion();
            return registro;
        }


        private int ejecutarComando(string sql)
        {
            MySqlCommand myCommand = new MySqlCommand(sql, this.myConnection);
            int afectadas = myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            myCommand = null;
            return afectadas;
        }

        private string querySelect()
        {
            return "SELECT *" + "FROM agencia";
        }
    }
}
