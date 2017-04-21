using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


public partial class Phonetics
{
    [Microsoft.SqlServer.Server.SqlFunction (IsDeterministic=true,IsPrecise=true,DataAccess=DataAccessKind.None)]
    public static SqlString LongPhonetic(SqlInt16 PhoneticType, SqlString InputString)
    {
        BasePhonetics PhoneticObject;

        string _inputString;

        if (InputString.IsNull || InputString.Value.Trim() == String.Empty)
        {
            _inputString = " ";
        }
        else
        {
            _inputString = InputString.Value;
        }

        switch (PhoneticType.Value)
        {
            case 0:
                PhoneticObject = new Soundex(_inputString);
                break;
            case 1:
                PhoneticObject = new RefinedSoundex(_inputString);
                break;
            case 2:
                PhoneticObject = new NYSIIS(_inputString);
                break;
            case 3:
                PhoneticObject = new DaitchMokotoff(_inputString);
                break;
            case 4:
                PhoneticObject = new Metaphone(_inputString);
                break;
            default:
                PhoneticObject = new Soundex(_inputString);
                PhoneticType = 0;
                break;
        }
        PhoneticObject.Iterate();
        return PhoneticObject.ReadOutput();
    }






 


    /// <summary>
    /// Single letter transforms are the 4th priority in the NYSiiS algorithm.  The others are as shown below
    /// 1.  Word start
    /// 2.  Word end
    /// 3.  Multi-letter substitutions
    /// </summary>
    /// <param name="a">The character being evaluated.</param>
    /// <returns>Where the letter requires NYSiiS encoding then the value returned will be the appropriate NYSiiS letter otherwise
    /// the letter will remain the same.
    /// Where a non-letter is identified it will be returned as a space.</returns>
    private static char NYSIISSingleLetter(char a)
    {
        if (!char.IsLetter(a))
        {
            a = ' ';
        }
        else
        {
            switch (a)
            {
                case 'E': a = 'A'; break;
                case 'I': a = 'A'; break;
                case 'K': a = 'C'; break;
                case 'M': a = 'N'; break;
                case 'O': a = 'A'; break;
                case 'Q': a = 'G'; break;
                case 'U': a = 'A'; break;
                case 'Z': a = 'S'; break;
            }
        }
        return a;
    }

    /// <summary>
    /// Simply identifies whether a letter is one of the five standard vowels.
    /// </summary>
    /// <param name="a">The char value</param>
    /// <returns>TRUE = a vowel has been identified, FALSE = It isn't a standard vowel.</returns>
    private static bool isVowel(char a)
    {
        bool returnValue = false;
        switch (a)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                returnValue = true;
                break;
            default:
                returnValue = false;
                break;
        }

        return returnValue;
    }


}


