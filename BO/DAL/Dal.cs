using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BO.DAL
{

    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public List<Projet> ListProjets()
        {
            return bdd.projets.ToList();
        }

        public List<Note> ListNotes()
        {
            return bdd.notes.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
        //Projet
        public void CreerProjet(int id, string nom, TypeProjet type, string description, List<Note> notes, Utilisateur utilisateur, int cout)
        {
            bdd.projets.Add(new Projet(id, nom, type, description, notes, utilisateur, cout));
            bdd.SaveChanges();
        }

        public void ModifierProjet(int id, string nom, TypeProjet type, string description, List<Note> notes, Utilisateur utilisateur, int cout)

        {

            Projet TrouveProjet = bdd.projets.FirstOrDefault(projets => projets.Id == id);

            if (TrouveProjet != null)
            {
                TrouveProjet.Nom = nom;
                TrouveProjet.Cout = cout;
                TrouveProjet.Cout = cout;
                TrouveProjet.Description = description;

                bdd.SaveChanges();

            }
        }

        public bool ProjetExiste(int id)
        {

            Projet TrouveProjet = bdd.projets.FirstOrDefault(projets => projets.Id == id);
            if (TrouveProjet == null)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        public void DeleteProjet(int id)
        {
            Projet TrouveProjet = bdd.projets.FirstOrDefault(projets => projets.Id == id);
            bdd.projets.Remove(TrouveProjet);
            bdd.SaveChanges();

        }


        //Utilisateur
        public int AjouterUtilisateur(string nom, string prenom,string mail ,string password)
        {
            Utilisateur utilisateur = new Utilisateur { Nom = nom, Prenom= prenom, Mail=mail, Password=password};

            bdd.Utilisateurs.Add(utilisateur);

            bdd.SaveChanges();

            return utilisateur.Id;
        }


        public Utilisateur Authentifier(string nom, string password)

        {

            string motDePasseEncode = EncodeMD5(password);

            return bdd.Utilisateurs.FirstOrDefault(u => u.Prenom == nom && u.Password == motDePasseEncode);

        }

        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "projet" + motDePasse  ;

            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));

        }
        public Utilisateur ObtenirUtilisateur(int id)

        {

            return bdd.Utilisateurs.FirstOrDefault(u => u.Id == id);

        }


        public Utilisateur ObtenirUtilisateur(string idStr)

        {

            int id;

            if (int.TryParse(idStr, out id))

                return ObtenirUtilisateur(id);

            return null;

        }
        //Note
        public void CreerNote(int id, int Idprojet, string description)
        {
            bdd.notes.Add(new Note {Id=id, Description=  description, IdProjet=Idprojet});
            bdd.SaveChanges();
        }

        public void ModifierNote(int id, int Idprojet, string description)

        {

            Note TrouveNote = bdd.notes.FirstOrDefault(notes => notes.Id == id);

            if (TrouveNote != null)
            {
                TrouveNote.Description = description;

                bdd.SaveChanges();

            }
        }

        public bool NoteExiste(int id)
        {

            Note TrouveNote = bdd.notes.FirstOrDefault(notes => notes.Id == id);
            if (TrouveNote == null)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        public void DeleteNote(int id)
        {
            Note TrouveNote = bdd.notes.FirstOrDefault(notes => notes.Id == id);
            bdd.notes.Remove(TrouveNote);
            bdd.SaveChanges();

        }
        

    }
}
