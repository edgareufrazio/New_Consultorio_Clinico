using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_sala
{
    internal class Connection
    {
        public readonly string string_connection = "Data Source=VPR0681563W11-1\\SQLEXPRESS;Persist Security Info=True;User ID=sa;Password=123456;Trust Server Certificate=True";
        SqlConnection conn;

        public SqlConnection Conectar()

        {
            conn = new SqlConnection(string_connection);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Conexão aberta com o banco de dados!");
            }
            return conn;
        }
        public void Desconectar()
        {
            conn.Close();
            MessageBox.Show("Conexão Encerrada!");
        }
    }
        
        
            

        
        
    }

