namespace ExercisesCsharp
{
    public class Dinglemouse
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears) //humanYears >= 1
        {
            // Your code here!
            var catYears = 0;
            var dogYears = 0;
            for (int i = 1; i <= humanYears; i++)
            {
                if (i == 1)
                {
                    catYears += 15;
                    dogYears += 15;
                }
                else if (i == 2)
                {
                    catYears += 9;
                    dogYears += 9;
                }
                else if (i > 2)
                {
                    catYears += 4;
                    dogYears += 5;
                }
            }
            return new int[] { humanYears, catYears, dogYears };
        }
        public static int[] humanYearsCatYearsDogMonths(int humanMonths)
        {
            var catMonths = 0;
            var dogMonths = 0;
            var catMonthsFirstYear = 0;
            var dogMonthsFirstYear = 0;
            var catMonthsSecondYear = 0;
            var dogMonthsSecondYear = 0;
            var catMonthsThirdYear = 0;
            var dogMonthsThirdYear = 0;

            for (int i = 1; i <= humanMonths; i++)
            {
                if (i <= 23)// inseamna 1 an si 11 luni
                {
                    catMonthsFirstYear += 15;

                    dogMonthsFirstYear += 15;
                }
                if (i < 35 && i > 23)// inseamna anul 2 si 11 luni
                {
                    catMonthsSecondYear += 9;
                    dogMonthsSecondYear += 9;
                }
                if (i >= 36) // peste sau egal cu 3 ani
                {
                    catMonthsThirdYear += 4;
                    dogMonthsThirdYear += 5;
                }
            }
            catMonths = catMonthsFirstYear + catMonthsSecondYear + catMonthsThirdYear; //toate luniile pisicesti 
            dogMonths = dogMonthsFirstYear + dogMonthsSecondYear + dogMonthsThirdYear; //toate luniile cainesti

            return new int[] { humanMonths, catMonths, dogMonths };
        }
    }
}
/*
Cat Years
15 cat years for first year
+9 cat years for second year
+4 cat years for each year after that
Dog Years
15 dog years for first year
+9 dog years for second year
+5 dog years for each year after that*/
