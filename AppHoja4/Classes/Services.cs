using MySql.Data.MySqlClient;
using AppHoja4;
using System;
using System.Data;
using Org.BouncyCastle.Cms;

namespace AppHoja4.Classes
{
    public class Services
    {

        public static class nCuentaGlobal{

            public static long numero_cuenta;
            public static long new_numero_cuenta;

        }

        public static void SaveUser(long DPICliente, string nombreCliente, string fecha, long telefono, string correoElectronico) {


            using (MySqlConnection connection = ConnectionDB.GetConnection()) { 
            
                string query = "INSERT INTO tbDatosClientes(DPI_cliente, nombre_cuenta, fecha_nacimiento, telefono, correo_elec) VALUES (@DPI_cliente, @nombre_cuenta, @fecha_nacimiento, @telefono, @correo)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@DPI_cliente", DPICliente);
                command.Parameters.AddWithValue("@nombre_cuenta", nombreCliente);
                command.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@correo", correoElectronico);
                command.ExecuteNonQuery();
                
            }
        
        }

        public static void LinkAccount(long DPICliente)
        {


            using (MySqlConnection connection = ConnectionDB.GetConnection())
            {
                Random random = new Random();
                int saldo = 0;
                try {
                    nCuentaGlobal.numero_cuenta = random.Next(10000000, 99999999);
                    string query = "INSERT INTO tbCuenta(numero_cuenta, DPI_cliente, saldo) VALUES (@numero_cuenta ,@DPI_cliente, @saldo)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numero_cuenta", nCuentaGlobal.numero_cuenta);
                    command.Parameters.AddWithValue("@DPI_cliente", DPICliente);
                    command.Parameters.AddWithValue("@saldo", saldo);
                    command.ExecuteNonQuery();

                }
                catch
                {
                    nCuentaGlobal.new_numero_cuenta = random.Next(10000000, 99999999);
                    string query = "INSERT INTO tbCuenta(numero_cuenta, DPI_cliente, saldo) VALUES (@numero_cuenta ,@DPI_cliente, @saldo)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numero_cuenta", nCuentaGlobal.new_numero_cuenta);
                    command.Parameters.AddWithValue("@DPI_cliente", DPICliente);
                    command.Parameters.AddWithValue("@saldo", saldo);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }

            }

        }

        public static DataTable SearchUser(long nCuenta)
        {
            
            using (MySqlConnection connection = ConnectionDB.GetConnection())
            {
                string query = "SELECT * FROM infoCuenta WHERE `Numero de Cuenta` =" + nCuenta.ToString();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {

                    DataTable tb = new DataTable();
                    adapter.Fill(tb);
                    return tb;

                };

            }

        }


        public static void UpdateUser(long numero_cuenta, int field, string dbfield)
        {


            using (MySqlConnection connection = ConnectionDB.GetConnection())
            {

                switch (field) {

                    case  1:
                        {

                            string query = "UPDATE tbDatosClientes SET nombre_cliente = @nombre_cliente WHERE numero_cuenta = @numero_cuenta";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@numero_cuenta", numero_cuenta);
                            command.Parameters.AddWithValue("@nombre_cliente", dbfield);
                            command.ExecuteNonQuery();

                        }
                        break;

                    case 2: {

                            string query = "UPDATE tbDatosCLientes SET fecha_nacimiento = @fecha_nacimiento WHERE numero_cuenta = @numero_cuenta";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@numero_cuenta", numero_cuenta);
                            command.Parameters.AddWithValue("@fecha_nacimiento", dbfield);
                            command.ExecuteNonQuery();

                        }
                        break;

                    case 3:
                        {

                            string query = "UPDATE tbDatosCLientes SET telefono = @telefono WHERE numero_cuenta = @numero_cuenta";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@numero_cuenta", numero_cuenta);
                            command.Parameters.AddWithValue("@telefono", dbfield);
                            command.ExecuteNonQuery();

                        }
                        break;

                    case 4:
                        {

                            string query = "UPDATE tbDatosCLientes SET correo_elec = @correo_elect WHERE numero_cuenta = @numero_cuenta";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@numero_cuenta", numero_cuenta);
                            command.Parameters.AddWithValue("@correo_elect", dbfield);
                            command.ExecuteNonQuery();

                        }
                        break;

                }



            }

        }

    }

}
