using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShoes.Database.Entidades
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Porte { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public bool Castrado { get; set; }
        public bool Vacinado { get; set; }
        public string Temperamento { get; set; }
        public string ObservacoesMedicas { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Método utilizado para buscar todos os animais na base de dados. Utiliza a tabela ANIMAIS.
        /// </summary>
        /// <returns>Lista com os animais do banco</returns>
        public static List<Animal> GetAll()
        {
            var result = new List<Animal>();

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT ID_ANIMAL, 
                                    NOME, IDADE_ESTIMADA, PORTE,
                                    RACA, SEXO, CASTRADO, VACINADO, TEMPERAMENTO, 
                                    OBSERVACOES_MEDICAS, STATUS_ADOCAO, DATA_CADASTRO 
                                    FROM ANIMAIS;";

                    var cmd = new MySqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var animal = new Animal();

                            //animal.Id = reader.GetInt32("ID_ANIMAL");
                            animal.Id = reader.GetInt32(0);
                            animal.Nome = reader.GetString(1);
                            animal.Idade = reader.GetInt32(2);
                            animal.Porte = reader.GetString(3);
                            animal.Raca = reader.GetString(4);
                            animal.Sexo = reader.GetString(5);
                            animal.Castrado = reader.GetInt32(6) > 0;
                            animal.Vacinado = reader.GetInt32(7) > 0;
                            animal.Temperamento = reader.GetString(8);
                            animal.ObservacoesMedicas = reader.GetString(9);
                            animal.Status = reader.GetString(10);
                            animal.DataCadastro = reader.GetDateTime(11);
                            
                            result.Add(animal);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
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

                    //if ( Id == 0)
                    //{
                    // alterar para update
                        string query = $@"INSERT INTO ANIMAIS (
                            NOME, IDADE_ESTIMADA, PORTE, RACA, SEXO, CASTRADO, VACINADO, TEMPERAMENTO,
                            OBSERVACOES_MEDICAS, STATUS_ADOCAO, DATA_CADASTRO)
                            VALUES (@NOME, @IDADE_ESTIMADA, @PORTE, @RACA, @SEXO, @CASTRADO, @VACINADO, @TEMPERAMENTO,
                            @OBSERVACOES_MEDICAS, @STATUS_ADOCAO, NOW());";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NOME", Nome);
                    cmd.Parameters.AddWithValue("@IDADE_ESTIMADA", Idade);
                    cmd.Parameters.AddWithValue("@PORTE", Porte);
                    cmd.Parameters.AddWithValue("@RACA", Raca);
                    cmd.Parameters.AddWithValue("@SEXO", Sexo);
                    cmd.Parameters.AddWithValue("@CASTRADO", Castrado);
                    cmd.Parameters.AddWithValue("@VACINADO", Vacinado);
                    cmd.Parameters.AddWithValue("@TEMPERAMENTO", Temperamento);
                    cmd.Parameters.AddWithValue("@OBSERVACAOS_MEDICAS", ObservacoesMedicas);
                    cmd.Parameters.AddWithValue("@STATUS_ADOCAO", Status);

                    cmd.ExecuteNonQuery();

                    var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                    var id =  Convert.ToInt32(idCmd.ExecuteScalar());

                    //  DESAFIOOO  so insirra os dados na base se realmente tivar dados

                //}
                //    else
                //{ passar a query oara cá talvez de para usar o m´todo NomQuery aqui
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
            }
        }
    }
}
