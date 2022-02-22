using System;
using Mathos.Parser;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace Groophy.Math
{
    public class Math
    {
        public static double Euler = 2.71828182845904523536028747135266249775724709369995;
        public static double Euler_Mascheroni = 0.57721566490153286060651209008240243104215933593992;
        public static double Pi = 3.14159265358979323846264338327950288419716939937510;

        /// <summary>
        /// https://groophy-inc.github.io/addaddition
        /// </summary>
        /// <param name="main"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public static GValue Addaddition(GValue main, GValue add)
        {
            return new GValue((main.get_Decimal + add.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/addaddition
        /// </summary>
        /// <param name="main"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public static GValue Addaddition(string main_, string add_)
        {
            GValue main = new GValue(main_);
            GValue add = new GValue(add_);
            return new GValue((main.get_Decimal + add.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/addaddition
        /// </summary>
        /// <param name="main"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public static GValue Addaddition(GValue main, string add_)
        {
            GValue add = new GValue(add_);
            return new GValue((main.get_Decimal + add.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/addaddition
        /// </summary>
        /// <param name="main"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public static GValue Addaddition(string main_, GValue add)
        {
            GValue main = new GValue(main_);
            return new GValue((main.get_Decimal + add.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/subtraction
        /// </summary>
        /// <param name="main"></param>
        /// <param name="track"></param>
        /// <returns></returns>
        public static GValue Subtraction(GValue main, GValue track)
        {
            return new GValue((main.get_Decimal - track.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/subtraction
        /// </summary>
        /// <param name="main"></param>
        /// <param name="track"></param>
        /// <returns></returns>
        public static GValue Subtraction(string main_, string track_)
        {
            GValue main = new GValue(main_);
            GValue track = new GValue(track_);
            return new GValue((main.get_Decimal - track.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/subtraction
        /// </summary>
        /// <param name="main"></param>
        /// <param name="track"></param>
        /// <returns></returns>
        public static GValue Subtraction(GValue main, string track_)
        {
            GValue track = new GValue(track_);
            return new GValue((main.get_Decimal - track.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/subtraction
        /// </summary>
        /// <param name="main"></param>
        /// <param name="track"></param>
        /// <returns></returns>
        public static GValue Subtraction(string main_, GValue track)
        {
            GValue main = new GValue(main_);
            return new GValue((main.get_Decimal - track.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/multiplication
        /// </summary>
        /// <param name="main"></param>
        /// <param name="multi"></param>
        /// <returns></returns>
        public static GValue Multiplication(GValue main, GValue multi)
        {
            return new GValue((main.get_Decimal * multi.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/multiplication
        /// </summary>
        /// <param name="main"></param>
        /// <param name="multi"></param>
        /// <returns></returns>
        public static GValue Multiplication(string main_, string multi_)
        {
            GValue main = new GValue(main_);
            GValue multi = new GValue(multi_);
            return new GValue((main.get_Decimal * multi.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/multiplication
        /// </summary>
        /// <param name="main"></param>
        /// <param name="multi"></param>
        /// <returns></returns>
        public static GValue Multiplication(GValue main, string multi_)
        {
            GValue multi = new GValue(multi_);
            return new GValue((main.get_Decimal * multi.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/multiplication
        /// </summary>
        /// <param name="main"></param>
        /// <param name="multi"></param>
        /// <returns></returns>
        public static GValue Multiplication(string main_, GValue multi)
        {
            GValue main = new GValue(main_);
            return new GValue((main.get_Decimal * multi.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/division
        /// </summary>
        /// <param name="main"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static GValue Division(GValue main, GValue div)
        {
            return new GValue((main.get_Decimal / div.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/division
        /// </summary>
        /// <param name="main"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static GValue Division(string main_, string div_)
        {
            GValue main = new GValue(main_);
            GValue div = new GValue(div_);
            return new GValue((main.get_Decimal / div.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/division
        /// </summary>
        /// <param name="main"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static GValue Division(GValue main, string div_)
        {
            GValue div = new GValue(div_);
            return new GValue((main.get_Decimal / div.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/division
        /// </summary>
        /// <param name="main"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static GValue Division(string main_, GValue div)
        {
            GValue main = new GValue(main_);
            return new GValue((main.get_Decimal / div.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/modulo
        /// </summary>
        /// <param name="divfrom"></param>
        /// <param name="divto"></param>
        /// <returns></returns>
        public static GValue Modulo(GValue divfrom, GValue divto)
        {
            return new GValue((divfrom.get_Decimal % divto.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/modulo
        /// </summary>
        /// <param name="divfrom"></param>
        /// <param name="divto"></param>
        /// <returns></returns>
        public static GValue Modulo(string divfrom_, string divto_)
        {
            GValue divfrom = new GValue(divfrom_);
            GValue divto = new GValue(divto_);
            return new GValue((divfrom.get_Decimal % divto.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/modulo
        /// </summary>
        /// <param name="divfrom"></param>
        /// <param name="divto"></param>
        /// <returns></returns>
        public static GValue Modulo(GValue divfrom, string divto_)
        {
            GValue divto = new GValue(divto_);
            return new GValue((divfrom.get_Decimal % divto.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/modulo
        /// </summary>
        /// <param name="divfrom"></param>
        /// <param name="divto"></param>
        /// <returns></returns>
        public static GValue Modulo(string divfrom_, GValue divto)
        {
            GValue divfrom = new GValue(divfrom_);
            return new GValue((divfrom.get_Decimal % divto.get_Decimal).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Period(GValue from, GValue to)
        {
            return new GValue(((from.get_Decimal + to.get_Decimal) / 100).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Period(GValue from, string to_)
        {
            GValue to = new GValue(to_);
            return new GValue(((from.get_Decimal + to.get_Decimal) / 100).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Period(string from_, GValue to)
        {
            GValue from = new GValue(from_);
            return new GValue(((from.get_Decimal + to.get_Decimal) / 100).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/Exponent
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Exponent(GValue from, GValue to)
        {
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Exponent(string from_, string to_)
        {
            GValue from = new GValue(from_);
            GValue to = new GValue(to_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Exponent(GValue from, string to_)
        {
            GValue to = new GValue(to_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Exponent(string from_, GValue to)
        {
            GValue from = new GValue(from_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/Exponent
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Power(GValue from, GValue to)
        {
            return new GValue((System.Math.Pow(from.get_Int, to.get_Int)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Power(string from_, string to_)
        {
            GValue from = new GValue(from_);
            GValue to = new GValue(to_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Power(GValue from, string to_)
        {
            GValue to = new GValue(to_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Power(string from_, GValue to)
        {
            GValue from = new GValue(from_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/Exponent
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Caret(GValue from, GValue to)
        {
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/Exponent
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Caret(string from_, string to_)
        {
            GValue from = new GValue(from_);
            GValue to = new GValue(to_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Caret(GValue from, string to_)
        {
            GValue to = new GValue(to_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Caret(string from_, GValue to)
        {
            GValue from = new GValue(from_);
            return Math.Power(from, to);
        }

        /// <summary>
        /// https://groophy-inc.github.io/sigma
        /// </summary>
        /// <param name="n"></param>
        /// <param name="to"></param>
        /// <param name="formula"></param>
        /// <returns></returns>
        public static GValue Sigma(GValue n, GValue to, string formula)
        {
            double result = 0;
            MathParser parser = new MathParser();
            StringBuilder sb = new StringBuilder();
            parser.LocalVariables.Add("n", 0);
            for (int i = n.get_Int; i < to.get_Int;i++ )
            {
                parser.LocalVariables["n"] = i;
                double res = parser.Parse(formula);
                result += res;
                sb.Append(formula.Replace("n", i.ToString()) + " = " + res + Environment.NewLine);
            }
            sb.Append(formula.Replace("n", (to.get_Int+1).ToString()) + " = " + result.ToString() + Environment.NewLine);
            GValue re = new GValue(result.ToString());
            re.get_String = sb.ToString();
            return re;
        }

        /// <summary>
        /// https://groophy-inc.github.io/sigma
        /// </summary>
        /// <param name="n"></param>
        /// <param name="to"></param>
        /// <param name="formula"></param>
        /// <returns></returns>
        public static GValue Sigma(string n_, string to_, string formula)
        {
            GValue n = new GValue(n_);
            GValue to = new GValue(to_);
            double result = 0;
            MathParser parser = new MathParser();
            StringBuilder sb = new StringBuilder();
            parser.LocalVariables.Add("n", 0);
            for (int i = n.get_Int; i < to.get_Int; i++)
            {
                parser.LocalVariables["n"] = i;
                double res = parser.Parse(formula);
                result += res;
                sb.Append(formula.Replace("n", i.ToString()) + " = " + res + Environment.NewLine);
            }
            sb.Append(formula.Replace("n", (to.get_Int + 1).ToString()) + " = " + result.ToString() + Environment.NewLine);
            GValue re = new GValue(result.ToString());
            re.get_String = sb.ToString();
            return re;
        }

        /// <summary>
        /// https://groophy-inc.github.io/sigma
        /// </summary>
        /// <param name="n"></param>
        /// <param name="to"></param>
        /// <param name="formula"></param>
        /// <returns></returns>
        public static GValue Sigma(GValue n, string to_, string formula)
        {
            GValue to = new GValue(to_);
            double result = 0;
            MathParser parser = new MathParser();
            StringBuilder sb = new StringBuilder();
            parser.LocalVariables.Add("n", 0);
            for (int i = n.get_Int; i < to.get_Int; i++)
            {
                parser.LocalVariables["n"] = i;
                double res = parser.Parse(formula);
                result += res;
                sb.Append(formula.Replace("n", i.ToString()) + " = " + res + Environment.NewLine);
            }
            sb.Append(formula.Replace("n", (to.get_Int + 1).ToString()) + " = " + result.ToString() + Environment.NewLine);
            GValue re = new GValue(result.ToString());
            re.get_String = sb.ToString();
            return re;
        }

        /// <summary>
        /// https://groophy-inc.github.io/sigma
        /// </summary>
        /// <param name="n"></param>
        /// <param name="to"></param>
        /// <param name="formula"></param>
        /// <returns></returns>
        public static GValue Sigma(string n_, GValue to, string formula)
        {
            GValue n = new GValue(n_);
            double result = 0;
            MathParser parser = new MathParser();
            StringBuilder sb = new StringBuilder();
            parser.LocalVariables.Add("n", 0);
            for (int i = n.get_Int; i < to.get_Int; i++)
            {
                parser.LocalVariables["n"] = i;
                double res = parser.Parse(formula);
                result += res;
                sb.Append(formula.Replace("n", i.ToString()) + " = " + res + Environment.NewLine);
            }
            sb.Append(formula.Replace("n", (to.get_Int + 1).ToString()) + " = " + result.ToString() + Environment.NewLine);
            GValue re = new GValue(result.ToString());
            re.get_String = sb.ToString();
            return re;
        }

        /// <summary>
        /// https://groophy-inc.github.io/root
        /// </summary>
        /// <param name="n"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Root(GValue n, GValue val)
        {
            return new GValue((System.Math.Pow(val.get_Double,Math.Division(new GValue("1"), n).get_Double)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/root
        /// </summary>
        /// <param name="n"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Root(string n_, string val_)
        {
            GValue n = new GValue(n_);
            GValue val = new GValue(val_);
            return new GValue((System.Math.Pow(val.get_Double, Math.Division(new GValue("1"), n).get_Double)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/root
        /// </summary>
        /// <param name="n"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Root(GValue n, string val_)
        {
            GValue val = new GValue(val_);
            return new GValue((System.Math.Pow(val.get_Double, Math.Division(new GValue("1"), n).get_Double)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/root
        /// </summary>
        /// <param name="n"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Root(string n_, GValue val)
        {
            GValue n = new GValue(n_);
            return new GValue((System.Math.Pow(val.get_Double, Math.Division(new GValue("1"), n).get_Double)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/root
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Square_Root(GValue val)
        {
            return new GValue((System.Math.Pow(val.get_Double, Math.Division(new GValue("1"), new GValue("2")).get_Double)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/root
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Square_Root(string val_)
        {
            GValue val = new GValue(val_);
            return new GValue((System.Math.Pow(val.get_Double, Math.Division(new GValue("1"), new GValue("2")).get_Double)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/root
        /// percent      - 100
        /// per_mille    - 1000
        /// per_million  - 1000000
        /// per_billion  - 1000000000
        /// per_trillion - 1000000000000
        /// </summary>
        public enum pers
        {
            percent,
            per_mille,
            per_million,
            per_billion,
            per_trillion
        }

        /// <summary>
        /// https://groophy-inc.github.io/per
        /// </summary>
        /// <param name="value"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static GValue Per(GValue value, pers p)
        {
            switch (p)
            {
                case pers.percent:
                    return Math.Division(value, new GValue("1"));
                    break;
                case pers.per_mille:
                    return Math.Division(value, new GValue("10"));
                    break;
                case pers.per_million:
                    return Math.Division(value, new GValue("10000"));
                    break;
                case pers.per_billion:
                    return Math.Division(value, new GValue("10000000"));
                    break;
                case pers.per_trillion:
                    return Math.Division(value, new GValue("10000000000"));
                    break;
            }
            return new GValue("0");
        }

        /// <summary>
        /// https://groophy-inc.github.io/per
        /// </summary>
        /// <param name="value"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static GValue Per(string value_, pers p)
        {
            GValue value = new GValue(value_);
            switch (p)
            {
                case pers.percent:
                    return Math.Division(value, new GValue("1"));
                    break;
                case pers.per_mille:
                    return Math.Division(value, new GValue("10"));
                    break;
                case pers.per_million:
                    return Math.Division(value, new GValue("10000"));
                    break;
                case pers.per_billion:
                    return Math.Division(value, new GValue("10000000"));
                    break;
                case pers.per_trillion:
                    return Math.Division(value, new GValue("10000000000"));
                    break;
            }
            return new GValue("0");
        }

        /// <summary>
        /// https://groophy-inc.github.io/abs
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GValue Abs(GValue value)
        {
            if (value.get_Long < 0)
            {
                return Math.Multiplication(value, new GValue("-1"));
            }
            return value;
        }

        /// <summary>
        /// https://groophy-inc.github.io/abs
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GValue Abs(string value_)
        {
            GValue value = new GValue(value_);
            if (value.get_Long < 0)
            {
                return Math.Multiplication(value, new GValue("-1"));
            }
            return value;
        }

        /// <summary>
        /// https://groophy-inc.github.io/abs
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GValue Absolute(GValue value)
        {
            if (value.get_Long < 0)
            {
                return Math.Multiplication(value, new GValue("-1"));
            }
            return value;
        }

        /// <summary>
        /// https://groophy-inc.github.io/abs
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GValue Absolute(string value_)
        {
            GValue value = new GValue(value_);
            if (value.get_Long < 0)
            {
                return Math.Multiplication(value, new GValue("-1"));
            }
            return value;
        }

        /// <summary>
        /// https://groophy-inc.github.io/factorial
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Factorial(GValue val)
        {
            IEnumerable<int> ints = Enumerable.Range(1, val.get_Int);
            return new GValue(ints.Aggregate((f, s) => f * s).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/factorial
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static GValue Factorial(string val_)
        {
            GValue val = new GValue(val_);
            IEnumerable<int> ints = Enumerable.Range(1, val.get_Int);
            return new GValue(ints.Aggregate((f, s) => f * s).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/permutation
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Permutation(GValue n, GValue k)
        {
            return (Division(Factorial(n), Factorial(Subtraction(n, k))));
        }

        /// <summary>
        /// https://groophy-inc.github.io/permutation
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Permutation(string n_, string k_)
        {
            GValue n = new GValue(n_);
            GValue k = new GValue(k_);
            return (Division(Factorial(n), Factorial(Subtraction(n, k))));
        }

        /// <summary>
        /// https://groophy-inc.github.io/permutation
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Permutation(string n_, GValue k)
        {
            GValue n = new GValue(n_);
            return (Division(Factorial(n), Factorial(Subtraction(n, k))));
        }

        /// <summary>
        /// https://groophy-inc.github.io/permutation
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Permutation(GValue n, string k_)
        {
            GValue k = new GValue(k_);
            return (Division(Factorial(n), Factorial(Subtraction(n, k))));
        }

        /// <summary>
        /// https://groophy-inc.github.io/combination
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Combination(GValue n, GValue k)
        {
            GValue ret = Division(Factorial(n), Multiplication(Factorial(k), Factorial(Subtraction(n, k))));
            ret.get_String = (Factorial(n).ToString() + "/[" + Factorial(k).ToString() + ".("+Factorial(Subtraction(n, k).ToString()).ToString()+")] = " + ret.get_Decimal.ToString());
            return ret;
        }

        /// <summary>
        /// https://groophy-inc.github.io/combination
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Combination(string n_, string k_)
        {
            GValue n = new GValue(n_);
            GValue k = new GValue(k_);
            GValue ret = Division(Factorial(n), Multiplication(Factorial(k), Factorial(Subtraction(n, k))));
            ret.get_String = (Factorial(n).ToString() + "/[" + Factorial(k).ToString() + ".(" + Factorial(Subtraction(n, k).ToString()).ToString() + ")] = " + ret.get_Decimal.ToString());
            return ret;
        }

        /// <summary>
        /// https://groophy-inc.github.io/combination
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Combination(GValue n, string k_)
        {
            GValue k = new GValue(k_);
            GValue ret = Division(Factorial(n), Multiplication(Factorial(k), Factorial(Subtraction(n, k))));
            ret.get_String = (Factorial(n).ToString() + "/[" + Factorial(k).ToString() + ".(" + Factorial(Subtraction(n, k).ToString()).ToString() + ")] = " + ret.get_Decimal.ToString());
            return ret;
        }

        /// <summary>
        /// https://groophy-inc.github.io/combination
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static GValue Combination(string n_, GValue k)
        {
            GValue n = new GValue(n_);
            GValue ret = Division(Factorial(n), Multiplication(Factorial(k), Factorial(Subtraction(n, k))));
            ret.get_String = (Factorial(n).ToString() + "/[" + Factorial(k).ToString() + ".(" + Factorial(Subtraction(n, k).ToString()).ToString() + ")] = " + ret.get_Decimal.ToString());
            return ret;
        }

        //TODO LIM https://www.rapidtables.com/math/symbols/Calculus_Symbols.html
    }

    public class GValue
    {
        public bool get_Bool { get; set; }
        public byte get_Byte { get; set; }
        public sbyte get_Sbyte { get; set; }
        public short get_Short { get; set; }
        public ushort get_UShort { get; set; }
        public int get_Int { get; set; }
        public uint get_UInt { get; set; }
        public long get_Long { get; set; }
        public ulong get_ULong { get; set; }
        public float get_Float { get; set; }
        public double get_Double { get; set; }
        public decimal get_Decimal { get; set; }
        public string get_String { get; set; }

        public string ToString()
        {
            return get_Decimal.ToString();
        }

        public void Max()
        {
            get_Bool = true;
            get_Byte = byte.MaxValue;
            get_Decimal = decimal.MaxValue;
            get_Double = double.MaxValue;
            get_Float = float.MaxValue;
            get_Int = int.MaxValue;
            get_Long = long.MaxValue;
            get_Sbyte = sbyte.MaxValue;
            get_Short = short.MaxValue;
            get_String = int.MaxValue.ToString();
            get_UInt = uint.MaxValue;
            get_ULong = ulong.MaxValue;
            get_UShort = ushort.MaxValue;
        }

        public GValue(string Val)
        {
            get_String = Val;
            try
            {
                get_Int = Convert.ToInt16(Val);
            }
            catch
            {
                get_Int = 0;
            }
            try
            {
                get_Bool = Convert.ToBoolean(Val);
                if (get_Int == 1) get_Bool = true;
            }
            catch
            {
                get_Bool = false;
            }
            try
            {
                get_Byte = Convert.ToByte(Val);
            }
            catch
            {
                get_Byte = 0;
            }
            try
            {
                get_Decimal = Convert.ToDecimal(Val);
            }
            catch
            {
                get_Decimal = 0;
            }
            try
            {
                get_Double = Convert.ToDouble(Val);
            }
            catch
            {
                get_Double = 0;
            }
            try
            {
                get_Float = (float)Convert.ToDouble(Val);
            }
            catch
            {
                get_Float = 0;
            }
            try
            {
                get_Long = long.Parse(Val);
            }
            catch
            {
                get_Long = 0;
            }
            try
            {
                get_Sbyte = Convert.ToSByte(Val);
            }
            catch
            {
                get_Sbyte = 0;
            }
            try
            {
                get_Short = short.Parse(Val);
            }
            catch
            {
                get_Short = 0;
            }
            try
            {
                get_UInt = Convert.ToUInt16(Val);
            }
            catch
            {
                get_UInt = 0;
            }
            try
            {
                get_ULong = ulong.Parse(Val);
            }
            catch
            {
                get_ULong = 0;
            }
            try
            {
                get_UShort = ushort.Parse(Val);
            }
            catch
            {
                get_UShort = 0;
            }
        }

        public void PrintAll()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Name    | Value                  " + Environment.NewLine);
            sb.Append("Bool:     " + get_Bool.ToString() + Environment.NewLine);
            sb.Append("Byte:     " + get_Byte.ToString() + Environment.NewLine);
            sb.Append("Sbyte:    " + get_Sbyte.ToString() + Environment.NewLine);
            sb.Append("Short:    " + get_Short.ToString() + Environment.NewLine);
            sb.Append("UShort:   " + get_UShort.ToString() + Environment.NewLine);
            sb.Append("Int:      " + get_Int.ToString() + Environment.NewLine);
            sb.Append("UInt:     " + get_UInt.ToString() + Environment.NewLine);
            sb.Append("Long:     " + get_Long.ToString() + Environment.NewLine);
            sb.Append("ULong:    " + get_ULong.ToString() + Environment.NewLine);
            sb.Append("Float:    " + get_Float.ToString() + Environment.NewLine);
            sb.Append("Double:   " + get_Double.ToString() + Environment.NewLine);
            sb.Append("Decimal:  " + get_Decimal.ToString() + Environment.NewLine);
            sb.Append("String:   " + get_String.ToString() + Environment.NewLine);
            Console.WriteLine(sb.ToString());
        }
    }
}
