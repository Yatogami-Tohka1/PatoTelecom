using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PatoTelecom
{
    class DataBase
    {
        private static SqlConnection conexao = new SqlConnection();
        private static SqlCommand sql = new SqlCommand();
        private static SqlDataAdapter Inicializar()
        {
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=PatoTelecom;Integrated Security=True";
            sql.Connection = conexao;
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
            return adaptador;
            
        }
        public static int Executar(out SqlDataAdapter adaptador)
        {
            conexao.Close();
            adaptador = Inicializar();
            int i = 0;
            conexao.Open();
            i = sql.ExecuteNonQuery();
            conexao.Close();
            return i;
        }
        //Adicionar
        public static void AdicionarOuModificarCliente(Cliente c)
        {
            sql.CommandText = $"UPDATE Clientes SET Nome = '{c.Nome}', CPF = '{c.Cpf}', Telefone = '{c.Telefone}', CEP = '{c.Cep}', Estado = '{c.Estado}', Cidade = '{c.Cidade}', Rua = '{c.Rua}', Numero = '{c.Numero}', Complemento = '{c.Complemento}' WHERE CPF = '{c.Cpf}'";

            int i = Executar(out SqlDataAdapter adaptador);

            if (i > 0) return;
            sql.CommandText = $"INSERT INTO Clientes (Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento) VALUES ('{c.Nome}', '{c.Cpf}', '{c.Telefone}', '{c.Cep}', '{c.Estado}', '{c.Cidade}', '{c.Rua}', '{c.Numero}', '{c.Complemento}')";
            Executar(out SqlDataAdapter adapatador);
        }
        //Remover
        public static void RemoverCliente(string cpf)
        {
            sql.CommandText = $"DELETE FROM Clientes WHERE CPF = '{cpf}'";
            Executar(out SqlDataAdapter adaptador);
        }
        //Retornar
        public static SqlDataAdapter RetornarClientes()
        {
            sql.CommandText = "SELECT Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento FROM Clientes";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        //RetornarUnico
        public static Cliente RetornarClienteUnico(string cpf)
        {
            sql.CommandText = $"SELECT Id, Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento FROM Clientes WHERE CPF = '{cpf}'";
            Executar(out SqlDataAdapter adaptador);

            DataSet ds = new DataSet(); adaptador.Fill(ds, "Cliente");
            foreach (DataRow Row in ds.Tables["Cliente"].Rows)
            {
                string Nome = Row["Nome"].ToString();
                string CPF = Row["CPF"].ToString();
                string Telefone = Row["Telefone"].ToString();
                string CEP = Row["CEP"].ToString();
                string Estado = Row["Estado"].ToString();
                string Cidade = Row["Cidade"].ToString();
                string Rua = Row["Rua"].ToString();
                string Numero = Row["Numero"].ToString();
                string Complemento = Row["Complemento"].ToString();
                string ID = Row["Id"].ToString();
                Cliente retornar = new Cliente(Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento);
                retornar.Id = ID;
                return retornar;
            }
            return null;
        }

    }
}
