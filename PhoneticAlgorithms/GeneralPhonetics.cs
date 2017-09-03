using System;
using System.Collections.Generic;
using System.Text;

public class GeneralPhonetics : BasePhonetics
{
    #region Character substitution arrays that will be replaced in the inherriting class.

    /// <summary>
    /// The use of a virtual property allows the implementation of the algorithm to use the property to be implemented in the base class
    /// but caters for the need for the algorithm specific values of WORDSTART to be specified in the inheriting class.
    /// </summary>
    public virtual char[][][] WORDSTART
    {
        get { return _WORDSTART; }
    }
    private readonly
       static char[][][] _WORDSTART = new char[][][]
    {
        new char[][]{
            new char[] {},
            new char[] {}
        }
    };
    /// <summary>
    /// The use of a virtual property allows the implementation of the algorithm to use the property to be implemented in the base class
    /// but caters for the need for the algorithm specific values of WORDEND to be specified in the inheriting class.
    /// </summary>
    public virtual char[][][] WORDEND
    {
        get { return _WORDEND; }
    }
    private readonly
       static char[][][] _WORDEND = new char[][][]
    {
        new char[][]{
            new char[] {},
            new char[] {}
        }
    };
    /// <summary>
    /// The use of a virtual property allows the implementation of the algorithm to use the property to be implemented in the base class
    /// but caters for the need for the algorithm specific values of WORDMIDDLE to be specified in the inheriting class.
    /// </summary>
    public virtual char[][][] WORDMIDDLE
    {
        get { return _WORDMIDDLE; }
    }
    private readonly
       static char[][][] _WORDMIDDLE = new char[][][]
    {
        new char[][]{
            new char[] {},
            new char[] {}
        }
    };

    /// <summary>
    /// The use of a virtual property allows the implementation of the algorithm to use the property to be implemented in the base class
    /// but caters for the need for the algorithm specific values of AFTERVOWEL to be specified in the inheriting class.
    /// </summary>
    public virtual char[][][] AFTERVOWEL
    {
        get { return _AFTERVOWEL; }
    }
    private
       readonly static char[][][] _AFTERVOWEL = new char[][][]
    {
        new char[][]{
            new char[] {},
            new char[] {}
        }
    };

    /// <summary>
    /// The use of a virtual property allows the implementation of the algorithm to use the property to be implemented in the base class
    /// but caters for the need for the algorithm specific values of AFTERNONVOWEL to be specified in the inheriting class.
    /// </summary>
    public virtual char[][][] AFTERNONVOWEL
    {
        get { return _AFTERNONVOWEL; }
    }
    private readonly
       static char[][][] _AFTERNONVOWEL = new char[][][]
    {
        new char[][]{
            new char[] {},
            new char[] {}
        }
    };

    #endregion

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
    /// For the non-soundex algorithms knowing the end of the word allows an small optimisation to short-circuit the evaluation of
    /// substitution n-grams.
    /// 1.  At the end of the word only evalute those substitutions that are exactly the length of the number of remaining letters
    /// 2.  For other substitutions only evaluate those substitutions whose length is not greater in length than the number of remaining letters.
    /// </summary>
    /// <returns>True if this is the start of a word.</returns>
    public override bool IsStartOfWord()
    {
        bool returnValue = base.IsStartOfWord();
        if (returnValue) { GetWordEnd(_currentCharacterPosition); }
        return returnValue;
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
    /// <param name="currentCharacterPosition">The starting position within the inputArray parameter from which the end of word will be calculated.</param>
    /// <returns>The character position of the last letter of the word from the starting position.</returns>
    public void GetWordEnd(int currentCharacterPosition)
    {
        int x = currentCharacterPosition < 0 ? 0 : currentCharacterPosition;

        if (x >= _inputArray.Length) { x = _inputArray.Length; }

        // Scan forward until you run until you hit a non-letter indicating end-of-word
        // or hit the end of the array
        for (; x < _inputArray.Length; x++)
        {
            if (!char.IsLetter(_inputArray[x]))
            {
                break;
            }
        }

        if (x == _inputArray.Length) { x--; }

        //Scan backwards until you hit a letter as this will be the end of the word.
        for (; x > 0; x--)
        {
            if (char.IsLetter(_inputArray[x]))
            {
                _WordEndPosition = x;
                break;
            }
        }
    }

    /// <summary>
    /// Returns the character position of the current word.
    /// </summary>
    /// <remarks>Where the supplied position is negative then the start of the array will be assumed.<br />
    /// Where the supplied position is at the end of the array then the last position in the array will be assumed.</remarks>
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
    /// The outputArray is generally the same length as the inputArray however for certain algorithmns some characters
    /// such as C, J and X can be replaced by more than one character.  In such a situation the outputArray can actually be lower than the input.
    /// </summary>
    /// <remarks>It is highly unlikely (but not impossible) that the outputArray will be longer than the inputArray</remarks>
    /// <returns>An integer value containing the length of the outputArray.</returns>
    public int GetOutputLength()
    {
        return _outputArray.Length;
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
                _currentCharacterPosition += arrayToFind.Length - 1;
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
        _validCharacterPosition = 0;

        while (_currentCharacterPosition < _outputArray.Length)
        {
            if (!(_outputArray[_currentCharacterPosition] == _outputArray[_validCharacterPosition]))
            {
                _outputArray[++_validCharacterPosition] = _outputArray[_currentCharacterPosition];
            }
            _currentCharacterPosition++;
        }

        CleanToEndOfOutputArray(_validCharacterPosition);

    }

    private void CleanToEndOfOutputArray(int _validCharacterPosition)
    {
        // Once all the duplicate characters have been knocked out we need to make sure that
        //  the rest of the string contains nothing but spaces.
        _validCharacterPosition++;
        while (_validCharacterPosition < _outputArray.Length)
        {
            _outputArray[_validCharacterPosition++] = ' ';
        }
    }

    /// <summary>
    /// Algorithms such as Metaphone have complex logic regarding the position of letters in relation to vowels.  This means
    /// that the early erasure of vowels can have undesirable consequences hence the need to have a post-processing cleanse.
    /// </summary>
    public void StripVowelsFromOutputArray()
    {
        _currentCharacterPosition = 1;
        _validCharacterPosition = 0;

        while (_currentCharacterPosition < _outputArray.Length)
        {
            if (!isVowel(_outputArray[_currentCharacterPosition]))
            {
                _outputArray[++_validCharacterPosition] = _outputArray[_currentCharacterPosition];
            }
            _currentCharacterPosition++;
        }
        CleanToEndOfOutputArray(_validCharacterPosition);
    }

    /// <summary>
    /// The actions necessary to carry out character substitutions is common across most transformations.
    /// The bit that varies is the array containing the character patterns and their appropriate replacement.
    /// </summary>
    /// <remarks>There is a small optimisation that detects whether the array to find is longer than the number of remaining
    /// letters in the current word.  If so then there is no point carrying out the more detailed evaluation.</remarks>
    /// <param name="pairSubsitution">The char[][][] array containing the character substitutions</param>
    /// <returns>True if a replacement has been made successfully</returns>
    public bool ProcessWordPart(char[][][] pairSubsitution)
    {
        bool returnValue = false;
        for (int i = 0; i < pairSubsitution.Length; i++)
        {
            if (pairSubsitution[i][0].Length <= 1 + WordEndPosition - _currentCharacterPosition)
            {
                if (ArrayMatchFromPosition(_currentCharacterPosition, pairSubsitution[i][0]) == pairSubsitution[i][0].Length)
                {
                    returnValue = ArrayReplaceFromPosition(pairSubsitution[i][0], pairSubsitution[i][1]);
                    if (returnValue) { break; }
                }
            }
        }
        return returnValue;

    }


    /// <summary>
    /// Carries out any character substitutions necessary at the start of a word.  Where a valid substitution is not detected
    /// the responsibility for handling the character is handled by the calling method.
    /// </summary>
    /// <returns>TRUE = The word start substitution algorithm successfully identified and replaced an 'n' character word start.</returns>
    public bool ProcessWordStart()
    {
        return ProcessWordPart(WORDSTART);

    }


    ///// <summary>
    /// Detects whether or not a substitution can be made at the end of the word.
    /// </summary>
    /// <remarks>A minor optimimisation is to detect whether the length of the substitution would go beyond the end of
    /// a word and therefore do not bother with the full evaluation.</remarks>
    /// <returns>TRUE = An 'n' character substitution was achieved at the end of a word.</returns>
    public bool ProcessWordEnd()
    {
        bool returnValue = false;
        for (int i = 0; i < WORDEND.Length; i++)
        {
            if (WORDEND[i][0].Length == 1 + _WordEndPosition - _currentCharacterPosition)
            {
                if (ArrayMatchFromPosition(_currentCharacterPosition, WORDEND[i][0]) == WORDEND[i][0].Length)
                {
                    if ((WORDEND[i][0].Length + _currentCharacterPosition == _inputArray.Length)
                        || (!char.IsLetter(_inputArray[_currentCharacterPosition + WORDEND[i][0].Length])))
                    {
                        returnValue = ArrayReplaceFromPosition(WORDEND[i][0], WORDEND[i][1]);
                        if (returnValue) { break; }
                    }
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
    public bool ProcessWordMiddle()
    {
        bool returnValue = false;
        returnValue = ProcessWordPart(WORDMIDDLE);

        // We haven't found a match so either this is a non-transforming letter or a non-letter
        if (!returnValue)
        {
            _outputArray[_validCharacterPosition++] = char.IsLetter(_inputArray[_currentCharacterPosition]) ? _inputArray[_currentCharacterPosition] : ' ';
            returnValue = true;
        }

        return returnValue;

    }

    /// <summary>
    /// Carries out any character substitution necessary where a valid letter that is a non-vowel is detected as the preceding character.
    /// </summary>
    /// <returns></returns>
    public bool ProcessWordAfterNonVowel()
    {
        return ProcessWordPart(AFTERNONVOWEL);
    }

    /// <summary>
    /// Carries out any character substitution necessary where a vowel is detected as the preceding character.
    /// </summary>
    /// <returns>TRUE = The after vowel substitution algorithm successfully identified and replaced an 'n' character word </returns>
    public bool ProcessWordAfterVowel()
    {
        return ProcessWordPart(AFTERVOWEL);
    }
    /// <summary>
    /// Simply identifies whether a letter is one of the five standard vowels.
    /// </summary>
    /// <param name="a">The char value</param>
    /// <returns>TRUE = a vowel has been identified, FALSE = It isn't a standard vowel.</returns>
    public static bool isVowel(char a)
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

