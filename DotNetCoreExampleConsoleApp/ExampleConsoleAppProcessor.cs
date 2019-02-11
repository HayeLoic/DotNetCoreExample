using System;
using System.Globalization;
using DotNetCoreExampleLibrary;

namespace DotNetCoreExampleConsoleApp
{
    class ExampleConsoleAppProcessor
    {
        private readonly AgeCalculator AgeCalculator;
        private static string valueEnteredByTheUser;
        private static DateTime? birthDate;
        private const string datetimeFormat = "dd/MM/yyyy";

        public ExampleConsoleAppProcessor(AgeCalculator ageCalculator)
        {
            this.AgeCalculator = ageCalculator;
        }

        public void AskDateAndCalculateAge()
        {
            while (birthDate == null)
            {
                Console.WriteLine($"Entrez une date de naissance au format {datetimeFormat}");
                valueEnteredByTheUser = Console.ReadLine();
                if (DateTime.TryParseExact(valueEnteredByTheUser, datetimeFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime convertedDateFromUserInput))
                {
                    birthDate = convertedDateFromUserInput;
                    this.CalculateAndShowAge();
                    this.WriteExitSentenceAndWaitUserInput();
                }
            }
        }

        private void CalculateAndShowAge()
        {
            Console.WriteLine($"L'âge correspondant est : {this.AgeCalculator.CalculateAge(birthDate.Value, DateTime.Now)} ans");
        }

        private void WriteExitSentenceAndWaitUserInput()
        {
            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadKey();
        }
    }
}
