public partial class NYSIIS : GeneralPhonetics
{
 
    public NYSIIS(string inputString) : base(inputString) { }

    /// <summary>
    /// All phonetic algorithms have a set of actions that involve some combination of start of word, end of word, middle of word, after vowel,
    /// after non-vowel etc.  The specific combination is bespoke to each algorithm though the underlying methods are inherrited from the base class.
    /// </summary>
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

    /// <summary>
    /// All phonetic algorithms contain an Iterate function.  In the case of NYSIIS the processing of multiple letter combinations can lead
    /// to identical adjacent letters and thus a followup step is required to strip these out.
    /// </summary>
    public override void Iterate()
    {
        base.Iterate();
        base.CleanOutputArray();
    }

  }
