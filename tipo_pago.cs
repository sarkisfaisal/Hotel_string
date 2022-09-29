﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_string
{
    internal class tipo_pago
    {
       private string descripcion;
        public tipo_pago(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public void setdescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public string Getdescripcion()
        {
            return descripcion;

        }

        public DataTable TraerFila(string Id)
        {

            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string selectUsuario = $"Select top 1 * from tipo_pago where idtipo_pago = {Id}";
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
        }//fin traer fila

        //Camila:Esto me va a retornar una variable del tipo data table, que lo que haces es recibir el resultado del select
        //En pocas palabras, sirve para traer datos de la tabla tipo_pagos y esto contendrá la información que traje. 
        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string select = "Select * from tipo_pago";
                SqlCommand cmd = new SqlCommand(select, c.conectarbd);
                cmd.CommandType = CommandType.Text;
                c.abrir();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dtt);
                c.cerrar();
                return dtt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtt;
        }//fin linstar
        public string insertar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"insert into tipo_pago values ('{Getdescripcion()}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Tipo de pago creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin insertar
        public int Eliminar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from tipo_pago = '{Getdescripcion()}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                int filas = comando.ExecuteNonQuery();
                c.cerrar();
                return filas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//fin eliminar

        public string modificar(string descripcionAntigua)
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"update tipo_pago set descripcion = {Getdescripcion}  where descripcion = {descripcionAntigua}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                int com = comando.ExecuteNonQuery();
                c.cerrar();
                return "Tipo pago creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin modificar
    }
}


