using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SISVideoJuegos
{




    public class cDatos
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BDVideoJuegos"].ConnectionString;

        /// <summary>
        /// Método auxiliar privado para centralizar la ejecución de Stored Procedures que retornan un DataSet.
        /// Garantiza la correcta liberación de recursos con bloques using.
        /// </summary>
        private DataSet EjecutarConsultaDataSet(string nombreProcedimiento, Action<SqlCommand> configurarParametros = null)
        {
            try
            {
                DataSet datos = new DataSet();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(nombreProcedimiento, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Configurar parámetros si los hay
                        configurarParametros?.Invoke(command);

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(datos);
                        }
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                // Aquí puede registrar el error si lo desea (ej. I/O o Log)
                return null;
            }
        }

        public bool PABuscarVideoJuego(string strunidad)
        {
            DataSet datos = EjecutarConsultaDataSet("PABuscarVideoJuego", cmd => {
                cmd.Parameters.Add("@DescripcionVideoJuego", SqlDbType.NVarChar, 50).Value = strunidad;
            });

            return datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0;
        }

        public bool PABuscarTipoVideoJuego(string strunidad)
        {
            DataSet datos = EjecutarConsultaDataSet("PABuscarTipoVideoJuego", cmd => {
                cmd.Parameters.Add("@DescripcionTipoVideoJuego", SqlDbType.NVarChar, 50).Value = strunidad;
            });

            return datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0;
        }

        public DataSet PAFiltrarCliente(string strCedula)
        {
            return EjecutarConsultaDataSet("PABuscarCliente", cmd => {
                cmd.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 50).Value = strCedula;
            });
        }

        public DataSet PAFiltrarClienteVideoJuegos(string strCedula)
        {
            return EjecutarConsultaDataSet("PAFiltrarClienteVideoJuegos", cmd => {
                cmd.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 9).Value = strCedula;
            });
        }

        public bool PABuscarCliente(string strCedula)
        {
            DataSet datos = EjecutarConsultaDataSet("PABuscarCliente", cmd => {
                cmd.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 50).Value = strCedula;
            });

            return datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0;
        }

        public DataSet PAModificarVideoJuego(int idVideoJuego, string descripcionVideoJuego, int idTipoVideoJuego)
        {
            return EjecutarConsultaDataSet("PAModificarVideoJuegos", cmd => {
                cmd.Parameters.Add("@IdVideoJuego", SqlDbType.Int).Value = idVideoJuego;
                cmd.Parameters.Add("@DescripcionVideoJuego", SqlDbType.NVarChar, 100).Value = descripcionVideoJuego;
                cmd.Parameters.Add("@IdTipoVideoJuego", SqlDbType.Int).Value = idTipoVideoJuego;
            });
        }

        public DataSet PAModificarTipoVideoJuego(int idTipoVideoJuego, string descripcionTipoVideoJuego, bool estatus)
        {
            return EjecutarConsultaDataSet("PAModificarTipoVideoJuegos", cmd => {
                cmd.Parameters.Add("@IdTipoVideoJuego", SqlDbType.Int).Value = idTipoVideoJuego;
                cmd.Parameters.Add("@DescripcionTipoVideoJuego", SqlDbType.NVarChar, 100).Value = descripcionTipoVideoJuego;
                cmd.Parameters.Add("@EstatusTipoVideoJuego", SqlDbType.Bit).Value = estatus;
            });
        }

        public DataSet PAModificarCliente(string cedula, string nombre, string apellido)
        {
            return EjecutarConsultaDataSet("PAModificarCliente", cmd => {
                cmd.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 9).Value = cedula;
                cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar, 50).Value = apellido;
            });
        }

        public DataSet PAInsertarVideoJuego(string strVideoJuego, int idTipoVideoJuego)
        {
            return EjecutarConsultaDataSet("PAInsertarVideoJuegos", cmd => {
                cmd.Parameters.Add("@DescripcionVideoJuego", SqlDbType.NVarChar, 150).Value = strVideoJuego;
                cmd.Parameters.Add("@IdTipoVideoJuego", SqlDbType.Int).Value = idTipoVideoJuego;
            });
        }

        public DataSet PAInsertarTipoVideoJuego(string strVideoJuego, bool estatusTipoVideoJuego)
        {
            return EjecutarConsultaDataSet("PAInsertarTipoVideoJuego", cmd => {
                cmd.Parameters.Add("@DescripcionTipoVideoJuego", SqlDbType.NVarChar, 150).Value = strVideoJuego;
                cmd.Parameters.Add("@EstatusTipoVideoJuego", SqlDbType.Bit).Value = estatusTipoVideoJuego;
            });
        }

        public DataSet PAInsertarCliente(string strCedula, string strNombre, string strApellido)
        {
            return EjecutarConsultaDataSet("PAInsertarCliente", cmd => {
                cmd.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 9).Value = strCedula;
                cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = strNombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar, 50).Value = strApellido;
            });
        }

        public DataSet PAInsertarClienteVideoJuegos(int idCliente, int idVideoJuego, DateTime fechaAlquiler)
        {
            return EjecutarConsultaDataSet("PAInsertarClienteVideoJuego", cmd => {
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
                cmd.Parameters.Add("@IdVideoJuego", SqlDbType.Int).Value = idVideoJuego;
                cmd.Parameters.Add("@FechaAlquiler", SqlDbType.DateTime).Value = fechaAlquiler;
            });
        }

        public DataSet PAMostrarVideoJuegos()
        {
            return EjecutarConsultaDataSet("PAMostrarVideoJuegos");
        }

        public DataSet PAMostrarTipoVideoJuegos()
        {
            return EjecutarConsultaDataSet("PAMostrarTipoVideJuegos");
        }

        public DataSet PAMostrarClientes()
        {
            return EjecutarConsultaDataSet("PAMostrarClientes");
        }

        public DataSet PAMostrarClientesVideoJuegos()
        {
            return EjecutarConsultaDataSet("PAMostrarClienteVideoJuegos");
        }

        public DataSet PAMostrarTipoVideJuegosActivos()
        {
            return EjecutarConsultaDataSet("PAMostrarTipoVideJuegosActivos");
        }
    }





    //public class cDatos
    // {

    //     string connectionString = ConfigurationManager.ConnectionStrings["BDVideoJuegos"].ConnectionString;


    //     public Boolean PABuscarVideoJuego(String strunidad)
    //     {
    //         //Objeto Dataset


    //         Boolean Buscar;
    //         try
    //         {
    //             DataSet datos = new DataSet();
    //             //Objeto Conexion
    //             SqlConnection connexion = new SqlConnection();
    //             //Objeto comnand
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PABuscarVideoJuego";
    //             command.Parameters.Add("@DescripcionVideoJuego", SqlDbType.NVarChar, 50).Value = strunidad;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);

    //             if (datos.Tables[0].Rows.Count > 0)
    //             {

    //                 Buscar = true;
    //             }

    //             else
    //             {

    //                 Buscar = false;


    //             }

    //             command.Connection.Close();
    //             command.Connection.Dispose();


    //             return Buscar;
    //         }
    //         catch (Exception e)
    //         {

    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return false;
    //         }
    //     }


    //     public Boolean PABuscarTipoVideoJuego(String strunidad)
    //     {
    //         Boolean Buscar;
    //         try
    //         {

    //             //Objeto Dataset

    //             DataSet datos = new DataSet();
    //             //Objeto Conexion
    //             SqlConnection connexion = new SqlConnection();
    //             //Objeto comnand
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PABuscarTipoVideoJuego";
    //             command.Parameters.Add("@DescripcionTipoVideoJuego", SqlDbType.NVarChar, 50).Value = strunidad;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);

    //             if (datos.Tables[0].Rows.Count > 0)
    //             {

    //                 Buscar = true;


    //             }

    //             else
    //             {

    //                 Buscar = false;


    //             }

    //             command.Connection.Close();
    //             command.Connection.Dispose();


    //             return Buscar;
    //         }
    //         catch (Exception e)
    //         {

    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return false;
    //         }
    //     }

    //     public DataSet PAFiltrarCliente(String strCedula)
    //     {
    //         //Objeto Dataset


    //         try
    //         {
    //             DataSet datos = new DataSet();
    //             //Objeto Conexion
    //             SqlConnection connexion = new SqlConnection();
    //             //Objeto comnand
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PABuscarCliente";
    //             command.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 50).Value = strCedula;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);



    //             command.Connection.Close();
    //             command.Connection.Dispose();


    //             return datos;

    //         }

    //         // Least specific:
    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);

    //             return null;
    //         }
    //     }


    //     public DataSet PAFiltrarClienteVideoJuegos(String strCedula)
    //     {
    //         //Objeto Dataset
    //         try
    //         {
    //             DataSet datos = new DataSet();
    //             //Objeto Conexion
    //             SqlConnection connexion = new SqlConnection();
    //             //Objeto comnand
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAFiltrarClienteVideoJuegos";
    //             command.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 9).Value = strCedula;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);



    //             command.Connection.Close();
    //             command.Connection.Dispose();


    //             return datos;

    //         }

    //         // Least specific:
    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }
    //     }

    //     public Boolean PABuscarCliente(String strCedula)
    //     {
    //         //Objeto Dataset
    //         Boolean Buscar;
    //         try
    //         {

    //             DataSet datos = new DataSet();
    //             //Objeto Conexion
    //             SqlConnection connexion = new SqlConnection();
    //             //Objeto comnand
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PABuscarCliente";
    //             command.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 50).Value = strCedula;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);

    //             if (datos.Tables[0].Rows.Count > 0)
    //             {
    //                 Buscar = true;
    //             }
    //             else
    //             {
    //                 Buscar = false;
    //             }

    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return Buscar;
    //         }
    //         catch (Exception e)
    //         {

    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return false;
    //         }
    //     }
    //     public DataSet PAModificarVideoJuego(int IdVideoJuego, String DescripcionVideoJuego, int IdTipoVideoJuego)
    //     {

    //         try
    //         {

    //             DataSet datos = new DataSet();
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAModificarVideoJuegos";
    //             command.Parameters.Add("@IdVideoJuego", SqlDbType.Int).Value = IdVideoJuego;
    //             command.Parameters.Add("@DescripcionVideoJuego", SqlDbType.NVarChar, 100).Value = DescripcionVideoJuego;
    //             command.Parameters.Add("@IdTipoVideoJuego", SqlDbType.Int).Value = IdTipoVideoJuego;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;

    //         }

    //         // Least specific:
    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }


    //     }


    //     public DataSet PAModificarTipoVideoJuego(int IdVideoJuego, String DescripcionVideoJuego, Boolean Estatus)
    //     {

    //         try
    //         {

    //             DataSet datos = new DataSet();
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAModificarTipoVideoJuegos";
    //             command.Parameters.Add("@IdTipoVideoJuego", SqlDbType.Int).Value = IdVideoJuego;
    //             command.Parameters.Add("@DescripcionTipoVideoJuego", SqlDbType.NVarChar, 100).Value = DescripcionVideoJuego;
    //             command.Parameters.Add("@EstatusTipoVideoJuego", SqlDbType.Bit).Value = Estatus;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;
    //         }


    //         catch (Exception e)
    //         {

    //             return null;
    //         }


    //     }


    //     public DataSet PAModificarCliente(String Cedula, String Nombre, String Apellido)
    //     {

    //         try
    //         {

    //             DataSet datos = new DataSet();
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAModificarCliente";
    //             command.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 9).Value = Cedula;
    //             command.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = Nombre;
    //             command.Parameters.Add("@Apellido", SqlDbType.NVarChar, 50).Value = Apellido;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;
    //         }


    //         catch (Exception e)
    //         {

    //             return null;
    //         }


    //     }

    //     public DataSet PAInsertarVideoJuego(string strVideoJuego, int IdTipoVideoJuego)
    //     {

    //         try
    //         {
    //             DataSet datos = new DataSet();
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAInsertarVideoJuegos";
    //             command.Parameters.Add("@DescripcionVideoJuego", SqlDbType.NVarChar, 150).Value = strVideoJuego;
    //             command.Parameters.Add("@IdTipoVideoJuego", SqlDbType.Int).Value = IdTipoVideoJuego;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();


    //             return datos;
    //         }


    //         catch (Exception e)
    //         {

    //             return null;
    //         }



    //     }

    //     public DataSet PAInsertarTipoVideoJuego(string strVideoJuego, Boolean EstatusTipoVideoJuego)
    //     {
    //         try
    //         {

    //             DataSet datos = new DataSet();
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAInsertarTipoVideoJuego";
    //             command.Parameters.Add("@DescripcionTipoVideoJuego", SqlDbType.NVarChar, 150).Value = strVideoJuego;
    //             command.Parameters.Add("@EstatusTipoVideoJuego", SqlDbType.Bit).Value = EstatusTipoVideoJuego;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();


    //             return datos;
    //         }


    //         catch (Exception e)
    //         {

    //             return null;
    //         }



    //     }

    //     public DataSet PAInsertarCliente(string strCedula, string strNombre, string strApellido)
    //     {

    //         try
    //         {
    //             DataSet datos = new DataSet();
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAInsertarCliente";
    //             command.Parameters.Add("@CedulaCliente", SqlDbType.NVarChar, 9).Value = strCedula;
    //             command.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = strNombre;
    //             command.Parameters.Add("@Apellido", SqlDbType.NVarChar, 50).Value = strApellido;
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();


    //             return datos;
    //         }


    //         catch (Exception e)
    //         {

    //             return null;
    //         }




    //     }

    //     public DataSet PAInsertarClienteVideoJuegos(int IdCliente, int IdVideoJuego, DateTime FechaAlquiler)
    //     {


    //         DataSet datos = new DataSet();
    //         SqlConnection connexion = new SqlConnection();
    //         SqlCommand command = new SqlCommand();
    //         SqlDataAdapter da = new SqlDataAdapter();
    //         connexion.ConnectionString = connectionString;
    //         command.Connection = connexion;
    //         command.CommandText = "PAInsertarClienteVideoJuego";
    //         command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = IdCliente;
    //         command.Parameters.Add("@IdVideoJuego", SqlDbType.Int).Value = IdVideoJuego;
    //         command.Parameters.Add("@FechaAlquiler", SqlDbType.DateTime).Value = FechaAlquiler;
    //         command.CommandType = CommandType.StoredProcedure;
    //         da.SelectCommand = command;
    //         da.Fill(datos);
    //         command.Connection.Close();
    //         command.Connection.Dispose();


    //         return datos;



    //     }
    //     public DataSet PAMostrarVideoJuegos()
    //     {
    //         try
    //         {
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             DataSet datos = new DataSet();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAMostrarVideoJuegos";
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;

    //         }

    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }
    //     }

    //     public DataSet PAMostrarTipoVideoJuegos()
    //     {
    //         try
    //         {
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             DataSet datos = new DataSet();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAMostrarTipoVideJuegos";
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;
    //         }

    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }
    //     }

    //     public DataSet PAMostrarClientes()
    //     {
    //         try
    //         {
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             DataSet datos = new DataSet();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAMostrarClientes";
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;
    //         }

    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }
    //     }

    //     public DataSet PAMostrarClientesVideoJuegos()
    //     {
    //         try
    //         {
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             DataSet datos = new DataSet();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAMostrarClienteVideoJuegos";
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;
    //         }

    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }
    //     }

    //     public DataSet PAMostrarTipoVideJuegosActivos()
    //     {
    //         try
    //         {
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             DataSet datos = new DataSet();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAMostrarTipoVideJuegosActivos";
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;
    //         }

    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }
    //     }

    //     public DataSet PAMostrarTipoVideJuegos()
    //     {
    //         try
    //         {
    //             SqlConnection connexion = new SqlConnection();
    //             SqlCommand command = new SqlCommand();
    //             SqlDataAdapter da = new SqlDataAdapter();
    //             DataSet datos = new DataSet();
    //             connexion.ConnectionString = connectionString;
    //             command.Connection = connexion;
    //             command.CommandText = "PAMostrarTipoVideJuegos";
    //             command.CommandType = CommandType.StoredProcedure;
    //             da.SelectCommand = command;
    //             da.Fill(datos);
    //             command.Connection.Close();
    //             command.Connection.Dispose();
    //             return datos;
    //         }

    //         catch (Exception e)
    //         {
    //             //Console.WriteLine("{0} Second exception caught.", e);
    //             return null;
    //         }



    //     }
    // }
}
