﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_string
{
    internal class pack
    {
        private string descripcion;

        public pack(string descripcio)
        {
            this.descripcion = descripcion;

        }

        public pack()
        {

        }

        public string Getdescripcion() { 
            return descripcion;
        }
        public void Setdescripcion(string descripcion) { 
            this.descripcion = descripcion;
        }

        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string selectUsuario = "Select * from pack";
                SqlCommand cmd = new SqlCommand(selectUsuario, c.conectarbd);
                cmd.CommandType = CommandType.Text;
                c.abrir();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dtt);
                c.cerrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtt;
        }

        public string insertar()
        {
            try
            {
                conexionbd c = new conexionbd();
                string insert = $"insert into pack values ('{Getdescripcion()}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Pack creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from pack where descripcion = '{Getdescripcion()}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Pack eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
