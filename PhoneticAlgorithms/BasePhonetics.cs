using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


/// <summary>
/// Regardless of the phonetic algorithm used certain aspects are common across all algorithms.
/// </summary>
public class BasePhonetics : IDisposable
{
    public char[] _inputArray;
    public char[] _outputArray;
    public int _currentCharacterPosition = 0;
    public int _validCharacterPosition = 0;
    private bool _isCaseSensitive = false;


    /// <summary>
    /// The Caverphone phonetic algorithm is case sensitive but Soundex, NYSIIS, Daitch Mokotoff are not therefore a constructor
    /// is needed to enable case sensitivity to be indicated.
    /// </summary>
    /// <param name="inputString">The string for which we want a phonetic encoding</param>
    /// <param name="isCaseSentitive">Flag to indicate whether the input string should be changed to upper case prior 
    /// to computation thereby making the algorithm case insensitive.</param>
    public BasePhonetics(SqlString inputString, bool isCaseSentitive)
    {
        _isCaseSensitive = isCaseSentitive;
        _currentCharacterPosition = 0;
        _validCharacterPosition = 0;
        if (inputString=="" ||inputString.IsNull)
        {
            inputString = " ";
        }
        if (_isCaseSensitive)
        {
            _inputArray = inputString.ToString().ToCharArray();
        }
        else
        {
            _inputArray = inputString.ToString().ToUpper().ToCharArray();
        }
        

    }
    /// <summary>
    /// Regardless of the phonetic algorithm used certain aspects are common across all algorithms.
    /// </summary>
    /// <param name="inputString">The string for which we want a phonetic encoding.</param>
    public BasePhonetics(SqlString inputString):this(inputString,false)
    {
    }

    /// <summary>
    /// The outputArray is generally the same length as the inputArray however for certain algorithmns some characters
    /// such as C, J and X can be replaced by more than one character.  In such a situation the outputArray can actually be loner than the input.
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
    public virtual void buildOutputArray()
    {
        _outputArray = new String(' ', _inputArray.Length).ToCharArray();
    }
    /// <summary>
    /// The premise is that all phonetic algorithms require a crawler to work its way forward through the input string.
    /// All character transformations are performed relative to the current position regardless of whether they are single
    /// or multiple character transformations.
    /// </summary>
    public virtual void Iterate()
    {
        buildOutputArray();
        while (_currentCharacterPosition < _inputArray.Length)
        {
            PhoneticAlgorithm();

            _currentCharacterPosition++;
        }


    }
    /// <summary>
    /// This function will be over-ridden in each class to provide the specific implementation required.
    /// </summary>
    public virtual void PhoneticAlgorithm()
    {
        _outputArray[_validCharacterPosition++] = _inputArray[_currentCharacterPosition];
    }

    /// <summary>
    /// Returns the result of the phonetic algorithm
    /// </summary>
    /// <returns></returns>
    public string ReadOutput()
    {
        return new string(_outputArray).Trim();
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

    /// <summary>
    /// Detects an occurrence of a letter either following a non-letter or in the first position in a string and deems this to be the start of a word.
    /// </summary>
    /// <remarks>This function will be constrained by the ability of char.IsLetter to detect the occurrence of a letter.</remarks>
    /// <returns>TRUE = Start of Word.</returns>
    public bool IsStartOfWord()
    {
        bool returnValue = false;
        if (_validCharacterPosition == 0 || _outputArray[_validCharacterPosition - 1] == ' ')
        {
            if (char.IsLetter(_inputArray[_currentCharacterPosition]))
                returnValue= true;
        }
        return returnValue;
    }

    /// <summary>
    /// Mandataory for an iDisposable interface.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    /// <summary>
    /// Releases the arrays.  This may be overkill depending on the garbage collector.
    /// </summary>
    /// <remarks>In general disposing of managed resources is unnecessary however the size of the arrays could
    /// be quite large so having an explicit cleardown may be beneficial.</remarks>
    /// <param name="disposing">Flag to indicate whether or not Dispose should remove resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            Array.Clear(_inputArray, 0, _inputArray.Length);
            Array.Clear(_outputArray, 0, _inputArray.Length);
        }

    }
}