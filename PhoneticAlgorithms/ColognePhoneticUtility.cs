/// <summary>
/// The NYSIIS character substitutions are represented as 3 arrays.
/// 1.  WORDSTART
/// 2.  WORDMIDDLE
/// 3.  WORDEND
/// 
/// The intent is that these substitutions are data driven from a static class requiring no instantiation.
/// </summary>
public partial class ColognePhonetic
{
    public override char[][][] WORDMIDDLE
    {
        get { return _WORDMIDDLE; }
    }
    /// <summary>
    /// When used for SQLCLR functions static arrays have to be declared as readonly if the consuming code
    /// is to execute in SAFE mode.
    /// </summary>

    private readonly static char[][][] _WORDMIDDLE = new char[][][]{
        new char[][]{
            new char[] { 'C','A'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'C','H'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'C','K'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'C','O'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'C','Q'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'C','R'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'C','U'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'C','X'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'D','C'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'D','S'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'D','Z'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'P','H'},
            new char[] {'3'}
        },
        new char[][]{
            new char[] { 'S','C'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'T','C'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'T','S'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'T','Z'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'Z','C'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'A'},
            new char[] {'0'}
        },
        new char[][]{
            new char[] {'B'},
            new char[] {'1'}
        },
        new char[][]{
            new char[] {'C'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] { 'D'},
            new char[] {'2'}
        },
        new char[][]{
            new char[] { 'E'},
            new char[] {'0'}
        },
        new char[][]{
            new char[] { 'F'},
            new char[] {'3'}
        },
        new char[][]{
            new char[] {'G'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] {'H'},
            new char[] {'-'}
        },
        new char[][]{
            new char[] { 'I'},
            new char[] {'0'}
        },
        new char[][]{
            new char[] { 'J'},
            new char[] {'0'}
        },
        new char[][]{
            new char[] {'K'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] {'L'},
            new char[] {'5'}
        },
        new char[][]{
            new char[] { 'M'},
            new char[] {'6'}
        },
        new char[][]{
            new char[] { 'N'},
            new char[] {'6'}
        },
        new char[][]{
            new char[] { 'O'},
            new char[] {'0'}
        },
        new char[][]{
            new char[] { 'P'},
            new char[] {'1'}
        },
        new char[][]{
            new char[] { 'Q'},
            new char[] {'4'}
        },
        new char[][]{
            new char[] { 'R'},
            new char[] {'7'}
        },
        new char[][]{
            new char[] {'S'},
            new char[] {'8'}
        },
        new char[][]{
            new char[] {'T'},
            new char[] {'2'}
        },
        new char[][]{
            new char[] {'U'},
            new char[] {'0'}
        },
        new char[][]{
            new char[] {'V'},
            new char[] {'3'}
        },
        new char[][]{
            new char[] {'W'},
            new char[] {'3'}
        },
        new char[][]{
            new char[] { 'X'},
            new char[] {'4','8'}
        },
        new char[][]{
            new char[] { 'Y'},
            new char[] {'0'}
        },
                new char[][]{
            new char[] { 'Z'},
            new char[] {'8'}
        }


    };

}
