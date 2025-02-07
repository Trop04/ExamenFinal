using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Controladores
{
    public class AutobusController
    {
        private string connectionString = "Server=.;Database=ExamenFinal;Trusted_Connection=True;";

        public DataTable ObtenerAutobuses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Autobus";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void AgregarAutobus(string placa, string modelo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Autobus (Placa, Modelo) VALUES (@Placa, @Modelo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Placa", placa);
                command.Parameters.AddWithValue("@Modelo", modelo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditarAutobus(int id, string placa, string modelo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Autobus SET Placa = @Placa, Modelo = @Modelo WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Placa", placa);
                command.Parameters.AddWithValue("@Modelo", modelo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarAutobus(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Autobus WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
