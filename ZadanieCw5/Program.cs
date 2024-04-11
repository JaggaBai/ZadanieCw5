using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieCw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gr parzysta:
            //Zaimplementuj klasę Film z właściwościami takimi jak: Tytuł, RokWydania, Gatunek, Ocena.

            //Stwórz zapytania LINQ, które wykonują następujące zadania:
            //Znajdź wszystkie filmy wydane po roku 1900.
            //Znajdź wszystkie filmy z gatunku "Dramat".
            //Znajdź średnią ocenę wszystkich filmów.
            //Znajdź 5 najlepiej ocenione filmy.
            //Posortuj filmy według roku wydania.
            //Znajdź najstarszy i najnowszy film w bazie.
            //Znajdź wszystkie unikalne gatunki filmowe obecne w bazie.
            //Wyświetl wyniki zapytań LINQ w czytelny sposób.

            void print(filmy)
            {



                foreach (var film in filmy)
                {
                    Console.WriteLine($"Tytuł: {film.Tytuł}, Rok wydania: {film.RokWydania}, Gatunek: {film.Gatunek}, Ocena: {film.Ocena}");
                }


            } 


        public class Film
        {
            public string Tytuł { get; set; }
            public int RokWydania { get; set; }
            public string Gatunek { get; set; }
            public double Ocena { get; set; }







            public Film(string tytuł, int rokWydania, string gatunek, double ocena)
            {
                Tytuł = tytuł;
                RokWydania = rokWydania;
                Gatunek = gatunek;
                Ocena = ocena;
            }


            public static List<Film> GenerujFilmy()
            {
                List<Film> filmy = new List<Film>();



                filmy.Add(new Film("The Shawshank Redemption", 1994, "Dramat", 9.3));
                filmy.Add(new Film("The Godfather", 1972, "Dramat", 9.2));
                filmy.Add(new Film("The Dark Knight", 2008, "Akcja", 9.0));
                filmy.Add(new Film("Schindler's List", 1993, "Biograficzny", 8.9));
                filmy.Add(new Film("The Lord of the Rings: The Return of the King", 2003, "Fantasy", 8.9));
                filmy.Add(new Film("Pulp Fiction", 1994, "Kryminał", 8.9));
                filmy.Add(new Film("The Lord of the Rings: The Fellowship of the Ring", 2001, "Fantasy", 8.8));
                filmy.Add(new Film("Forrest Gump", 1994, "Dramat", 8.8));
                filmy.Add(new Film("Fight Club", 1999, "Dramat", 8.8));
                filmy.Add(new Film("Inception", 2010, "Sci-Fi", 8.7));
                filmy.Add(new Film("The Lord of the Rings: The Two Towers", 2002, "Fantasy", 8.7));
                filmy.Add(new Film("Star Wars: Episode V - The Empire Strikes Back", 1980, "Sci-Fi", 8.7));
                filmy.Add(new Film("The Matrix", 1999, "Sci-Fi", 8.7));
                filmy.Add(new Film("Goodfellas", 1990, "Biograficzny", 8.7));
                filmy.Add(new Film("One Flew Over the Cuckoo's Nest", 1975, "Dramat", 8.7));
                filmy.Add(new Film("Se7en", 1995, "Kryminał", 8.6));
                filmy.Add(new Film("The Silence of the Lambs", 1991, "Kryminał", 8.6));
                filmy.Add(new Film("City of God", 2002, "Dramat", 8.6));
                filmy.Add(new Film("The Green Mile", 1999, "Dramat", 8.6));
                filmy.Add(new Film("The Usual Suspects", 1995, "Kryminał", 8.5));
                filmy.Add(new Film("Léon: The Professional", 1994, "Akcja", 8.5));
                filmy.Add(new Film("Saving Private Ryan", 1998, "Wojenny", 8.5));
                filmy.Add(new Film("Interstellar", 2014, "Sci-Fi", 8.5));
                filmy.Add(new Film("The Pianist", 2002, "Biograficzny", 8.5));
                filmy.Add(new Film("Gladiator", 2000, "Akcja", 8.5));
                filmy.Add(new Film("American History X", 1998, "Dramat", 8.5));
                filmy.Add(new Film("The Departed", 2006, "Kryminał", 8.5));
                filmy.Add(new Film("Whiplash", 2014, "Dramat", 8.5));
                filmy.Add(new Film("The Lion King", 1994, "Animacja", 8.5));
                filmy.Add(new Film("The Prestige", 2006, "Mystery", 8.5));
                filmy.Add(new Film("The Intouchables", 2011, "Biograficzny", 8.5));
                filmy.Add(new Film("The Godfather: Part II", 1974, "Dramat", 8.5));
                filmy.Add(new Film("The Sixth Sense", 1999, "Thriller", 8.5));
                filmy.Add(new Film("The Departed", 2006, "Kryminał", 8.5));
                filmy.Add(new Film("The Shining", 1980, "Horror", 8.4));
                filmy.Add(new Film("The Truman Show", 1998, "Dramat", 8.4));
                filmy.Add(new Film("The Dark Knight Rises", 2012, "Akcja", 8.4));
                filmy.Add(new Film("The Lives of Others", 2006, "Dramat", 8.4));
                filmy.Add(new Film("The Help", 2011, "Dramat", 8.4));
                filmy.Add(new Film("The Terminator", 1984, "Sci-Fi", 8.4));
                filmy.Add(new Film("The Matrix", 1999, "Sci-Fi", 8.4));
                filmy.Add(new Film("The Silence of the Lambs", 1991, "Kryminał", 8.4));




                return filmy;
            }
        }




      

        }

    }

