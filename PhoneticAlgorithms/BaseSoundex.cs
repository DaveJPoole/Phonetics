using System;
using System.Collections.Generic;
using System.Text;



public class BaseSoundex : BasePhonetics
{

    public BaseSoundex(string inputString): base(inputString){ }

    /// <summary>
    /// Works forward through the inputArray copying the valid encoded characters to the outputArray.
    /// This overridden method allows for the situation where the final character is a vowel and therefore 
    /// encoded as '0'.
    /// </summary>
    public override void Iterate()
    {
        base.Iterate();
        if (_validCharacterPosition < _outputArray.Length&&_outputArray[_validCharacterPosition] == '0')
        {
            _outputArray[_validCharacterPosition] = ' ';
        }
    }
    /// <summary>
    /// Useful for itterating through the bog standard soundex where it is simply a character by character implementation
    /// </summary>
    /// <param name="validCharacterPosition">The last valid character position</param>
    /// <param name="currentCharacterPosition">The current itteration point in the input array</param>
    /// <param name="inputArray">The original string</param>
    public  override void PhoneticAlgorithm()
    {
            if(IsStartOfWord())
                {
                    _outputArray[_validCharacterPosition++] = _inputArray[_currentCharacterPosition];
                }
            else
            {
                // If not a double occurrence of either characters or phonetic codes
                if (!(_validCharacterPosition==0 ||(_outputArray[_validCharacterPosition-1] == _inputArray[_currentCharacterPosition]) ||
                    _outputArray[_validCharacterPosition-1] == SoundexChar(_inputArray[_currentCharacterPosition])))
                {
                    _outputArray[_validCharacterPosition] = SoundexChar(_inputArray[_currentCharacterPosition]);
                    // Only increment the validCharacterPosition if it is not a vowel
                    if (_outputArray[_validCharacterPosition] != '0')
                    {
                        _validCharacterPosition++;
                    }
                }
            }
    }
    /// <summary>
    /// This function will be over-ridden in each class to provide the specific implementation required.
    /// </summary>
    protected virtual char SoundexChar(char a)
    {
        return a;
    }
 



}

