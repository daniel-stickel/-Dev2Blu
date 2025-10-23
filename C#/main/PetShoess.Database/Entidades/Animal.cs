using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShoess.Database.Entidades
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }
        public string Porte { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public bool Castrado { get; set; }
        public bool Vacinado { get; set; }
        public string Temperamento { get; set; }
        public string ObsevacoesMedicas { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Animal> GetAll()
        {
            var result = new List<Animal>();

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"select Id_animal
                                    , nome, idade_estimada, porte,
                                     raca, sexo, castrado, vacinado, temperamento,
                                    observacao_medica, status_adocao, data_cadastro from animais;";
                    var cmd = new MySqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var animal = new Animal();

                            result.Add(animal);

                            //animal.Id = reader.GetInt32("Id_animal"); pode usar dessa forma também 
                            animal.Id = reader.GetInt32(0);
                            animal.Name = reader.GetString(1);
                            animal.Idade = reader.GetInt32(2);
                            animal.Porte = reader.GetString(3);
                            animal.Raca = reader.GetString(4);
                            animal.Sexo = reader.GetString(5);
                            animal.Castrado = reader.GetInt32(6) > 0;
                            animal.Vacinado = reader.GetInt32(7) > 0;
                            animal.Temperamento = reader.GetString(8);
                            animal.ObsevacoesMedicas = reader.GetString(9);
                            animal.Status = reader.GetString(10);
                            animal.DataCadastro = reader.GetDateTime(11);

                            result.Add(animal);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar animais nba base de dados. Mensagem: {error.Message}");
            }
            return result;
        }

    }
}
