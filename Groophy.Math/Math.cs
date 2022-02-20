using System;
using Mathos.Parser;
namespace Groophy.Math
{
    public class Math
    {
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
        /// https://groophy-inc.github.io/Exponent
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Exponent(GValue from, GValue to)
        {
            return new GValue((Math.Power(from, to)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/Exponent
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Power(GValue from, GValue to)
        {
            return new GValue((Math.Power(from, to)).ToString());
        }

        /// <summary>
        /// https://groophy-inc.github.io/Exponent
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static GValue Caret(GValue from, GValue to)
        {
            return new GValue((Math.Power(from, to)).ToString());
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
            parser.LocalVariables.Add("n", 0);
            for (int i = n.get_Int; i < to.get_Int;i++ )
            {
                parser.LocalVariables["n"] = i;
                result += parser.Parse(formula);
            }
            return new GValue((result.ToString()));
        }
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
