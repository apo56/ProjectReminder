using ProjectReminder;
using System;
using System.Collections.Generic;


namespace DAL
{
    public interface IDal : IDisposable

    {
        //Projets
        List<Projet> ListProjets();
        void CreerProjet(int id, string nom, TypeProjet type, string description, List<Note> notes, Utilisateur utilisateur, int cout);

        void ModifierProjet(int id, string nom, TypeProjet type, string description, List<Note> notes, Utilisateur utilisateur, int cout);

        bool ProjetExiste(int id);

        void DeleteProjet(int id);


        //Notes
        List<Note> ListNotes();

         void CreerNote(int id, int Idprojet, string description);

        void ModifierNote(int id, int Idprojet, string description);

        bool NoteExiste(int id);

        void DeleteNote(int id);


        //Utilisateur
        Utilisateur Authentifier(string nom, string motDePasse);

        Utilisateur ObtenirUtilisateur(int id);

        Utilisateur ObtenirUtilisateur(string idStr);

        int AjouterUtilisateur(string nom, string prenom, string mail, string password);




    }
}
