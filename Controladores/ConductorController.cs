using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinal.Modelos;

namespace ExamenFinal.Controladores
{
    public class ConductorController
    {
        private string connectionString = "Server=.;Database=ExamenFinal;Trusted_Connection=True;";

        public DataTable ObtenerConductores()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Conductor";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void AgregarConductor(string nombre, string licencia)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Conductor (Nombre, Licencia) VALUES (@Nombre, @Licencia)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Licencia", licencia);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditarConductor(int id, string nombre, string licencia)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Conductor SET Nombre = @Nombre, Licencia = @Licencia WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Licencia", licencia);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarConductor(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Conductor WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
