using MySql.Data.MySqlClient;
using System.Data;

namespace projeto2B.Repositorio
{
    public class Conexao: IDisposable
    {
        private MySqlConnection _connection;


        public MySqlCommand MySqlCommand()
        {
            return _connection.CreateCommand();
        }

        // abre a conexão
        public Conexao(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }
        
        
        //fecha a conexão
        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
    }
    }

