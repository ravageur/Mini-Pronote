using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Pronote
{
    public partial class PronoteProfesseur : Form
    {
        private string nomEtudiant;
        private MySqlConnection connexion = new MySqlConnection("Server=127.0.0.1,3306;database=pronote;user id=root;password=");
        public PronoteProfesseur()
        {
            InitializeComponent();
        }

        private void PronoteProfesseur_Load(object sender, EventArgs e)
        {
            affichageDuTableau();
        }

        private void listBoxEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomEtudiant = listBoxEtudiant.Items[listBoxEtudiant.SelectedIndex].ToString();
            nomEtudiant = nomEtudiant.Remove(nomEtudiant.Length - 12);
        }

        /// <summary>
        /// Ce bouton permet de mettre un élève absent par rapport a le nom de l'élève cliqué dans une liste par le professeur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEleveAbsent_Click(object sender, EventArgs e)
        {
            string requete = "insert into informationssurchaqueetudiant values (null, @nomEtudiant, DATE(NOW()));";
            MySqlParameter parametre = new MySqlParameter();
            parametre.ParameterName = "@nomEtudiant";
            parametre.MySqlDbType = MySqlDbType.String;
            parametre.Value = nomEtudiant;
            MySqlCommand commande = new MySqlCommand(requete, connexion);
            commande.Parameters.Add(parametre);
            try
            {
                connexion.Open();
                commande.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show("La base de donnée n'est pas accessible pour le moment, veuillez réessayer plus tard.\n\nDétails de l'erreur a transmettre si le problème persiste :\n\n" + exception);
            }
            connexion.Close();
            affichageDuTableau();
        }

        /// <summary>
        /// Ce bouton permet de mettre un élève présent par rapport a le nom de l'élève cliqué dans une liste par le professeur. 
        /// Par défaut l'élève est présent mais il se peut que le professeur peut faire une erreur ou que l'élève ai eu un imprévu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonElevePresent_Click(object sender, EventArgs e)
        {
            MySqlParameter parametre = new MySqlParameter();
            parametre.ParameterName = "@nomEtudiant";
            parametre.MySqlDbType = MySqlDbType.String;
            parametre.Value = nomEtudiant;
            MySqlCommand commande = new MySqlCommand("delete from informationssurchaqueetudiant where NomEtudiant = @nomEtudiant;", connexion);
            commande.Parameters.Add(parametre);
            try
            {
                connexion.Open();
                commande.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show("La base de donnée n'est pas accessible pour le moment, veuillez réessayer plus tard.\n\nDétails de l'erreur a transmettre si le problème persiste :\n\n" + exception);
            }
            connexion.Close();
            affichageDuTableau();
        }

        /// <summary>
        /// Cette méthode permet d'actualiser la liste des élèves avec ceux présents ou pas présents.
        /// </summary>
        private void affichageDuTableau()
        {
            listBoxEtudiant.Items.Clear();
            try
            {
                MySqlParameter parametre = new MySqlParameter();
                MySqlCommand commande = new MySqlCommand("", connexion);
                commande.Parameters.Add(parametre);
                string resultatDeLaRequete;
                connexion.Open();
                for (int i = 0; i < i + 1; i++)
                {
                    parametre = setParametre(parametre, "@i", MySqlDbType.Int16);
                    parametre.Value = i;
                    commande.CommandText = "select nomUtilisateur from utilisateurs limit 1 offset @i; ";
                    resultatDeLaRequete = Convert.ToString(commande.ExecuteScalar()); //Si il ne trouve pas de valeur, resultatDeLaRequete = "";    
                    if (resultatDeLaRequete.Equals("") && i != 0)
                    {
                        break;
                    }
                    else
                    {
                        commande.CommandText = "select NomEtudiant from informationssurchaqueetudiant where NomEtudiant = @nomEtudiant;";
                        setParametre(parametre, "@nomEtudiant", MySqlDbType.String);
                        parametre.Value = resultatDeLaRequete;
                        string resultat2 = Convert.ToString(commande.ExecuteScalar());
                        if (resultat2.Equals(""))
                        {
                            resultatDeLaRequete = resultatDeLaRequete + " est présent";
                        }
                        else
                        {
                            resultatDeLaRequete = resultatDeLaRequete + " est absent ";
                        }
                        listBoxEtudiant.Items.Add(resultatDeLaRequete);
                    }
                }
                
                connexion.Close();
            }
            catch (Exception exceptionListeBox)
            {
                MessageBox.Show("La base de donnée n'est pas accessible pour le moment, veuillez réessayer plus tard.\n\nDétails de l'erreur a transmettre si le problème persiste :\n\n" + exceptionListeBox);
            }
        }

        /// <summary>
        /// Permet de set les paramètres d'une instance de paramètre de MysqlParameter assez facilement.
        /// </summary>
        /// <param name="parametre"></param>
        /// <param name="nomDuParametre"></param>
        /// <param name="typeDeDonne"></param>
        /// <param name="valeurDuParametre"></param>
        /// <returns></returns>
        private MySqlParameter setParametre(MySqlParameter parametre, string nomDuParametre, MySqlDbType typeDeDonne)
        {
            parametre.ParameterName = nomDuParametre;
            parametre.MySqlDbType = typeDeDonne;
            return parametre;
        }

    }
}
