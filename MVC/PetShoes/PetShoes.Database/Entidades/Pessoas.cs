using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PetShoes.Database.Entidades
{
    public class Pessoa
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Tipo_Usuario { get; set; }

        public static List<Pessoa> GetAllPessoa()
        {
            var result = new List<Pessoa>();

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT ID_PESSOA, NOME, CPF, DATA_NASCIMENTO, 
                                     EMAIL, TELEFONE, ENDERECO, TIPO_USUARIO
                                     FROM PESSOAS;
";

                    var cmd = new MySqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pessoa = new Pessoa();

                            pessoa.Id = reader.GetInt32(0);
                            pessoa.Nome = reader.GetString(1);
                            pessoa.CPF = reader.GetString(2);
                            pessoa.Data_Nascimento = reader.GetDateTime(3);
                            pessoa.Email = reader.GetString(4);
                            pessoa.Telefone = reader.GetString(5);
                            pessoa.Endereco = reader.GetString(6);
                            pessoa.Tipo_Usuario = reader.GetString(7);

                            result.Add(pessoa);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoas na base de dados. Mensagem: {error.Message}");
            }

            return result;
        }

        public static Pessoa Get(int id)
        {
            Pessoa result = null;

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT ID_PESSOA, 
                                    NOME, CPF, DATA_NASCIMENTO,
                                    EMAIL, TELEFONE, ENDERECO, TIPO_USUARIO;";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_ANIMAL", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Pessoa();

                            result.Id = reader.GetInt32(0);
                            result.Nome = reader.GetString(1);
                            result.CPF = reader.GetString(2);
                            result.Data_Nascimento = reader.GetDateTime(3);
                            result.Email = reader.GetString(4);
                            result.Telefone = reader.GetString(5);
                            result.Endereco = reader.GetString(6);
                            result.Tipo_Usuario = reader.GetString(7);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoa na base de dados. Mensagem: {error.Message}");
            }

            return result;
        }

        public void Save()
        {
            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = string.Empty;
                    if (Id.HasValue)
                    {


                        query = @"UPDATE PESSOA SET NOME = NOME, CPF = CPF, DATA_NASCIMENTO = DATA_NASCIMENTO,
                                     EMAIL = EMAIL, TELEFONE = TELEFONE, ENDERECO = ENDERECO, TIPO_USUARIO = TIPO_USUARIO";
                    }
                    else
                    {
                        query = @"INSERT INTO PESSOAS ( 
                                     NOME, CPF, DATA_NASCIMENTO,
                                     EMAIL, TELEFONE, ENDERECO, TIPO_USUARIO)
                                     VALUES (@NOME, @CPF, DATA_NASCIMENTO, @EMAIL, @TELEFONE, @ENDERECO, @TIPO_USUARIO, NOW())";
                    }


                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_PESSOA", Id);
                    cmd.Parameters.AddWithValue("@NOME", Nome);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", Data_Nascimento);
                    cmd.Parameters.AddWithValue("@EMAIL", Email);
                    cmd.Parameters.AddWithValue("@TELEFONE", Telefone);
                    cmd.Parameters.AddWithValue("@ENDERECO", Endereco);
                    cmd.Parameters.AddWithValue("@TIPO_USUSARIO", Tipo_Usuario);

                    cmd.ExecuteNonQuery();

                    if (!Id.HasValue)
                    {
                        var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                        Id = Convert.ToInt32(idCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoas na base de dados. Mensagem: {error.Message}");
            }
        }

        public void Delete()
        {
            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @$"DELETE FROM PESSOAS WHERE IDPESSOA = @IDPESSOA";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDPESSOA", Id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoas na base de dados. Mensagem: {error.Message}");
            }
        }

    }

}


