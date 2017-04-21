using System;
using System.Collections.Generic;
using System.Text;

public partial class Metaphone : GeneralPhonetics
{
    public Metaphone(string inputString) : base(inputString)
    {
        TwoCharacterReplacements = new char[] { 'X' };
    }

    public override void Iterate()
    {
        base.Iterate();
    }
    /// <summary>
    /// The specific implementation of the PhoneticAlgorithm method to run the Metaphone encoding.
    /// </summary>
    public override void PhoneticAlgorithm()
    {
        bool stopProccessingFlag = false;
        if (IsStartOfWord())
        {
            if (!(ProcessWordStart()))
            {
                _outputArray[_validCharacterPosition++] = _inputArray[_currentCharacterPosition];
            }

        }
        //else
        //{
        //    if (_currentCharacterPosition > 0 && char.IsLetter(_inputArray[_currentCharacterPosition - 1]))
        //    {
        //        if (isVowel(_inputArray[_currentCharacterPosition - 1]))
        //        {
        //            stopProccessingFlag = ProcessWordAfterVowel();
        //        }
        //        else
        //        {
        //            stopProccessingFlag = ProcessWordAfterNonVowel();
        //        }

        //        if (!stopProccessingFlag && !char.IsLetter(_inputArray[_currentCharacterPosition]) && _validCharacterPosition > 0 && _outputArray[_validCharacterPosition - 1] != ' ')
        //        {
        //            _outputArray[_validCharacterPosition++] = ' ';
        //        }

        //    }
        //}

    }


}
