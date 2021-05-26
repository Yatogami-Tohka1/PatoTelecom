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
        public static void AtivarLinha(int idLinha)
        {
            sql.CommandText = $"UPDATE Linhas SET Ativa = '1' WHERE Id = '{idLinha}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void DesativarLinha(int idLinha)
        {
            sql.CommandText = $"UPDATE Linhas SET Ativa = '0' WHERE Id = '{idLinha}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void AdicionarOuModificarCliente(Cliente c)
        {
            sql.CommandText = $"UPDATE Clientes SET Nome = '{c.Nome}', CPF = '{c.Cpf}', Telefone = '{c.Telefone}', CEP = '{c.Cep}', Estado = '{c.Estado}', Cidade = '{c.Cidade}', Rua = '{c.Rua}', Numero = '{c.Numero}', Complemento = '{c.Complemento}' WHERE CPF = '{c.Cpf}'";

            int i = Executar(out SqlDataAdapter adaptador);

            if (i > 0) return;
            sql.CommandText = $"INSERT INTO Clientes (Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento) VALUES ('{c.Nome}', '{c.Cpf}', '{c.Telefone}', '{c.Cep}', '{c.Estado}', '{c.Cidade}', '{c.Rua}', '{c.Numero}', '{c.Complemento}')";
            Executar(out SqlDataAdapter adapatador);
        }
        public static void AdicionarOuModificarPlano(Plano p)
        { 
            sql.CommandText = $"UPDATE Planos SET NomePlano = '{p.Nome}', Franquia = '{p.Franquia}', CI = '{p.Ci}', Caracteristicas = '{p.Caracteristicas}', Mensalidade = '{p.Mensalidade}' WHERE Id = '{p.Id}'";

            int i = Executar(out SqlDataAdapter adaptador);

            if (i > 0) return;
            sql.CommandText = $"INSERT INTO Planos (NomePlano, Franquia, CI, Caracteristicas, Mensalidade) VALUES ('{p.Nome}', '{p.Franquia}', '{p.Ci}', '{p.Caracteristicas}', '{p.Mensalidade}')";
            Executar(out SqlDataAdapter adapatador);
        }
        public static void AdicionarOuModificarLinha(Linha l)
        {
            sql.CommandText = $"UPDATE Linhas SET NomeCliente = '{l.Cliente.Nome}', idCliente = '{l.IdCliente}', PlanoContratado = '{l.Plano.Nome}', idPlano = '{l.IdPlano}',  NumeroLinha = '{l.Numero}', DataContratacao = '{l.Contratacao}', Mensalidade = '{l.Mensalidade}', Ativa = '{l.Ativa}' WHERE Id = '{l.Id}'";

            int i = Executar(out SqlDataAdapter adaptador);

            if (i > 0) return;
            sql.CommandText = $"INSERT INTO Linhas (NomeCliente, idCliente, PlanoContratado, idPlano, NumeroLinha, DataContratacao, Mensalidade, Ativa) VALUES ('{l.Cliente.Nome}', '{l.IdCliente}', '{l.Plano.Nome}', '{l.IdPlano}', '{l.Numero}', '{l.Contratacao}', '{l.Mensalidade}', '{l.Ativa}')";
            Executar(out SqlDataAdapter adapatador);
        }
        //Remover
        public static void RemoverCliente(int id)
        {
            sql.CommandText = $"DELETE FROM Clientes WHERE Id = '{id}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void RemoverPlano(int id)
        {
            sql.CommandText = $"DELETE FROM Planos WHERE Id = '{id}'";
            Executar(out SqlDataAdapter adaptador);
        }
        //Retornar
        public static int RetornarId(string Table, string Coluna, string Dado)
        {
            sql.CommandText = $"SELECT Id FROM {Table} WHERE {Coluna} = '{Dado}'";
            Executar(out SqlDataAdapter adaptador);
            DataSet ds = new DataSet(); adaptador.Fill(ds, "ID");
            foreach (DataRow Row in ds.Tables["ID"].Rows)
            {
                int id = int.Parse(Row["Id"].ToString());
                return id;
            }
            return 0;   
        }
        public static SqlDataAdapter RetornarClientes()
        {
            sql.CommandText = "SELECT Id, Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento FROM Clientes";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter RetornarLinhas()
        {
            sql.CommandText = "SELECT ID, NomeCliente, idCliente, PlanoContratado, idPlano, NumeroLinha, DataContratacao, Mensalidade, Ativa FROM Linhas";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter RetornarPlanos()
        {
            sql.CommandText = "SELECT Id, NomePlano, Franquia, CI, Caracteristicas, Mensalidade FROM Planos";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter RetornarClientesCaracteristica(string tipo, string arg)
        {
            sql.CommandText = $"SELECT Id, Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento FROM Clientes WHERE {tipo} LIKE '%{arg}%'";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter RetornarPlanoCaracteristica(string tipo, string arg)
        {
            sql.CommandText = $"SELECT Id, NomePlano, Franquia, CI, Caracteristicas, Mensalidade FROM Planos WHERE {tipo} LIKE '%{arg}%'";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter RetornarLinhaCaracteristica(string tipo, string arg)
        {
            sql.CommandText = $"SELECT ID, NomeCliente, idCliente, PlanoContratado, idPlano, NumeroLinha, DataContratacao, Mensalidade, Ativa FROM Linhas WHERE {tipo} LIKE '%{arg}%'";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter RetornarLinhasCliente(int idCliente)
        {
            sql.CommandText = $"SELECT ID, NomeCliente, idCliente, PlanoContratado, idPlano, NumeroLinha, DataContratacao, Mensalidade, Ativa FROM Linhas WHERE idCliente = '{idCliente}'";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        //Modificar
        public static void ModificarLinhas(Plano p, int idLinha)
        {
            sql.CommandText = $"UPDATE Linhas SET PlanoContratado = '{p.Nome}', idPlano = '{p.Id}', Mensalidade = '{p.Mensalidade}' WHERE Id = '{idLinha}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void ModificarClienteNaTableLinhas(int id, string nome, string telefone)
        {
            sql.CommandText = $"UPDATE Linhas SET NomeCliente = '{nome}', NumeroLinha = '{telefone}' WHERE idCliente = '{id}'";
            Executar(out SqlDataAdapter adaptador);
            
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
        public static Plano RetornarPlanoUnico(int idPlano)
        {
            sql.CommandText = $"SELECT Id, NomePlano, Franquia, CI, Caracteristicas, Mensalidade FROM Planos WHERE Id = '{idPlano}'";
            Executar(out SqlDataAdapter adaptador);

            DataSet ds = new DataSet(); adaptador.Fill(ds, "Plano");
            foreach (DataRow Row in ds.Tables["Plano"].Rows)
            {
                string ID = Row["Id"].ToString();
                string NomePlano = Row["NomePlano"].ToString();
                string Franquia = Row["Franquia"].ToString();
                string CI = Row["CI"].ToString();
                string Caracteristicas = Row["Caracteristicas"].ToString();
                string Mensalidade = Row["Mensalidade"].ToString();
                Plano retornar = new Plano(NomePlano, Franquia, Caracteristicas, CI, Mensalidade);
                retornar.Id = ID;
                return retornar;
            }
            return null;
        }
        public static Cliente RetonarClientePorId(int id)
        {
            sql.CommandText = $"SELECT Id, Nome, CPF, Telefone, CEP, Estado, Cidade, Rua, Numero, Complemento FROM Clientes WHERE Id = '{id}'";
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
