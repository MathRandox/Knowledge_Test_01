using Npgsql;
using System;

namespace Prueba.Datos
{
    public class Conexion
    {
        private string DataBase;
        private string Server;
        private string PortServer;
        private string User;
        private string Password;
        private Conexion Con = null;

        public Conexion()
        {
            this.DataBase = Environment.GetEnvironmentVariable("DB_Server");
            this.Server = Environment.GetEnvironmentVariable("DB_NAME");
            this.PortServer = Environment.GetEnvironmentVariable("DB_PORT");
            this.User = Environment.GetEnvironmentVariable("DB_USER");
            this.Password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        }

        public NpgsqlConnection CreateConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            try
            {
                connection.ConnectionString = $"Server={this.Server}" +
                                                $";Port={this.PortServer}" +
                                                $";User Id={this.User}" +
                                                $";Password={this.Password}" +
                                                $";Database={this.DataBase};";
            }
            catch(Exception ex)
            {
                connection = null;
                throw ex;
            }
            return connection;
        }
    }
}
