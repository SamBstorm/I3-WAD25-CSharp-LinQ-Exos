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

            #region Exercice 3.1
            /*Pour chaque étudiant né avant 1955, donner  le nom, le résultat annuel et le statut. Le statut prend la valeur « OK » si l’étudiant à obtenu au moins 12 comme résultat annuel et « KO » dans le cas contraire. 

            var result = dc.Students
                .Where(s => s.BirthDate.Year < 1955)
                .Select(s => new { 
                    Nom = s.Last_Name,
                    ResultatAnnuel = s.Year_Result,
                    Status = (s.Year_Result >= 12)? "Ok" : "KO"
                });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            #endregion

            #region Exercice 3.3
            /*Ecrire une requête pour présenter le nom, l’id de section et de tous les étudiants             qui ont un nom de famille qui termine par r.

            var result = dc.Students
                .Where(s => s.Last_Name.EndsWith('r'))
                .Select(s => new { 
                    Nom = s.Last_Name,
                    s.Section_ID
                });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            #endregion

            #region Exercice 3.5
            /*Ecrire une requête pour présenter le nom complet (nom et prénom séparés par un espace) et le résultat annuel classé par nom croissant sur le nom de tous les étudiants appartenant à la section 1110. 

            var result = dc.Students
                .Where(s => s.Section_ID == 1110)
                .OrderBy(s => s.Last_Name)
                .Select(s => new { 
                    NomComplet = $"{s.Last_Name} {s.First_Name}",
                    ResultatAnnuel = s.Year_Result
                });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            #endregion

            #region Exercice 3.6
            /*Ecrire une requête pour présenter le nom, l’id de section et le résultat annuel classé par ordre croissant sur la section de tous les étudiants appartenant aux sections 1010 et 1020 ayant un résultat annuel qui n’est pas compris entre 12 et 18. */

            var result = dc.Students
                .Where(s => s.Section_ID == 1010 || s.Section_ID == 1020)
                .Where(s => s.Year_Result < 12 || s.Year_Result > 18)
                .OrderBy(s => s.Section_ID)
                .Select(s => new { 
                    Nom = s.Last_Name,
                    s.Section_ID,
                    ResultatAnnuel = s.Year_Result
                });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //.Where( s =>
            //  (s.Section_ID == 1010 || s.Section_ID == 1020) &&
            //  (s.Year_Result < 12 || s.Year_Result > 18)
            //)


            #endregion

            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}