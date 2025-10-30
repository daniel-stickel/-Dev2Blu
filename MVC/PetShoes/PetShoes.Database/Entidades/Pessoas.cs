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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string TipoUsuario { get; set; }

        public static List<Pessoa> GetAllPessoa()
        {
            var result = new List<Pessoa>();

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT ID_PESSOA, 
                                    NOME, CPF, DATANASCIMENTO,
                                    EMAIL, TELEFONE, ENDERECO, TIPOUSUARIO;";

                    var cmd = new MySqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pessoa = new Pessoa();

                            pessoa.Id = reader.GetInt32(0);
                            pessoa.Nome = reader.GetString(1);
                            pessoa.CPF = reader.GetString(2);
                            pessoa.DataNascimento = reader.GetDateTime(3);
                            pessoa.Email = reader.GetString(4);
                            pessoa.Telefone = reader.GetString(5);
                            pessoa.TipoUsuario = reader.GetString(6);

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
                                    NOME, CPF, DATANASCIMENTO,
                                    EMAIL, TELEFONE, TIPOUSUARIO;";

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
                            result.DataNascimento = reader.GetDateTime(3);
                            result.Email = reader.GetString(4);
                            result.Telefone = reader.GetString(5);
                            result.TipoUsuario = reader.GetString(6);
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

        //    public void Save()
        //    {
        //        try
        //        {
        //            using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
        //            {
        //                conn.Open();
        //                string query = string.Empty;
        //                if (Id.HasValue)
        //                {
        //                    query = @"UPDATE ANIMAIS SET NOME = @NOME, IDADE_ESTIMADA = @IDADE_ESTIMADA, PORTE = @PORTE, 
        //                            RACA = @RACA, SEXO = @SEXO, CASTRADO = @CASTRADO, VACINADO = @VACINADO, TEMPERAMENTO = @TEMPERAMENTO,
        //                            OBSERVACOES_MEDICAS = @OBSERVACOES_MEDICAS, STATUS_ADOCAO = @STATUS_ADOCAO
        //                            WHERE ID_ANIMAL = @ID_ANIMAL";
        //                }
        //                else
        //                {
        //                    query = @"INSERT INTO PESSOAS (
        //                             ID_PESSOA, 
        //                             NOME, CPF, DATANASCIMENTO,
        //                             EMAIL, TELEFONE, TIPOUSUARIO;"" NOW())";
        //                }


        //                var cmd = new MySqlCommand(query, conn);
        //                cmd.Parameters.AddWithValue("@ID_ANIMAL", Id);
        //                cmd.Parameters.AddWithValue("@NOME", Nome);
        //                cmd.Parameters.AddWithValue("@IDADE_ESTIMADA", Idade);
        //                cmd.Parameters.AddWithValue("@PORTE", Porte);
        //                cmd.Parameters.AddWithValue("@RACA", Raca);
        //                cmd.Parameters.AddWithValue("@SEXO", Sexo);
        //                cmd.Parameters.AddWithValue("@CASTRADO", Castrado);
        //                cmd.Parameters.AddWithValue("@VACINADO", Vacinado);
        //                cmd.Parameters.AddWithValue("@TEMPERAMENTO", Temperamento);
        //                cmd.Parameters.AddWithValue("@OBSERVACOES_MEDICAS", ObservacoesMedicas);
        //                cmd.Parameters.AddWithValue("@STATUS_ADOCAO", Status);

        //                cmd.ExecuteNonQuery();

        //                if (!Id.HasValue)
        //                {
        //                    var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
        //                    Id = Convert.ToInt32(idCmd.ExecuteScalar());
        //                }
        //            }
        //        }
        //        catch (Exception error)
        //        {
        //            throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
        //        }
        //    }

        //    public void Delete()
        //    {
        //        try
        //        {
        //            using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
        //            {
        //                conn.Open();
        //                string query = @$"DELETE FROM ANIMAIS WHERE ID_ANIMAL = @ID_ANIMAL";

        //                var cmd = new MySqlCommand(query, conn);
        //                cmd.Parameters.AddWithValue("@ID_ANIMAL", Id);

        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //        catch (Exception error)
        //        {
        //            throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
        //        }
        //    }

        //}

    }
}

