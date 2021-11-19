using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek7
{
    class BankManager
    {
        public void GetAllCounts()
        {
            const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Conto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //const string connectionString = @"";
            
            SqlConnection connection = null;
            try
            {

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from Conto";

                    SqlDataReader reader = command.ExecuteReader();

                    List<Conto> listaConti = new List<Conto>();

                    while (reader.Read())
                    {
                        var NumeroConto = reader["NumeroConto"];
                        var Credito = reader["Credito"];
                        var CodiceUtente = reader["CodiceUtente"];


                        Utente u = new Utente();
                        u.CodiceCliente = (int)CodiceUtente;


                        Conto conto = new Conto();
                        conto = new Conto((int)NumeroConto, (decimal)Credito, u);
                        listaConti.Add(conto);

                        Console.WriteLine($" Numero Conto:{NumeroConto} - Credito:{Credito}-Codice Utente:{CodiceUtente}");

                    }
                }
            }


            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Errore di Connessione: {ae.Message}");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);

            }
          
            finally  //con i file e i DB devo sempre chiudere il collegamento
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
 