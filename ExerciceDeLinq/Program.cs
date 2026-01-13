using LINQDataContext;

namespace ExerciceDeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext();

            #region Faites vos exos ici

            #region Exercice 2.1
            /*Ecrire une requête pour présenter, pour chaque étudiant,  le nom de l’étudiant, la date de naissance, le login et le résultat pour l’année de l’ensemble des étudiants.

            var result = dc.Students.Select(s => new
            {
                Nom = s.Last_Name,
                DateDeNaissance = s.BirthDate,
                s.Login,
                ResultatAnnuel = s.Year_Result
            });

            //Expression de requête
            //var result = from s in dc.Students
            //             select new
            //             {
            //                 Nom = s.Last_Name,
            //                 DateDeNaissance = s.BirthDate,
            //                 s.Login,
            //                 ResultatAnnuel = s.Year_Result
            //             };

            foreach (var item in result)
            {
                //Console.WriteLine($"{item.Nom} {item.DateDeNaissance} {item.Login} {item.ResultatAnnuel}");
                Console.WriteLine(item);
            }*/
            #endregion

            #region Exercice 2.2
            /*Ecrire une requête pour présenter, pour chaque étudiant, son nom complet (nom 
et prénom séparés par un espace), son id et sa date de naissance.

            var result = dc.Students.Select(s => new
            {
                NomComplet = s.First_Name + " " + s.Last_Name,
                Id = s.Student_ID,
                DateDeNaissance = s.BirthDate
            });

            //Expression de requête
            //var result = from s in dc.Students 
            //             select new {
            //                            NomComplet = s.First_Name + " " + s.Last_Name,
            //                            Id = s.Student_ID,
            //                            DateDeNaissance = s.BirthDate
            //                        };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/
            #endregion

            #region Exercice 2.3
            /*Ecrire une requête pour présenter, pour chaque étudiant, dans une seule chaine de caractère l’ensemble des données relatives à un étudiant séparées par le symbole |. 

            IEnumerable<string> result = dc.Students.Select(s => $"{s.Student_ID} | {s.First_Name} | {s.Last_Name} | {s.BirthDate} | {s.Login} | {s.Section_ID} | {s.Year_Result} | {s.Course_ID}");

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }*/
            #endregion

            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}