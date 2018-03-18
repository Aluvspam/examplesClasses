namespace DingleMouse
{
    public class DinglemouseByOana
    {

        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {

            int catYears = 0;
            int dogYears = 0;

            if (humanYears == 1)
            {
                catYears += 15;
                dogYears += 15;
            }
            else if (humanYears == 2)
            {
                catYears += 24;
                dogYears += 24;
            }
            else if (humanYears >= 3)
            {
                catYears = 24 + (humanYears - 2) * 4;
                dogYears = 24 + (humanYears - 2) * 5;
            }

            return new int[] { humanYears, catYears, dogYears };
        }
    }

    public class DinglemouseRecursive
    {
        public int humanYears;

        public static int CatYears(int humanYears)
        {
            if (humanYears == 1)
            {
                return 15;
            }
            else if (humanYears == 2)
            {
                return 9 + CatYears(humanYears - 1);
            }
            else
            {
                return 4 + CatYears(humanYears - 1);
            }
        }

        public static int DogYears(int humanYears)
        {
            if (humanYears == 1)
            {
                return 15;
            }
            else if (humanYears == 2)
            {
                return 9 + DogYears(humanYears - 1);
            }
            else
            {
                return 5 + DogYears(humanYears - 1);
            }
        }

        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            return new int[] { humanYears, CatYears(humanYears), DogYears(humanYears) };
        }
    }
}

