using System;
using System.Collections.Generic;

namespace ams_heranca_treeclass_pessoa
{
    class Program
    {
        static List<Persons> personsList = new List<Persons>();

        static void Main(string[] args)
        {
            Juri juiz = new Juri("333.222.111.00", "Juiz");
            Fisica andante = new Fisica("000.111.222-33", "Pessoa comum");

            AddPerson(juiz);
            AddPerson(andante);

            foreach (Persons person in personsList)
            {
                if (person is Juri)
                {
                    Juri juriPerson = (Juri)person;
                    juriPerson.Juridico();
                }
                else if (person is Fisica)
                {
                    Fisica fisicaPerson = (Fisica)person;
                    fisicaPerson.Tiozinho();
                }

                Console.WriteLine("----------------------------------");
            }
        }

        static void AddPerson(Persons person)
        {
            personsList.Add(person);
        }
    }
}