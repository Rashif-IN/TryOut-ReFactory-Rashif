using System;
using System.Linq;

namespace TryOut_Rashif_IN
{
    class Program
    {
        static void Main(string[] args)
        {

            //NumberOne.MyName(); 
            //NumberTwo.MyBirthday();
            //NumberThree.StringLength();
            NumberFour.Cencorship();
            //NumberFive.DetectNumber();
            //NumberSix.Grading();
            //NumberSeven.Temperature();
            //NumberEight.Kabisat();
            //NumberNine.GMTdifference();
            //NumberTen.KaBaTaKu();
            //NumberEleven.tambah(); //not yet
            //NumberTwelve.CAPSLOCK();
            //NumberThirteen.WordCount();
            //NumberFourteen.palindrome();
            //NumberFifteen.mirrorString();
            //NumberSixteen.Finder();
            //NumberSeventeen.thousandloop();
            //NumberEightteen.MinMaxAvg();
            //NumberNineteen.sorting();
            //NumberTwenty.barang();
        }
    }

    class NumberOne
    {
        public static void MyName()
        {
            Console.WriteLine("What's your name?");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello my name is {Name}.");
        }
    }
    class NumberTwo
    {
        public static void MyBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1995, 12, 24);

            DateTime next = birthday.AddYears(today.Year - birthday.Year);

            if (next < today)
            {
                next = next.AddYears(1);
            }

            int numDays = (next - today).Days;
            Console.WriteLine(numDays);
        }
    }
    class NumberThree
    {
        public static void StringLength()
        {
            Console.WriteLine("Type something!");
            string sentece = Console.ReadLine();
            Console.WriteLine($"{sentece} has a {CountString(sentece)} characters.");
        }
        public static int CountString(string sen)
        {
            int num = sen.Length;
            return num;
        }
    }
    class NumberFour
    {
        public static void Cencorship()
        {
            string[] censoredWords = new string[] { "imperdiet", "dolor", "duo" };

            string paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";

            for(int i = 0; i<censoredWords.Length; i++)
            {
                string cen = "";
                for(int j =0; j<censoredWords[i].Length; j++)
                {
                    cen += "*";
                }
                paragraph = paragraph.Replace(censoredWords[i], cen);
            }
            Console.WriteLine(paragraph);
            //int i = 0;
            //string a = "";
            //string sensor;
            //string a = paragraph.Replace("imperdiet", "*********");
            //string b = a.Replace("dolor", "*****");
            //string c = b.Replace("duo", "***");
            //Console.WriteLine(c);
        }
    }
    class NumberFive
    {
        public static void DetectNumber()
        {
            Console.WriteLine("insert number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"is {num} Odd? {isOdd(num)}");
            Console.WriteLine($"is {num} Even? {isEven(num)}");

        }
        public static bool isOdd(double Num)
        {
            if (Num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isEven(double Num)
        {
            if (Num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class NumberSix
    {
        public static void Grading()
        {
            char Grade = ' ';
            Console.WriteLine("insert score");
            double score = Convert.ToDouble(Console.ReadLine());
            if (score >= 90)
            {
                Grade = 'A';
            }
            else if (score < 90 && score >= 80)
            {
                Grade = 'B';
            }
            else if (score < 80 && score >= 70)
            {
                Grade = 'C';
            }
            else if (score < 70 && score >= 60)
            {
                Grade = 'D';
            }
            else if (score < 60)
            {
                Grade = 'E';
            }
            Console.WriteLine(Grade);
        }
    }
    class NumberSeven
    {
        public static void Temperature()
        {
            Console.WriteLine("insert temperature");
            double temp = Convert.ToDouble(Console.ReadLine());
            double a = CelciusToFahrenheit(temp);
            double b = FahrenheitToCelcius(temp);
            double c = CelciusToKelvin(temp);
            double d = KelvinToCelcius(temp);
            double e = KelvinToFahrenheit(temp);
            double f = FahrenheitToKelvin(temp);
            Console.WriteLine($"{temp} degree Celcius is equals to {a} degree Fahrenheit or {c} Kelvin");
            Console.WriteLine($"{temp} degree Fahrenheit is equals to {b} degree Celcius or {f} Kelvin");
            Console.WriteLine($"{temp} degree Kelvin is equals to {e} degree Fahrenheit or {d} Celcius");


        }
        public static double CelciusToFahrenheit(double Temp)
        {
            double converted = Temp * (9 / 5) + 32;
            return converted;
        }
        public static double FahrenheitToCelcius(double Temp)
        {
            double converted = Temp * (5 / 9) - 32;
            return converted;
        }
        public static double CelciusToKelvin(double Temp)
        {
            double converted = Temp + 273.15;
            return converted;
        }
        public static double KelvinToCelcius(double Temp)
        {
            double converted = Temp - 273.15;
            return converted;
        }
        public static double KelvinToFahrenheit(double Temp)
        {
            double converted = (Temp - 273.15) * (9 / 5) + 32;
            return converted;
        }
        public static double FahrenheitToKelvin(double Temp)
        {
            double converted = (Temp - 32) * (5 / 9) + 273.15;
            return converted;
        }
    }
    class NumberEight
    {
        public static void Kabisat()
        {
            Console.WriteLine("insert year");
            double year = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(IsLeapYear(year));
        }
        public static bool IsLeapYear(Double tahun)
        {
            if (tahun % 4 == 0)
            {
                if (tahun % 100 == 0)
                {
                    if (tahun % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

    }
    class NumberNine
    {
        public static void GMTdifference()
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);
            TimezoneDiff(jakarta, london); // Output: Jakarta 7 hours ahead London
            TimezoneDiff(cairo, chicago); // Output: Cairo 7 hours ahead Chicago
            TimezoneDiff(cairo, bali); // Output: Cairo 6 hours behind Bali
            TimezoneDiff(denver, jakarta); //Output: Denver 13 hours behind Jakarta
        }

        private static void TimezoneDiff(Tuple<string, int> place1, Tuple<string, int> place2)
        {
            int hour1 = place1.Item2;
            int hour2 = place2.Item2;
            int hourDiff = Math.Abs(hour1 - hour2);
            if (hour1 > hour2)
            {
                Console.WriteLine($" {place1.Item1} is {hourDiff} hours ahead {place2.Item1}");
            }
            else if (hour1 < hour2)
            {
                Console.WriteLine($" {place1.Item1} is {hourDiff} hours behind {place2.Item1}");
            }
        }
    }
    class NumberTen
        {
            public static void KaBaTaKu()
            {
                Console.WriteLine("insert a number");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("insert anothe number");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Sum(num1, num2);
                Substract(num1, num2);
                Multiply(num1, num2);
                Divide(num1, num2);
            }
            public static void Sum(double Num1, double Num2)
            {
                double answer = Num1 + Num2;
                Console.WriteLine($"{Num1} plus {Num2} is equal to {answer}");
            }
            public static void Substract(double Num1, double Num2)
            {
                double answer = Num1 - Num2;
                Console.WriteLine($"{Num1} minus {Num2} is equal to {answer}");
            }
            public static void Multiply(double Num1, double Num2)
            {
                double answer = Num1 * Num2;
                Console.WriteLine($"{Num1} times by {Num2} is equal to {answer}");
            }
            public static void Divide(double Num1, double Num2)
            {
                double answer = Num1 / Num2;
                Console.WriteLine($"{Num1} divided by {Num2} is equal to {answer}");
            }
        }
    class NumberEleven
        {
            public static void tambah()
            {

                string val = Console.ReadLine();
                int tot = 0;
                for (int i = 0; i < val.Length; i++)
                {
                    tot = tot + Convert.ToInt32(val[i]);
                }
                Console.WriteLine(tot);
            }
        }
    class NumberTwelve
        {
            public static void CAPSLOCK()
            {
                Console.WriteLine("type something!");
                string sentence = Console.ReadLine();
                uppercase(sentence);
            }
            public static void uppercase(string sen)
            {
                Console.WriteLine(sen.ToUpper());

            }

        }
    class NumberThirteen
        {
            public static void WordCount()
            {
                Console.WriteLine("type something!");
                string sentence = Console.ReadLine();
                int cou = CountWords(sentence);
                Console.WriteLine($"that sentece has {cou} words");
            }
            public static int CountWords(string sen)
            {
                int count = 0;
                bool inWord = false;

                foreach (char t in sen)
                {
                    if (char.IsWhiteSpace(t))
                    {
                        inWord = false;
                    }
                    else
                    {
                        if (!inWord) count++;
                        inWord = true;
                    }
                }
                return count;
            }
        }
    class NumberFourteen
        {
            public static void palindrome()
            {
                Console.WriteLine("type something!");
                string sentence = Console.ReadLine();
                Console.WriteLine(IsPalindrome(sentence));
            }
            public static bool IsPalindrome(string sen)
            {
                char[] ch = sen.ToCharArray();
                string rev;
                Array.Reverse(ch);
                rev = new string(ch);
                bool b = sen.Equals(rev, StringComparison.OrdinalIgnoreCase);
                return b;

            }
        }
    class NumberFifteen
        {
            public static void mirrorString()
            {
                Console.WriteLine("type something!");
                string sentence = Console.ReadLine();
                string mirrored = Mirror(sentence);
                Console.WriteLine(mirrored);
            }
            public static string Mirror(string sen)
            {
                string reverse = "";
                string forward = sen;
                int Length = sen.Length - 1;
                while (Length >= 0)
                {
                    reverse = reverse + sen[Length];
                    Length--;
                }
                string Mirrored = forward + reverse;
                return Mirrored;
            }
        }
    class NumberSixteen
        {
            public static void Finder()
            {
                string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };
                IndexFinder(fruits, "Jeruk"); // Output: 0
                IndexFinder(fruits, "Pepaya"); // Output: 3
                IndexFinder(fruits, "Markisa"); // Output: 6
            }
            public static void IndexFinder(string[] Fruits, string fruit)
            {
                int Count = 0;
                for (int i = 0; i < Fruits.Length; i++)
                {
                    if (Fruits[i] == fruit)
                    {
                        Count = i;
                        break;
                    }
                    else
                    {
                        Count++;
                    }
                }
                Console.WriteLine(Count);
            }



        }
    class NumberSeventeen
        {
            public static void thousandloop()
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (i % 5 == 0)
                    {
                        if (i % 20 == 0)
                        {
                            if (i % 100 == 0)
                            {
                                Console.WriteLine($"{i}.Baz");
                            }
                            else
                            {
                                Console.WriteLine($"{i}.Bar");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{i}.Foo");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{i}.");
                    }
                }
            }
        }
    class NumberEightteen
        {
            public static void MinMaxAvg()
            {
                int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
                FindMax(numbers);
                FindMin(numbers);
                FindAverage(numbers);
            }
            public static void FindMax(int[] Numbers)
            {
                int ans = Numbers.Max();
                Console.WriteLine(ans);

            }
            public static void FindMin(int[] Numbers)
            {
                int ans = Numbers.Min();
                Console.WriteLine(ans);

            }
            public static void FindAverage(int[] Numbers)
            {
                double length = Numbers.Length;
                double ans = Numbers.Sum() / length;
                Console.WriteLine(ans);

            }
        }
    class NumberNineteen
        {
            public static void sorting()
            {
                int[] points = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45 };
                Array.Sort(points);
                foreach (int value in points)
                {
                    Console.Write(value + " ");
                }
            }
        }
    class NumberTwenty
        {
            public static void barang()
            {
                Item item = new Item();
                item.name = "Indomie Goreng";
                item.price = 3500;
                item.onSale = true; // If true the price will drop 20%
                item.print(); // Output: "Indomie Goreng (Rp2800)"
            }
        }
    class Item
        {
            public string name { get; set; }
            public double price { get; set; }
            public bool onSale { get; set; }
            public void print()
            {
                if (onSale == true)
                {
                    price = price * 0.8;
                }
                Console.WriteLine($"{name} harganya Rp{price}");

            }
        }
 }

