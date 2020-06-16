using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Pronote
{
    public partial class Page_Connexion : Form
    {
        public Page_Connexion()
        {
            InitializeComponent();
        }

        private void Page_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void bouttonConnexion(object sender, EventArgs e)
        {
            string requete, nomUtilisateur, motDePasse; //[Note] : A ne jamais faire cela dans une entreprise, ce genre de déclaration n'est pas toujours faciles a regarder et à comprendre.
            nomUtilisateur = "";
            motDePasse = "";
            try
            {
                MySqlConnection connexion = new MySqlConnection("Server=127.0.0.1,3306;database=pronote;user id=root;password=");//datasource=127.0.0.1;port=3306;username=root;password=;database=inscription;                
                requete = "select nomUtilisateur from utilisateurs where nomUtilisateur = @nameUser;";
                MySqlCommand commande = new MySqlCommand(requete, connexion);
                commande.Parameters.AddWithValue("@nameUser", textBoxNomUtilisateur.Text);
                connexion.Open();
                nomUtilisateur = Convert.ToString(commande.ExecuteScalar());
                try
                {
                    commande.CommandText = "select motDePasse from utilisateurs where motDePasse = @passwordUser";
                    commande.Parameters.AddWithValue("@passwordUser", textBoxMotDePasse.Text);
                    motDePasse = (string)commande.ExecuteScalar();
                    connexion.Clone();
                }
                catch(Exception exception2)
                {
                    MessageBox.Show("La base de donnée a quelques problèmes, veuillez réessayez plus tard.\n\nDétails de l'erreur a transmettre si le problème persiste :\n\n" + exception2);
                }
            }
            catch(Exception exception1)
            {
                MessageBox.Show("La base de donnée n'est pas accessible pour le moment, veuillez réessayer plus tard.\n\nDétails de l'erreur a transmettre si le problème persiste :\n\n" + exception1);
            }
            if(textBoxNomUtilisateur.Text.Equals(nomUtilisateur) && textBoxMotDePasse.Text.Equals(motDePasse))
            {
                PronoteProfesseur pronoteProfesseur = new PronoteProfesseur();
                pronoteProfesseur.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Le nom d'utilisateur ou le mot de passe est incorrect.");
            }
        }
    }
}
