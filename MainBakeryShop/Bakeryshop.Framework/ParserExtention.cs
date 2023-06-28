using System.Drawing;

namespace System
{
    public static class ParserExtension
    {
        #region ToLong

        public static long ToLong(this object value)
        {
            try
            {
                if (value == null)
                    return 0;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return 0;
                else
                    return long.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static long ToLong(this object value, long DefaultValue)
        {
            try
            {
                if (value == null)
                    return DefaultValue;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return DefaultValue;
                else
                    return long.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public static long? ToLongNull(this object value)
        {
            try
            {
                if (value == null)
                    return null;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return long.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToInt

        public static int ToInt(this object value)
        {
            try
            {
                if (value == null)
                    return 0;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt32(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return 0;
                else
                    return int.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int ToInt(this object value, int DefaultValue)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return DefaultValue;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt32(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return DefaultValue;
                else
                    return int.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public static int? ToIntNull(this object value)
        {
            try
            {
                if (value == null)
                    return null;
                else if ((value is long)
                                    || (value is int)
                                    || (value is short)
                                    || (value is byte)
                                    || (value is float)
                                    || (value is decimal)
                                    || (value is double))
                    return Convert.ToInt32(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return int.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToDecimal

        public static decimal ToDecimal(this object value)
        {
            try
            {
                if (value == null)
                    return 0;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return 0;
                else
                    return decimal.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static decimal ToDecimal(this object value, decimal DefaultValue)
        {
            try
            {
                if (value == null)
                    return DefaultValue;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return DefaultValue;
                else
                    return decimal.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public static decimal? ToDecimalNull(this object value)
        {
            try
            {
                if (value == null)
                    return null;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return decimal.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToDouble

        public static double ToDouble(this object value)
        {
            try
            {
                if (value == null)
                    return 0;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return 0;
                else
                    return double.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static double ToDouble(this object value, double DefaultValue)
        {
            try
            {
                if (value == null)
                    return DefaultValue;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return DefaultValue;
                else
                    return double.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public static double? ToDoubleNull(this object value)
        {
            try
            {
                if (value == null)
                    return null;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return double.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToFloat

        public static float ToFloat(this object value)
        {
            try
            {
                if (value == null)
                    return 0;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return 0;
                else
                    return float.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static float ToFloat(this object value, float DefaultValue)
        {
            try
            {
                if (value == null)
                    return DefaultValue;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return DefaultValue;
                else
                    return float.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public static float? ToFloatNull(this object value)
        {
            try
            {
                if (value == null)
                    return null;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt64(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return float.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToShort

        public static short ToShort(this object value)
        {
            try
            {
                if (value == null)
                    return 0;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt16(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return 0;
                else
                    return short.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static short ToShort(this object value, short DefaultValue)
        {
            try
            {
                if (value == null)
                    return DefaultValue;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt16(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return DefaultValue;
                else
                    return short.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public static short? ToShortNull(this object value)
        {
            try
            {
                if (value == null)
                    return null;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToInt16(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return short.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToByte

        public static byte ToByte(this object value)
        {
            try
            {
                if (value == null)
                    return 0;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToByte(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return 0;
                else
                    return byte.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static byte ToByte(this object value, byte DefaultValue)
        {
            try
            {
                if (value == null)
                    return DefaultValue;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToByte(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return DefaultValue;
                else
                    return byte.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public static byte? ToByteNull(this object value)
        {
            try
            {
                if (value == null)
                    return null;
                else if ((value is long)
                    || (value is int)
                    || (value is short)
                    || (value is byte)
                    || (value is float)
                    || (value is decimal)
                    || (value is double))
                    return Convert.ToByte(value);
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return byte.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToString

        public static string ToStringValue(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return "";
                else
                    return value.ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static string ToStringValue(this object value, string DefaultValue)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return DefaultValue;
                else
                    return value.ToString();
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        #endregion

        #region ToBoolean

        public static bool ToBoolean(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return false;
                else
                    return bool.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool? ToBooleanNull(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return null;
                else
                    return bool.Parse(value.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        #region ToDate

        public static long ToDateLong(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return 0;
                else if ((value is string) && value.ToString().Split('/').Count() == 3)
                {
                    int Year = int.Parse(value.ToString().Split('/')[0]);
                    int Month = int.Parse(value.ToString().Split('/')[1]);
                    int Day = int.Parse(value.ToString().Split('/')[2]);
                    return Year * 10000 + Month * 100 + Day;
                }
                else
                    return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static string ToDateString(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return "";
                else
                {
                    long val = value.ToLong();
                    int Year = (int)(val / 10000);
                    int Month = (int)(val / 100 % 100);
                    int Day = (int)(val % 100);
                    return Year.ToString("0000") + "/" + Month.ToString("00") + "/" + Day.ToString("00");
                }
            }
            catch (Exception e)
            {
                return "";
            }
        }

        #endregion

        #region ToTime

        public static int ToTimeInt(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return 0;
                else if ((value is string) && value.ToString().Split(':').Count() == 2)
                {
                    int Hour = int.Parse(value.ToString().Split(':')[0]);
                    int Minute = int.Parse(value.ToString().Split(':')[1]);
                    return Hour * 60 + Minute;
                }
                else
                    return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int? ToTimeIntNull(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return null;
                else if ((value is string) && value.ToString().Split(':').Count() == 2 && value.ToString().Split(':')[1].Length == 2 && value.ToString().Split(':')[0].Length > 0)
                {
                    int Hour = int.Parse(value.ToString().Split(':')[0]);
                    int Minute = int.Parse(value.ToString().Split(':')[1]);
                    return Hour * 60 + Minute;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string ToTimeString(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return "";
                else if (value is int)
                {
                    int Hour = Convert.ToInt32(value) / 60;
                    int Minute = Convert.ToInt32(value) % 60;
                    return ((Hour < 10) ? "0" : "") + Hour.ToString() + ":" + ((Minute < 10) ? "0" : "") + Minute.ToString();
                }
                else
                    return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        #endregion

        #region IsNullOrEmpty

        public static bool IsNullOrEmpty(this object value)
        {
            try
            {
                if (value == null)
                    return true;
                else if ((value is string) && string.IsNullOrEmpty(value.ToString()))
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return true;
            }
        }

        public static int HexToInt(this string value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return 0;
                else
                {
                    int result = 0;
                    while (!value.IsNullOrEmpty())
                    {
                        string val = value[0].ToString();
                        value = value.Substring(1);
                        int r = 0;
                        if ((val == "0") || (val == "1") || (val == "2") || (val == "3") || (val == "4") || (val == "5")
                            || (val == "6") || (val == "7") || (val == "8") || (val == "9"))
                            r = val.ToInt();
                        else if ((val == "a") || (val == "A"))
                            r = 10;
                        else if ((val == "b") || (val == "B"))
                            r = 11;
                        else if ((val == "c") || (val == "C"))
                            r = 12;
                        else if ((val == "d") || (val == "D"))
                            r = 13;
                        else if ((val == "e") || (val == "E"))
                            r = 14;
                        else if ((val == "f") || (val == "F"))
                            r = 15;
                        result = result * 16 + r;
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        #endregion

        #region ToColor

        public static Color ToColor(this object value)
        {
            try
            {
                if (value.IsNullOrEmpty())
                    return Color.Transparent;
                else if (value is string)
                {
                    string strValue = value.ToString();
                    if (strValue.StartsWith("#"))
                        strValue = strValue.Substring(1);
                    int a = 255;
                    int r = 255;
                    int g = 255;
                    int b = 255;
                    if (strValue.Length == 6)
                    {
                        r = strValue.Substring(0, 2).HexToInt();
                        g = strValue.Substring(2, 2).HexToInt();
                        b = strValue.Substring(4, 2).HexToInt();
                    }
                    else if (strValue.Length == 8)
                    {
                        a = strValue.Substring(0, 2).HexToInt();
                        r = strValue.Substring(2, 2).HexToInt();
                        g = strValue.Substring(4, 2).HexToInt();
                        b = strValue.Substring(6, 2).HexToInt();
                    }
                    return Color.FromArgb(a, r, g, b);
                }
                else
                    return Color.Transparent;
            }
            catch (Exception e)
            {
                return Color.Transparent;
            }
        }

        #endregion

        #region ToEnglishDigit

        public static string ToEnglishDigit(this string persianStr)
        {
            Dictionary<char, char> LettersDictionary = new Dictionary<char, char>
            {
                ['۰'] = '0',
                ['۱'] = '1',
                ['۲'] = '2',
                ['۳'] = '3',
                ['۴'] = '4',
                ['۵'] = '5',
                ['۶'] = '6',
                ['۷'] = '7',
                ['۸'] = '8',
                ['۹'] = '9'
            };
            foreach (var item in LettersDictionary)
            {
                persianStr = persianStr.Replace(item.Key, item.Value);
            }
            return persianStr;
        }

        #endregion

        #region RandomItemOfList

        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var r = new Random();
            var list = enumerable as IList<T> ?? enumerable.ToList();
            return (list.Count == 0 ? default(T) : list[r.Next(0, list.Count)]) ?? throw new InvalidOperationException();
        }

        #endregion
    }
}
