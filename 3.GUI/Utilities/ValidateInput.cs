using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GUI.Utilities
{
    internal class ValidateInput
    {
        public static bool CheckEmpty(string Msg) => string.IsNullOrEmpty(Msg.Trim());
        public static bool InputIsOnlyNumber(string Msg) => int.TryParse(Msg.Trim(), out int x);
        // public static ValidateInput.InputIsOnlyNumber(input) ==false || (input).Substring(0, 1) != "0" || input.Length != 10 
        //demo validate check so cac thu
        static public bool CheckSDT(string s) // sdt phai nhap 10 so
        {
            if (s.Substring(0, 1) == "0" && s.Length == 10)
            {
                return true;
            }
            else return false;
        }
        static public bool CheckMk(string s)
        {
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i].ToString() == s[i].ToString().ToUpper() && CheckIntInput(s[i].ToString()) == false)
                {
                    a++;
                }
            }
            if (a == 1 && s.Length > 8) return true;
            else return false;
        }

        static public bool CheckIntInput(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return true;
            }
            else return false;
        }
    }
}

