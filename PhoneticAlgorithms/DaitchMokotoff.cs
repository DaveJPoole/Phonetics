using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DaitchMokotoff : GeneralPhonetics
{
    public DaitchMokotoff(string inputString) : base(inputString) {
        TwoCharacterReplacements = new char[] { 'X' }; 
    }


    public override void Iterate()
    {
        base.Iterate();
    }

    public override void PhoneticAlgorithm()
    {
        if (IsStartOfWord())
        {
            if (!(ProcessWordStart()))
            {
                _outputArray[_validCharacterPosition++] = _inputArray[_currentCharacterPosition];
            }

        }
        else
        {
            if (_currentCharacterPosition>0 && isVowel(_inputArray[_currentCharacterPosition - 1]))
            {
                if (!(ProcessWordAfterVowel()))
                {
                    if (!char.IsLetter(_inputArray[_currentCharacterPosition])){
                         _outputArray[_validCharacterPosition++]=' ';
                    }

                }
            }

        }

    }

    /// <summary>
    /// Carries out any character substitutions necessary at the start of a word.  Where a valid substitution is not detected
    /// the responsibility for handling the character is handled by the calling method.
    /// </summary>
    /// <returns>TRUE = The word start substitution algorithm successfully identified and replaced an 'n' character word start.</returns>
    private bool ProcessWordStart()
    {
        bool returnValue = false;
        for (int i = 0; i < DaitchMokotoffUtility.WORDSTART.Length; i++)
        {
            if (ArrayMatchFromPosition(_currentCharacterPosition, DaitchMokotoffUtility.WORDSTART[i][0]) == DaitchMokotoffUtility.WORDSTART[i][0].Length)
            {
                returnValue = ArrayReplaceFromPosition(DaitchMokotoffUtility.WORDSTART[i][0], DaitchMokotoffUtility.WORDSTART[i][1]);
                if (returnValue) { break; }
            }
        }
        return returnValue;

    }

    /// <summary>
    /// Carries out any character substitution necessary where a vowel is detected as the preceding character.
    /// </summary>
    /// <returns>TRUE = The after vowel substitution algorithm successfully identified and replaced an 'n' character word </returns>
    private bool ProcessWordAfterVowel()
    {
        bool returnValue = false;
        for (int i = 0; i < DaitchMokotoffUtility.AFTERVOWEL.Length; i++)
        {
            if (ArrayMatchFromPosition(_currentCharacterPosition, DaitchMokotoffUtility.AFTERVOWEL[i][0]) == DaitchMokotoffUtility.AFTERVOWEL[i][0].Length)
            {
                returnValue = ArrayReplaceFromPosition(DaitchMokotoffUtility.AFTERVOWEL[i][0], DaitchMokotoffUtility.AFTERVOWEL[i][1]);
                if (returnValue) { break; }
            }
        }
        return returnValue;


    }
/// <summary>
    /// Carries out any character substitution necessary where a valid letter that is a non-vowel is detected as the preceding character.
/// </summary>
/// <returns></returns>
    private bool ProcessWordAfterNonVowel()
    {
        bool returnValue = false;
        for (int i = 0; i < DaitchMokotoffUtility.AFTERVOWEL.Length; i++)
        {
            if (ArrayMatchFromPosition(_currentCharacterPosition, DaitchMokotoffUtility.AFTERVOWEL[i][0]) == DaitchMokotoffUtility.AFTERVOWEL[i][0].Length)
            {
                returnValue = ArrayReplaceFromPosition(DaitchMokotoffUtility.AFTERVOWEL[i][0], DaitchMokotoffUtility.AFTERVOWEL[i][1]);
                if (returnValue) { break; }
            }
        }
        return returnValue;


    }

}
