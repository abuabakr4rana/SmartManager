using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SmartManger_V._1_
{
    public class Validations
    {
        #region validations
        public static bool IsUsernameValid(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"^[a-zA-Z][a-zA-Z0-9]*$";
            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);
            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEmailValid(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);
            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsTextOnly(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"/^[A-Za-z]+$/";
            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);
            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsMobileNo(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$";
            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);
            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCNIC(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$";
            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);
            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsNumberOnly(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"^[0-9]*$";
            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);
            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsName(string textToValidate)
        {
            Regex TheRegExpression;
            string TheTextToValidate;
            string TheRegExTest = @"([A-Z][a-zA-Z]*)";
            TheTextToValidate = textToValidate;
            TheRegExpression = new Regex(TheRegExTest);
            // test text with expression
            if (TheRegExpression.IsMatch(TheTextToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
