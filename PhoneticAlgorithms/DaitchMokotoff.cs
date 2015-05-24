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

}
