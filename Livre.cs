namespace ilyas_dahbi_controle2
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; } 
        public string Editeur { get; set; }
        public string Isbn { get; set; }
        public string Categorie { get; set; }
        public bool Disponibilite { get; set; }

        public Livre(int id, string titre, string auteur, int anneePublication, string editeur, string isbn, string categorie, bool disponibilite)
        {
            Id = id;
            Titre = titre;
            Auteur = auteur;
            AnneePublication = anneePublication;
            Editeur = editeur;
            Isbn = isbn;
            Categorie = categorie;
            Disponibilite = disponibilite;
        }
    }
}