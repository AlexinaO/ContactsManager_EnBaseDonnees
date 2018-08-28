using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.DAL
{
    public class DonneesContactBase : IDonneesContact
    {
        public void Enregistrer(Contact contact)
        {
            if (contact.Id == 0)
            {
                Ajouter(contact);
            }
            else
            {
                Modifier(contact);
            }
        }

        public IEnumerable<Contact> GetListe()
        {
            var listeContacts = new List<Contact>();

            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText = "SELECT * FROM Contacts";
                var reader = commande.ExecuteReader();
                while (reader.Read())
                {
                    var indexColonneDateNaissance = reader.GetOrdinal("DateNaissance");

                    var contact = new Contact();
                    contact.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    contact.Nom = reader.GetString(reader.GetOrdinal("Nom"));
                    contact.Prenom = reader.GetString(reader.GetOrdinal("Prenom"));
                    contact.Email = reader.GetNullableString(reader.GetOrdinal("Email"));
                    contact.Telephone = reader.GetNullableString(reader.GetOrdinal("Telephone"));
                    contact.DateNaissance = reader.IsDBNull(indexColonneDateNaissance)
                                                ? (DateTime?)null
                                                : reader.GetDateTime(indexColonneDateNaissance);

                    listeContacts.Add(contact);
                }
            }

            return listeContacts;
        }

        public void Supprimer(Contact contact)
        {
            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText = "DELETE Contacts WHERE Id = @IdContact";
                commande.Parameters.AddWithValue("@IdContact", contact.Id);
                commande.ExecuteNonQuery();
            }
        }

        private void Ajouter(Contact contact)
        {
            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText =
                    @"INSERT INTO Contacts (Nom, Prenom, Email, Telephone, DateNaissance)
                        VALUES (@Nom, @Prenom, @Email, @Telephone, @DateNaissance)";
                commande.Parameters.AddWithValue("@Nom", contact.Nom);
                commande.Parameters.AddWithValue("@Prenom", contact.Prenom);
                commande.Parameters.AddWithValue("@Email", contact.Email.NullIfNotSet());
                commande.Parameters.AddWithValue("@Telephone", contact.Telephone.NullIfNotSet());
                commande.Parameters.AddWithValue("@DateNaissance", contact.DateNaissance.NullIfNotSet());
                commande.ExecuteNonQuery();
            }
        }

        private void Modifier(Contact contact)
        {
            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText =
                    @"UPDATE Contacts SET Nom = @Nom, Prenom = @Prenom, 
                                          Email = @Email, Telephone = @Telephone,
                                          DateNaissance = @DateNaissance
                      WHERE Id = @Id";
                commande.Parameters.AddWithValue("@Id", contact.Id);
                commande.Parameters.AddWithValue("@Nom", contact.Nom);
                commande.Parameters.AddWithValue("@Prenom", contact.Prenom);
                commande.Parameters.AddWithValue("@Email", contact.Email.NullIfNotSet());
                commande.Parameters.AddWithValue("@Telephone", contact.Telephone.NullIfNotSet());
                commande.Parameters.AddWithValue("@DateNaissance", contact.DateNaissance.NullIfNotSet());
                commande.ExecuteNonQuery();
            }
        }

        private SqlConnection CreerConnexion()
        {
            return new SqlConnection(
                ConfigurationManager
                .ConnectionStrings["Connexion"]
                .ConnectionString);
        }
    }
}
