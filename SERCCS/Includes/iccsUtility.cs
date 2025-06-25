using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SERCCS.Includes
{
    public static class SERCCSUility
    {
        //public void clearTxt(Control container)
        //{
        //    try
        //    {
        //        //'for each txt as control in this(object).control
        //        foreach (Control txt in container.Controls)
        //        {
        //            //conditioning the txt as control by getting it's type.
        //            //the type of txt as control must be textbox.
        //            if (txt is TextBox)
        //            {
        //                //if the object(textbox) is present. The result is, the textbox will be cleared.
        //                txt.Text = "";
        //            }
        //            if (txt is RichTextBox)
        //            {
        //                txt.Text = "";
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        ////initialize the validating method
        //static Regex Valid_Name = StringOnly();
        //static Regex Valid_Contact = NumbersOnly();
        //static Regex Valid_Password = ValidPassword();
        //static Regex Valid_Email = Email_Address();



        //Method for validating email address
        private static Regex Email_Address()
        {
            string Email_Pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(Email_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for string validation only
        private static Regex StringOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for numbers validation only
        private static Regex NumbersOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]*$";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for password validation only
        private static Regex ValidPassword()
        {
            string Password_Pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(Password_Pattern, RegexOptions.IgnoreCase);
        }

        private static String[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        private static String[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };





        //public void ResponsiveDtg(DataGridView dtg)
        //{
        //    dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //}


        //public string my_encript(String xnm)
        //{
        //    String enac;
        //    char[] ena = new char[19];
        //   enac = "0107021703060419051006160703081109131004111812091301141215051614170218151908";
        //    String x = xnm.Trim();
        //    String wr = "";
        //    String my_encript = "";
        //    if (x.Length == 0) return wr;
        //    int j = 1;
        //    for (int i = 1; i == 19; i++)
        //    {
        //        ena[i] = enac.Substring(j, 4);
        //    }

        //}
        //////Dim ena(19) As Variant, enac As String
        //////x = Trim(xnm)
        //////wr = ""
        //////my_encript = ""
        //////If Len(x) = 0 Then Exit Function
        //////enac = "0107021703060419051006160703081109131004111812091301141215051614170218151908"
        ////j = 1
        ////For i = 1 To 19
        //// ena(i) = Mid(enac, j, 4)
        //// j = j + 4
        ////Next
        ////For i = 1 To Len(x)
        ////   y = Asc(Mid(x, i, 1))
        ////   Y1 = (y - 31) / 5
        ////   blk = IIf(Int(Y1) = Y1, Y1, Int(Y1) + 1)
        ////   bch = (Y1 - Int(Y1)) * 5
        ////   If bch = 0 Then bch = 5
        ////   v = 0
        ////   For j = 1 To 19
        ////     Y2 = Val(Right(ena(j), 2))
        ////     If blk = Y2 Then
        ////        y3 = Val(Left(ena(j), 2))
        ////        y4 = (y3 - 1) * 5
        ////        wr = wr + Chr(159 + y4 + bch)
        ////        v = 1
        ////     End If
        ////   Next
        ////Next
        ////my_encript = wr
        ////End Function
        //Public Function my_decript(ByVal xnm As String) As String
        //Dim ena(19) As Variant, enac As String
        //x = Trim(xnm)
        //wr = ""
        //my_decript = ""
        //If Len(x) = 0 Then Exit Function
        //enac = "0107021703060419051006160703081109131004111812091301141215051614170218151908"
        //j = 1
        //For i = 1 To 19
        // ena(i) = Mid(enac, j, 4)
        // j = j + 4
        //Next
        //For i = 1 To Len(x)
        //   y = Asc(Mid(x, i, 1))
        //   Y1 = (y - 159) / 5
        //   blk = IIf(Int(Y1) = Y1, Y1, Int(Y1) + 1)
        //   bch = (Y1 - Int(Y1)) * 5
        //   If bch = 0 Then bch = 5
        //   For j = 1 To 19
        //     Y2 = Val(Left(ena(j), 2))
        //     If blk = Y2 Then
        //        y3 = Val(Right(ena(j), 2))
        //        y4 = (y3 - 1) * 5
        //        cr = Round((31 + bch + y4), 0)
        //        wr = wr + Chr(cr)
        //     End If
        //   Next
        //Next
        //my_decript = wr
        //End Function


        public static string Encryptdata(string password)
        {
            password = ReverseString(password);
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }

        public static string Decryptdata(string encryptpwd)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            decryptpwd = ReverseString(decryptpwd);
            return decryptpwd;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }



        public static String ConvertAmount(double amount)
        {
            try
            {
                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return ConvertToWord(amount_int) + " Only.";
                }
                else
                {
                    return ConvertToWord(amount_int) + " Point " + ConvertToWord(amount_dec) + " Only.";
                }
            }
            catch (Exception e)
            {
                // TODO: handle exception  
            }
            return "";
        }

        public static String ConvertToWord(Int64 i)
        {
            if (i < 20)
            {
                return units[i];
            }
            if (i < 100)
            {
                return tens[i / 10] + ((i % 10 > 0) ? " " + ConvertToWord(i % 10) : "");
            }
            if (i < 1000)
            {
                return units[i / 100] + " Hundred"
                        + ((i % 100 > 0) ? " And " + ConvertToWord(i % 100) : "");
            }
            if (i < 100000)
            {
                return ConvertToWord(i / 1000) + " Thousand "
                + ((i % 1000 > 0) ? " " + ConvertToWord(i % 1000) : "");
            }
            if (i < 10000000)
            {
                return ConvertToWord(i / 100000) + " Lakh "
                        + ((i % 100000 > 0) ? " " + ConvertToWord(i % 100000) : "");
            }
            if (i < 1000000000)
            {
                return ConvertToWord(i / 10000000) + " Crore "
                        + ((i % 10000000 > 0) ? " " + ConvertToWord(i % 10000000) : "");
            }
            return ConvertToWord(i / 1000000000) + " Arab "
                    + ((i % 1000000000 > 0) ? " " + ConvertToWord(i % 1000000000) : "");
        }


    }
}
