using System;

class Program
{
    static void Main()
    {
        char c;
        string st;
        //c = "";                     // "c" es de tipo "char" y se le quiere guardar un "string"
        //c = '';                      // "c" es de tipo "char" y no le gusta el apostrofe a Visual
        st = "";                  // OK
        //st = '';                  // "st" es de tipo "string" y no le gusta el apostrofe a Visual
        //st = (char)65;            // Cannot implicitly convert type 'char' to 'string'
        //st = (string)65;            //Cannot convert type 'int' to 'string'
        st = 47.ToString();         // OK usa int.ToString()
        st = 47.89.ToString();      // OK usa double.ToString()
    }
}