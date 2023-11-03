namespace Lib_4
{
    public class Fraction : Pair
    {
        int f1, f2;

        public int F1 // Дробная часть первого числа пары
        {
            get { return f1; }
            set { f1 = value; }
        }

        public int F2 // Дробная часть второго числа пары
        {
            get { return f2; }
            set { f2 = value; }
        }

        /// <summary>
        /// Параметризированный конструктор для класса Fraction
        /// </summary>
        /// <param name="p1">Целая часть первого числа пары</param>
        /// <param name="f1">Дробная часть первого числа пары</param>
        /// <param name="p2">Целая часть второго числа пары</param>
        /// <param name="f2">Дробная часть второго числа пары</param>
        public Fraction(int p1, int f1, int p2, int f2) : base(p1, p2)
        {
            F1 = f1;
            F2 = f2;
        }

        /// <summary>
        /// Сложение двух пар чисел с их дробными частями
        /// </summary>
        /// <param name="frac1">Пара 1</param>
        /// <param name="frac2">Пара 2</param>
        /// <returns>Сумма пар чисел</returns>
        public static Fraction Sum(Fraction frac1, Fraction frac2)
        {
            Fraction result = new Fraction(
                frac1.P1 + frac2.P1, frac1.F1 + frac2.F1,
                frac1.P2 + frac2.P2, frac1.F2 + frac2.F2);

            if (result.F1 > 9)
            {
                result.F1 %= 10;
                result.P1++;
            }
            if (result.F2 > 9)
            {
                result.F2 %= 10;
                result.P2++;
            }

            return result;
        }
    }
}
