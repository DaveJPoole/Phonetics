using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


public class GeneralPhonetics : BasePhonetics
{
    private char[] _TwoCharReplaceOne;
    private int _WordEndPosition = 0;

    public GeneralPhonetics(string inputString)
        : base(inputString)
    {

    }

   /// <summary>
    /// Works forward through the inputArray copying the valid encoded characters to the outputArray.
    /// This overridden method allows for the situation where the final character is a vowel and therefore 
    /// encoded as '0'.
    /// </summary>
    public override void Iterate()
    {
        base.Iterate();
    }


       /// <summary>
    /// Useful for itterating through the bog standard soundex where it is simply a character by character implementation
    /// </summary>
    /// <param name="validCharacterPosition">The last valid character position</param>
    /// <param name="currentCharacterPosition">The current itteration point in the input array</param>
    /// <param name="inputArray">The original string</param>
    public override void PhoneticAlgorithm()
    {

    }

    /// <summary>
    /// Specifies an array of characters each of which will be replaced by two characters if found in the inputArray
    /// and therefore should influence the outputArray
    /// </summary>
    public char[] TwoCharacterReplacements
    {
        set { _TwoCharReplaceOne = value; }
    }

    /// <summary>
    /// Iterates forward from the current string position until a letter is found.
    /// From that point the algorithm iterates forward until the next non-letter is detected and records the position of the last
    /// character of the word.  The algorithm will work where the end of the string is the last letter
    /// </summary>
    /// <returns>The character position of the last letter of the word from the starting position.</returns>
    public int FindWordEnd()
    {
        int x = _currentCharacterPosition;
        for (; +_currentCharacterPosition < _inputArray.Length; x++)
        {
            if (char.IsLetter(_inputArray[x]))
            {
                break;
            }
        }

        for (; _currentCharacterPosition < _inputArray.Length; x++)
        {
            if (!char.IsLetter(_inputArray[x]))
            {
                _WordEndPosition = x - 1;
                break;
            }
            if (_WordEndPosition <= 0)
            {
                _WordEndPosition = _inputArray.Length - 1;
            }
        }
        return _WordEndPosition;

    }
    /// <summary>
    /// Returns the character position of the end of the array.
    /// </summary>
    public int WordEndPosition
    {
        get
        {
            return _WordEndPosition;
        }
    }


    /// <summary>
    /// Counts the number of occurrences of characters that would be replaced by 2 characters.
    /// </summary>
    /// <returns>The number of additional characters to be added to the length of the inputArray.</returns>
    private int ExtraLength()
    {
        int AdditionalCharacters = 0;
        if (_TwoCharReplaceOne != null)
        {
            for (int x = 0; x < _inputArray.Length; x++)
            {
                for (int y = 0; y < _TwoCharReplaceOne.Length; y++)
                {
                    if (_inputArray[x] == _TwoCharReplaceOne[y])
                    {
                        AdditionalCharacters++;
                        break;
                    }
                }
            }
        }
        return AdditionalCharacters;
    }

    /// <summary>
    /// Works out the maximum possible length of the output array factoring in when input characters require more than one output character.
    /// </summary>
    public override void buildOutputArray()
    {
        _outputArray = new String(' ', _inputArray.Length + ExtraLength()).ToCharArray();
    }


    /// <summary>
    /// Determines if the array in the arrayToFind character array matches the inputArray character array
    /// starting at the character position indicated by the currentCharacterPosition variable.
    /// </summary>
    /// <param name="currentCharacterPosition">The starting position within the inputArray parameter from which arrayToFind will be evaluated</param>
    /// <param name="arrayToFind">The character array that will be matched from the currentCharacterPosition</param>
    /// <returns>A value indicating the number of characters in the arrayToFind that matched to the inputArray.
    /// Where the function returns zero it indicates that no match was found at the currentCharacterPosition</returns>
    public int ArrayMatchFromPosition(int currentCharacterPosition, char[] arrayToFind)
    {
        int x = 0;
        if (!(_inputArray == null || arrayToFind == null))
        {
            for (x = 0; x < arrayToFind.Length; x++)
            {
                if (currentCharacterPosition < 0 || (x + currentCharacterPosition >= _inputArray.Length) || (_inputArray[currentCharacterPosition + x] != arrayToFind[x]))
                {
                    break;
                }
            }

        }
        return x;
    }

    /// <summary>
    /// If the specified array to search for is found at the specified location then  the replacement array is written to the outputArray
    /// and the character position variables updated accordingly.
    /// </summary>
    /// <param name="arrayToFind">The character sequence that we search for at the currentCharacterPosition location.</param>
    /// <param name="arraytoReplace">The replacement character sequence that we search for at the validCharacterPosition</param>
    public bool ArrayReplaceFromPosition(
        char[] arrayToFind,
        char[] arraytoReplace)
    {
        bool returnValue = false;

        if (!(arrayToFind == null || arraytoReplace == null || _inputArray == null || _outputArray == null))
        {
            if (ArrayMatchFromPosition(_currentCharacterPosition, arrayToFind) == arrayToFind.Length && arrayToFind.Length > 0)
            {
                int x = 0;
                //The default Iterate method always adds one so we always add one less than the length of the 
                // array we are trying to find.
                _currentCharacterPosition += arrayToFind.Length-1; 
                for (x = 0; x < arraytoReplace.Length; x++)
                {
                    _outputArray[_validCharacterPosition + x] = arraytoReplace[x];
                }
                _validCharacterPosition += arraytoReplace.Length;
                returnValue = true;
            }
        }
        return returnValue;
    }
    /// <summary>
    /// The more complicated phonetic algorithms with their multi-letter substitutions make it difficult to detect double character occurences
    /// during the initial computation.  To attempt to do so would make the code verbose and hard to read.
    /// For this reason an end cleanup rountine is required.
    /// </summary>
    /// <remarks>The assumption is that all transformations performed on non-letters has resulted in a specific single character i.e. a space.</remarks>
    public void CleanOutputArray()
    {
        _currentCharacterPosition = 1;
        _validCharacterPosition=0;

        while(_currentCharacterPosition<_outputArray.Length){
            if(!(_outputArray[_currentCharacterPosition]==_outputArray[_validCharacterPosition])){
                _outputArray[++_validCharacterPosition] = _outputArray[_currentCharacterPosition];
            }
            _currentCharacterPosition++;
        }
        _validCharacterPosition++;

        // Once all the duplicate characters have been knocked out we need to make sure that
        //  the rest of the string contains nothing but spaces.
        while (_validCharacterPosition < _outputArray.Length)
        {
            _outputArray[_validCharacterPosition++] = ' ';
        }
        
    }

}

