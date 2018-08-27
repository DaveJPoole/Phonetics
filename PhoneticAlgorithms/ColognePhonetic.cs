public partial class ColognePhonetic : GeneralPhonetics
{
 
    public ColognePhonetic(string inputString) : base(inputString) {
        TwoCharacterReplacements = new char[] { 'X' };
    }

    /// <summary>
    /// All phonetic algorithms have a set of actions that involve some combination of start of word, end of word, middle of word, after vowel,
    /// after non-vowel etc.  The specific combination is bespoke to each algorithm though the underlying methods are inherrited from the base class.
    /// </summary>
    public override void PhoneticAlgorithm()
    {
        GetWordEnd(_currentCharacterPosition);
        if (!ProcessWordMiddle())
        {
                _outputArray[_validCharacterPosition++] = _inputArray[_currentCharacterPosition];
        }
    }

    /// <summary>
    /// All phonetic algorithms contain an Iterate function.  
    /// </summary>
    public override void Iterate()
    {
        base.Iterate();
        base.StripCharacterFromOutputArray('-',0);
        base.CleanOutputArray();
        base.StripCharacterFromOutputArray('0');
    }

}
