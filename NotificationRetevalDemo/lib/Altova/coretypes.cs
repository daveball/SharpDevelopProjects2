// coretypes.cs
// This file contains generated code and will be overwritten when you rerun code generation.


namespace Altova
{
    public class CoreTypes
    {
		/// <summary>
		/// Helper class for converting numbers valid according to XML Schema Part 2 : Datatypes to 
		/// numbers valid for C# parse functions.
		/// </summary>
		public class NumberParts
		{
			public readonly char Sign;
			public readonly string Mantissa;
			public readonly string Exponent;
			public readonly bool Valid;

			public NumberParts(string input)
			{
				input = input.Trim();
				if (input.StartsWith("+") || input.StartsWith("-"))
				{
					Sign = input[0];
					input = input.Substring(1);
				}
				else
					Sign = '+';

				int indexOfE = input.IndexOfAny(new char[]{'e', 'E'});
				if (indexOfE < 0)
				{
					Mantissa = input;
					Exponent = "";
				}
				else
				{
					Mantissa = input.Substring(0, indexOfE);
					Exponent = input.Substring(indexOfE + 1);
				}

				if (Mantissa.StartsWith("."))
					Mantissa = "0" + Mantissa;
				if (Mantissa.EndsWith("."))
					Mantissa = Mantissa + "0";
				if (Mantissa.Length == 0)
					Mantissa = "0";
				if (Exponent.EndsWith("+") || Exponent.EndsWith("-"))
					Exponent = Exponent + "0";
			}

			public override string ToString()
			{
				if (Exponent.Length > 0)
					return Sign + Mantissa + "E" + Exponent;
				return Sign + Mantissa;
			}

			public double ToDouble()
			{
				return double.Parse(ToString(), System.Globalization.CultureInfo.InvariantCulture);
			}

			public decimal ToDecimal()
			{
				return decimal.Parse(Sign + Mantissa, System.Globalization.CultureInfo.InvariantCulture);
			}

			public long ToLong()
			{
				int dot = Mantissa.IndexOf('.');
				if (dot >= 0)
					return long.Parse(Sign + Mantissa.Substring(0, dot));
				else
					return long.Parse(Sign + Mantissa);
			}
		
			public ulong ToULong()
			{
				int dot = Mantissa.IndexOf('.');
				if (dot >= 0)
					return ulong.Parse(Sign + Mantissa.Substring(0, dot));
				else
					return ulong.Parse(Sign + Mantissa);
			}
		
			public bool IsNumber()
			{
				try {
					double.Parse(ToString());
					return true;
				}
				catch (System.Exception)
				{
					return false;
				}
			}
		}

		static bool IsSchemaSign(char c)
		{
			return c == '+' || c == '-';
		}

		static bool IsSchemaDigit(char c)
		{
			return c >= '0' && c <= '9';
		}

		static bool IsSchemaRadix(char c)
		{
			return c == '.';
		}

		static bool IsSchemaExponent(char c)
		{
			return c == 'e' || c == 'E';
		}

		static int PrepareNumber(System.Text.StringBuilder buffer, string input)
		{
			int[,] actions = new int[9,5]{
				{ 0, 0, 1, 2, 2 },	
				{ 2, 0, 1, 2, 2 },	
				{ 2, 0, 0, 0, 2 },	
				{ 2, 0, 2, 2, 2 },	
				{ 2, 0, 2, 0, 2 },	
				{ 2, 0, 2, 1, 2 }, 
				{ 0, 0, 2, 2, 2 },
				{ 2, 0, 2, 2, 2 },
				{ 2, 0, 2, 2, 2 },
			};

			int[,] follow = new int[9,5]{ 
				{ 1, 2, 3, 9, 9 }, 
				{ 9, 2, 3, 9, 9 },
				{ 9, 2, 5, 6, 9 },
				{ 9, 4, 9, 9, 9 },
				{ 9, 4, 9, 6, 9 },
				{ 9, 4, 9, 6, 9 },
				{ 7, 8, 9, 9, 9 },
				{ 9, 8, 9, 9, 9 },
				{ 9, 8, 9, 9, 9 },
			};

			int state = 0;

			foreach(char c in input)
			{
				int cls;

				if (IsSchemaDigit(c))
					cls = 1;
				else if (IsSchemaSign(c))
					cls = 0;
				else if (IsSchemaRadix(c))
					cls = 2;
				else if (IsSchemaExponent(c))
					cls = 3;
				else
					cls = 4;

				switch (actions[state,cls])
				{
				case 0:
					buffer.Append(c);
					break;
				case 1:
					buffer.Append('0');
					buffer.Append(c);
					break;
				case 2:
					return 0;
				}
				state = follow[state, cls];
			}

			switch (state)
			{
			case 0:
			case 1:
			case 3:
			case 6:
			case 7:
				return 0;		

			case 2:
				return 1;	// integer
			case 4:
				return 2;
			case 5:
				buffer.Append('0');
				return 2;
			case 8:
				return 3;	// float
			}

			return 0;
		}

        public static int CastToInt(int i)
        {
            return i;
        }

        public static int CastToInt(uint i)
		{
            if (i > (uint)int.MaxValue)
                throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for int.", i));
            return (int)i;
		}

        public static int CastToInt(double d)
        {
            if (d < int.MinValue || d > int.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for int.", d));
			return (int) d;
        }

        public static int CastToInt(string s)
        {
			if (s == null)
				return 0;
			s = s.Trim();
			if (s == "NaN" || s == "INF" || s == "-INF")
				throw new System.OverflowException("'" + s + "' is out of range for int.");
			
			System.Text.StringBuilder bld = new System.Text.StringBuilder();
			checked 
			{ 
				switch (PrepareNumber(bld, s))
				{
					case 1:
						return int.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					case 2:
						return (int)decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
					case 3:
						return (int)double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					default:
						throw new System.ArgumentException("'" + s + "' cannot be parsed as int.");
				}
			}
        }

        public static int CastToInt(long i)
        {
            if (i < int.MinValue || i > int.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for int.", i));
			return (int) i;
        }

        public static int CastToInt(ulong i)
        {
            if (i > (ulong)int.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for int.", i));
			return (int)i;
        }

		public static int CastToInt(decimal d)
		{
			return (int)d;
		}

        public static uint CastToUInt(int i)
        {
            if (i < 0)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for uint.", i));
			return (uint) i;

        }

        public static uint CastToUInt(uint i)
        {
            return i;
        }

        public static uint CastToUInt(double d)
        {
            if (d < 0 || d > uint.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for uint.", d));
			return (uint) d;
        }

        public static uint CastToUInt(string s)
        {
			if (s == null)
				return 0;
			s = s.Trim();
			if (s == "NaN" || s == "INF" || s == "-INF")
				throw new System.OverflowException("'" + s + "' is out of range for int.");
			
			System.Text.StringBuilder bld = new System.Text.StringBuilder();
			checked 
			{ 
				switch (PrepareNumber(bld, s))
				{
					case 1:
						return uint.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					case 2:
						return (uint)decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
					case 3:
						return (uint)double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					default:
						throw new System.ArgumentException("'" + s + "' cannot be parsed as int.");
				}
			}
        }

        public static uint CastToUInt(long i)
        {
            if (i < 0 || i > uint.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for uint.", i));
			return (uint) i;
        }

        public static uint CastToUInt(ulong i)
        {
            if (i > uint.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for uint.", i));
			return (uint) i;
        }

		public static uint CastToUInt(decimal d)
		{
			return (uint)d;
		}


        public static long CastToInt64(int i)
        {
            return (long) i;
        }

        public static long CastToInt64(uint i)
        {
            return (long)i;
        }

        public static long CastToInt64(double d)
        {
            if (d < long.MinValue || d > long.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for long.", d));
			return (long) d;
        }

        public static long CastToInt64(string s)
        {
			if (s == null)
				return 0;
			s = s.Trim();
			if (s == "NaN" || s == "INF" || s == "-INF")
				throw new System.OverflowException("'" + s + "' is out of range for int.");
			
			System.Text.StringBuilder bld = new System.Text.StringBuilder();
			checked 
			{ 
				switch (PrepareNumber(bld, s))
				{
					case 1:
						return long.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					case 2:
						return (long)decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
					case 3:
						return (long)double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					default:
						throw new System.ArgumentException("'" + s + "' cannot be parsed as int.");
				}
			}
        }

        public static long CastToInt64(long i)
        {
            return i;
        }

        public static long CastToInt64(ulong i)
        {
            if (i > long.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for long.", i));
			return (long) i;
        }

		public static long CastToInt64(decimal d)
		{
			return (long)d;
		}


        public static ulong CastToUInt64(int i)
        {
            if (i < 0)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for ulong.", i));
			return (ulong) i;
        }

        public static ulong CastToUInt64(uint i)
        {
            return (ulong)i;
        }

        public static ulong CastToUInt64(double d)
        {
            if (d < 0 || d > ulong.MaxValue)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for ulong.", d));
			return (ulong) d;
        }

        public static ulong CastToUInt64(string s)
        {
			if (s == null)
				return 0;
			s = s.Trim();
			if (s == "NaN" || s == "INF" || s == "-INF")
				throw new System.OverflowException("'" + s + "' is out of range for int.");
			
			System.Text.StringBuilder bld = new System.Text.StringBuilder();
			checked 
			{ 
				switch (PrepareNumber(bld, s))
				{
					case 1:
						return ulong.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					case 2:
						return (ulong)decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
					case 3:
						return (ulong)double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					default:
						throw new System.ArgumentException("'" + s + "' cannot be parsed as int.");
				}
			}
        }

        public static ulong CastToUInt64(long i)
        {
            if (i < 0)
				throw new System.OverflowException(string.Format("Numeric value overflow: {0} out of range for ulong.", i));
			return (ulong) i;
        }

        public static ulong CastToUInt64(ulong i)
        {
            return i;
        }

		public static ulong CastToUInt64(decimal d)
		{
			return (ulong)d;
		}

        public static double CastToDouble(bool b)
        {
            return b?1:0;
        }

        public static double CastToDouble(int i)
        {
            return (double) i;
        }

        public static double CastToDouble(uint i)
        {
            return (double) i;
        }

        public static double CastToDouble(long i)
        {
            return (double) i;
        }

        public static double CastToDouble(ulong i)
        {
            return (double) i;
        }

        public static double CastToDouble(double d)
        {
            return d;
        }

        public static double CastToDouble(string s)
        {
			if (s == null)
				return 0;
			s = s.Trim();
			if (s == "NaN")
				return double.NaN;
			else if (s == "INF")
				return double.PositiveInfinity;
			else if (s == "-INF")
				return double.NegativeInfinity;
			
			System.Text.StringBuilder bld = new System.Text.StringBuilder();
			checked 
			{ 
				switch (PrepareNumber(bld, s))
				{
					case 1:
					case 2:
					case 3:
						return double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					default:
						throw new System.ArgumentException("'" + s + "' cannot be parsed as int.");
				}
			}
        }

		public static double CastToDouble(decimal d)
		{
			return (double)d;
		}
        
		public static decimal CastToDecimal(bool b)
		{
			return b ? 1 : 0;
		}

		public static decimal CastToDecimal(int i)
		{
			return i;
		}

		public static decimal CastToDecimal(uint i)
		{
			return i;
		}

		public static decimal CastToDecimal(long i)
		{
			return i;
		}

		public static decimal CastToDecimal(ulong i)
		{
			return i;
		}

		public static decimal CastToDecimal(double i)
		{
			return (decimal)i;
		}

		public static decimal CastToDecimal(decimal i)
		{
			return i;
		}

		public static decimal CastToDecimal(string s)
		{
			if (s == null)
				return 0;
			s = s.Trim();
			if (s == "NaN" || s == "INF" || s == "-INF")
				throw new System.OverflowException("'" + s + "' is out of range for int.");
			
			System.Text.StringBuilder bld = new System.Text.StringBuilder();
			checked 
			{ 
				switch (PrepareNumber(bld, s))
				{
					case 1:
					case 2:
						return decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
					case 3:
						return (decimal)double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

					default:
						throw new System.ArgumentException("'" + s + "' cannot be parsed as int.");
				}
			}
		}

        public static string CastToString(int i)
        {
            return i.ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static string CastToString(uint i)
        {
            return i.ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static string CastToString(long i)
        {
            return i.ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static string CastToString(ulong i)
        {
            return i.ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static string CastToString(double d)
        {
            return d.ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static string CastToString(string s)
        {
            return s;
        }

        public static string CastToString(bool b)
        {
            if (b) 
                return "true";
            return "false";
        }

        public static string CastToString(Altova.Types.DateTime dt)
        {
            return dt.ToString();
        }

		public static string CastToString(Altova.Types.DateTime dt, Altova.Types.DateTimeFormat format)
		{
			return dt.ToString(format);
		}
		
		public static string CastToString(object o_which_is_a_dt, Altova.Types.DateTimeFormat format)
		{
			return ((Altova.Types.DateTime)o_which_is_a_dt).ToString(format);
		}
		

        public static string CastToString(Altova.Types.Duration dur)
        {
            return dur.ToString();
        }

		public static string CastToString(byte[] val)
		{
			return System.Convert.ToBase64String(val);
		}

		public static string CastToString(decimal d)
		{
			string s = d.ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
			int iComma = s.LastIndexOf('.');
			if( iComma >= 0 )
			{
				if (s.Length > iComma)
					s = s.TrimEnd(new char[] { '0' });
				if (s.Length == iComma + 1)
					s = s.Substring(0, iComma);
			}
			if( s.Length == 0 )
				s = "0";
			return s;
		}



        /*
        public static string CastToString(Altova.Types.DayTimeDuration dt)
        {
            return dt.ToString();
        }

        public static string CastToString(Altova.Types.YearMonthDuration dur)
        {
            return dur.ToString();
        }
        */

        public static Altova.Types.DateTime CastToDateTime(string s)
        {
			if (s == null)
                throw new System.NullReferenceException();
			if (s == "")
                throw new Altova.Types.StringParseException("Cast to DateTime failed.");
            return Altova.Types.DateTime.Parse(s);
        }

        public static Altova.Types.Duration CastToDuration(string s)
        {
			if (s == null)
                throw new System.NullReferenceException();
			if (s == "")
                throw new Altova.Types.StringParseException("Cast to Duration failed.");
            return Altova.Types.Duration.Parse(s);
        }

        /*
        public static Altova.Types.YearMonthDuration CastToYearMonthDuration(string s)
        {
            return Altova.Types.YearMonthDuration.Parse(s);
        }

        public static Altova.Types.DayTimeDuration CastToDayTimeDuration(string s)
        {
            return Altova.Types.DayTimeDuration.Parse(s);
        }
        */

        public static Altova.Types.DateTime CastToDateTime(Altova.Types.DateTime s)
        {
            return s;
        }

		public static Altova.Types.DateTime CastToDateTime(Altova.Types.DateTime s, Altova.Types.DateTimeFormat format)
		{
			return s;
		}

		public static Altova.Types.Duration CastToDuration(Altova.Types.Duration s)
        {
            return s;
        }

        /*
        public static Altova.Types.YearMonthDuration CastToYearMonthDuration(Altova.Types.YearMonthDuration s)
        {
            return s;
        }

        public static Altova.Types.DayTimeDuration CastToDayTimeDuration(Altova.Types.DayTimeDuration s)
        {
            return s;
        }
        */

        public static bool CastToBool(bool b)
        {
            return b;
        }

        public static bool CastToBool(int i)
        {
            return i != 0;
        }

        public static bool CastToBool(uint i)
        {
            return i != 0;
        }

        public static bool CastToBool(long i)
        {
            return i != 0;
        }

        public static bool CastToBool(ulong i)
        {
            return i != 0;
        }

        public static bool CastToBool(double d)
        {
            return d != 0;
        }

        public static bool CastToBool(string s)
        {
			if (s == null)
				return false;
            if (s == "false" || s == "0" || s == "")
                return false;
            return true;
        }

		public static bool CastToBool(decimal d)
		{
			return d != 0;
		}
        
        public static bool Exists(object o)
        {
            return o != null;
        }
   		
        public static int CastToInt(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();

			if (v is string)
				return CastToInt((string)v);

			return System.Convert.ToInt32(v, System.Globalization.CultureInfo.InvariantCulture);
		}             

		public static uint CastToUInt(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();

			if (v is string)
				return CastToUInt((string)v);
			return System.Convert.ToUInt32(v, System.Globalization.CultureInfo.InvariantCulture);
		}

		public static string CastToString(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is Altova.Types.DateTime)
				return CastToString(CastToDateTime(v));
			if (v is System.Boolean)
				return CastToString(CastToBool(v));	// to ensure the returned string is not capitalized
			if (v is System.Decimal)
				return CastToString(CastToDecimal(v));	// to ensure the returned string has our desired format
			return System.Convert.ToString(v, System.Globalization.CultureInfo.InvariantCulture);
		}

		public static double CastToDouble(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToDouble((string)v);
			return System.Convert.ToDouble(v, System.Globalization.CultureInfo.InvariantCulture);
		}

		public static decimal CastToDecimal(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToDecimal((string)v);
			return System.Convert.ToDecimal(v, System.Globalization.CultureInfo.InvariantCulture);
		}


		public static long CastToInt64(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToInt64((string)v);
			return System.Convert.ToInt64(v, System.Globalization.CultureInfo.InvariantCulture);
		}

		public static ulong CastToUInt64(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToUInt64((string)v);
			return System.Convert.ToUInt64(v, System.Globalization.CultureInfo.InvariantCulture);
		}

		public static bool CastToBool(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToBool((string)v);
			return System.Convert.ToBoolean(v, System.Globalization.CultureInfo.InvariantCulture);
		}

		public static Altova.Types.DateTime CastToDateTime(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToDateTime((string)v);            
			return (Altova.Types.DateTime)v;
		}

		public static Altova.Types.DateTime CastToDateTime(object v, Altova.Types.DateTimeFormat format)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToDateTime((string)v, format);            
			return (Altova.Types.DateTime)v;
		}

		public static Altova.Types.Duration CastToDuration(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			if (v is string)
				return CastToDuration((string)v);
			return (Altova.Types.Duration)v;
		}

		public static byte[] CastToBinary(object v)
		{
			if (!Exists(v))
				throw new System.NullReferenceException();
			return (byte[]) v;
		}
     
        public static byte[] CastToBinary(byte[] b) { return b; }
        
        public static string FormatNumber(uint value, uint minDigits)
        {
            return value.ToString("D" + minDigits.ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
        }
        
        public static string FormatNumber(int value, uint minDigits)
        {
            return value.ToString("D" + minDigits.ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static string FormatTimezone(int value)
        {
            string result = "";
            
            if (value == 0)
                result += 'Z';
            else
            {
                if (value < 0)
                {
                    result += '-';
                    value = -value;
                }
                else
                {
                    result += '+';
                }
                result += FormatNumber((uint) value / 60, 2);
                result += ':';
                result += FormatNumber((uint) value % 60, 2);
            }
            return result;
        }

        public static string FormatFraction(uint value, uint precision)
        {
            string result = "";
	        if (value != 0)
	        {
		        result += '.';
		        result += FormatNumber(value, precision);
                int i = result.Length;
		        while (result[i - 1] == '0')
			        i -= 1;
                result = result.Remove(i, result.Length-i);
	        }
            return result;
        }
    }
}
