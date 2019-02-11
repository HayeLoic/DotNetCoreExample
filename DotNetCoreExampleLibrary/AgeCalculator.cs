using System;

namespace DotNetCoreExampleLibrary
{
    class AgeCalculator
    {
        int CalculateAge(DateTime birthDate, DateTime dateForAgeCalculation)
        {
            int age = dateForAgeCalculation.Year - birthDate.Year;
            if (birthDate > dateForAgeCalculation.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}