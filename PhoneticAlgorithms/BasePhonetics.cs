using System;
using System.Collections.Generic;
using System.Text;


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
    public BasePhonetics(string inputString, bool isCaseSentitive)
    {
        _isCaseSensitive = isCaseSentitive;
        _currentCharacterPosition = 0;
        _validCharacterPosition = 0;
        if (String.IsNullOrEmpty(inputString))
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
    public BasePhonetics(string inputString):this(inputString,false)
    {
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
            if (_outputArray != null)
            {
                Array.Clear(_outputArray, 0, _outputArray.Length);
            }
        }

    }
}