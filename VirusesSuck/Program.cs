using System;
using System.Collections.Generic;

namespace VirusesSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------
            // Lists
            //-----------------------------------------------------------------

            var names = new List<string>();

            //add items to the list 1 at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");
            names.Insert(0, "Shebola");

            //remove items from list
            names.Remove("Stupidity");
            names.RemoveAt(3);

            //add multiple items
            var people = new List<string> { "Nathan", "Martin", "Ray", "Randy's Kid" };
            names.AddRange(people);

            //remove multiple items
            names.RemoveRange(names.Count - 3, 3);

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //-----------------------------------------------------------------
            // Dictionaries
            //-----------------------------------------------------------------

            var symptoms = new Dictionary<string, string>();

            //add single items
            symptoms.Add("COVID-19", "Dry cough, fever, respiratory problems");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            //get single thing
            var covidSymptoms = symptoms["COVID-19"];

            //remove single item
            symptoms.Remove("Ebola");

            //collection initializer
            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"the {virus} virus has the following symptoms: {symptom}");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is unknown...");
                }
            }

            //-----------------------------------------------------------------
            // Queues/Stacks
            //-----------------------------------------------------------------

            var diseasesToCure = new Queue<string>();

            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");

            var thingToCure = diseasesToCure.Dequeue();
            var nextThingToCure = diseasesToCure.Dequeue();

            //Queues are First In First Out FIFO
            //Stacks are Last In Last Out or LILO

            //-----------------------------------------------------------------
            // Hashset
            //-----------------------------------------------------------------

            var vectors = new HashSet<string>();

            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");

            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry Cough");
            covid19.Symptoms.Add("Cancels everything except work");
            covid19.NumberOfDeathsWorldWide = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry Cough");
            spanishFlu.NumberOfDeathsWorldWide = 50000000;

            var rabies = new Virus("Rabies", 1);
            rabies.Symptoms.Add("Frothy mouth");
            rabies.Symptoms.Add("Fever");
            rabies.NumberOfDeathsWorldWide = 20000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies };

            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} and has killed {virus.NumberOfDeathsWorldWide}");
                Console.WriteLine($"It has the following symptoms: {string.Join(", ", virus.Symptoms)}");
            }
        }
    }
}
