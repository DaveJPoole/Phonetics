using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class NYSIIS : GeneralPhonetics
{
 
    public NYSIIS(string inputString) : base(inputString) { }

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
            if (!ProcessWordEnd())
            {
                if (!ProcessWordMiddle()) { 
                    _outputArray[_validCharacterPosition++] = _inputArray[_currentCharacterPosition];
                }
            }
        }
    }

    public override void Iterate()
    {
        base.Iterate();
        base.CleanOutputArray();
    }
    /// <summary>
    /// Carries out any character substitutions necessary at the start of a word.  Where a valid substitution is not detected
    /// the responsibility for handling the character is handled by the calling method.
    /// </summary>
    /// <returns>TRUE = The word start substitution algorithm successfully identified and replaced an 'n' character word start.</returns>
    private bool ProcessWordStart()
    {
        bool returnValue = false;
        for (int i = 0; i < NYSIISUtility.WORDSTART.Length; i++)
        {
            if (ArrayMatchFromPosition(_currentCharacterPosition, NYSIISUtility.WORDSTART[i][0]) == NYSIISUtility.WORDSTART[i][0].Length)
            {
                returnValue = ArrayReplaceFromPosition(NYSIISUtility.WORDSTART[i][0], NYSIISUtility.WORDSTART[i][1]);
                if (returnValue) { break; }
            }
        }
        return returnValue;

    }
    /// <summary>
    /// Detects whether or not a substitution can be made at the end of the word.
    /// </summary>
    /// <returns>TRUE = An 'n' character substitution was achieved at the end of a word.</returns>
    private bool ProcessWordEnd()
    {
        bool returnValue = false;
        for (int i = 0; i < NYSIISUtility.WORDEND.Length; i++)
        {
            if (ArrayMatchFromPosition(_currentCharacterPosition, NYSIISUtility.WORDEND[i][0]) == NYSIISUtility.WORDEND[i][0].Length)
            {
                if ((NYSIISUtility.WORDEND[i][0].Length + _currentCharacterPosition == _inputArray.Length)
                    ||(!char.IsLetter(_inputArray[_currentCharacterPosition+NYSIISUtility.WORDEND[i][0].Length]))) { 
                returnValue = ArrayReplaceFromPosition(NYSIISUtility.WORDEND[i][0], NYSIISUtility.WORDEND[i][1]);
                    if (returnValue) { break; }
                }
            }

        }
        return returnValue;


    }
    /// <summary>
    /// The assumption is that this routine will be called only after the processing for word start and end has taken place.
    /// </summary>
    /// <returns>TRUE = A substitution was made successfully.  If this function returns FALSE it indicates that there has been a break down
    /// in the logic as this routine should substitute non-characters for spaces and copy characters that should not change.</returns>
    private bool ProcessWordMiddle() {
        bool returnValue = false;
        for (int i = 0; i < NYSIISUtility.WORDMIDDLE.Length; i++)
        {
            if (ArrayMatchFromPosition(_currentCharacterPosition, NYSIISUtility.WORDMIDDLE[i][0]) == NYSIISUtility.WORDMIDDLE[i][0].Length)
            {
                    returnValue = ArrayReplaceFromPosition(NYSIISUtility.WORDMIDDLE[i][0], NYSIISUtility.WORDMIDDLE[i][1]);
                    if (returnValue) { break; }
            }

        }

        // We haven't found a match so either this is a non-transforming letter or a non-letter
        if (!returnValue)
        {
            _outputArray[_validCharacterPosition++]=char.IsLetter(_inputArray[_currentCharacterPosition])?_inputArray[_currentCharacterPosition]:' ';
            returnValue = true;

        }

        return returnValue;

    }
}
