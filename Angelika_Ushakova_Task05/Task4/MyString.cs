using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        public char[] myString;

        public MyString(string myString1)
        {
            myString = myString1.ToCharArray();
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            
            return new MyString(str1.ToString() + str2.ToString());
        }

        public static MyString operator -(MyString str1, MyString str2)
        {

            return new MyString(str1.ToString().Replace(str2.ToString(),""));
        }

        public static bool operator ==(MyString str1, MyString str2)
        {

            return str1.ToString() == str2.ToString();
        }

        public static bool operator !=(MyString str1, MyString str2)
        {

            return str1.ToString() != str2.ToString();
        }

        public override string ToString()
        {
            return new string(myString);
        }

        public override bool Equals(object obj)
        {
            var @string = obj as MyString;
            return @string != null &&
                   EqualityComparer<char[]>.Default.Equals(myString, @string.myString);
        }

        public override int GetHashCode()
        {
            return 199915334 + EqualityComparer<char[]>.Default.GetHashCode(myString);
        }
    }
}
