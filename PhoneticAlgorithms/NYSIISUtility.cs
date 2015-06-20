/// <summary>
/// The NYSIIS character substitutions are represented as 3 arrays.
/// 1.  WORDSTART
/// 2.  WORDMIDDLE
/// 3.  WORDEND
/// 
/// The intent is that these substitutions are data driven from a static class requiring no instantiation.
/// </summary>
public partial class NYSIIS
{
    public override char[][][] WORDSTART
    {
        get { return _WORDSTART; }
    }
    public override char[][][] WORDMIDDLE
    {
        get { return _WORDMIDDLE; }
    }
    public override char[][][] WORDEND
    {
        get { return _WORDEND; }
    }
    /// <summary>
    /// When used for SQLCLR functions static arrays have to be declared as readonly if the consuming code
    /// is to execute in SAFE mode.
    /// </summary>
    private readonly static char[][][] _WORDSTART = new char[][][]
    {
        new char[][]{
            new char[] { 'M', 'A', 'C' },
            new char[] {'M','C'}
        },
        new char[][]{
            new char[]{'K','N'},
            new char[]{'N'}
        },
        new char[][]{
            new char[]{'P','H'},
            new char[]{'F'}
        },
        new char[][]{
            new char[]{'P','F'},
            new char[]{'F'}
        },
        new char[][]{
            new char[]{'S','C','H'},
            new char[]{'S'}
        },
        new char[][]{
            new char[]{'K'},
            new char[]{'C'}
        }
    };

    private readonly static char[][][] _WORDMIDDLE = new char[][][]{
        new char[][]{
            new char[] { 'E', 'V'},
            new char[] {'A','F'}
        },
        new char[][]{
            new char[] { 'K', 'N'},
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'P', 'H'},
            new char[] {'F'}
        },
        new char[][]{
            new char[]{'S','C','H'},
            new char[]{'S'}
        },
        new char[][]{
            new char[]{'K'},
            new char[]{'C'}
        },
        new char[][]{
            new char[]{'Q','U'},
            new char[]{'G'}
        },
        new char[][]{
            new char[]{'Q'},
            new char[]{'G'}
        },
        new char[][]{
            new char[]{'Z'},
            new char[]{'S'}
        },
        new char[][]{
            new char[]{'M'},
            new char[]{'N'}
        },
        new char[][]{
            new char[]{'A','W'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'E','W'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'I','W'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'O','W'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'U','W'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'A','H'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'B','H'},
            new char[]{'B'}
        },
        new char[][]{
            new char[]{'C','H'},
            new char[]{'C'}
        },
        new char[][]{
            new char[]{'D','H'},
            new char[]{'D'}
        },
        new char[][]{
            new char[]{'F','H'},
            new char[]{'F'}
        },
        new char[][]{
            new char[]{'G','H'},
            new char[]{'G'}
        },
        new char[][]{
            new char[]{'H','H'},
            new char[]{'H'}
        },
        new char[][]{
            new char[]{'J','H'},
            new char[]{'J'}
        },
        new char[][]{
            new char[]{'K','H'},
            new char[]{'K'}
        },
        new char[][]{
            new char[]{'L','H'},
            new char[]{'L'}
        },
        new char[][]{
            new char[]{'M','H'},
            new char[]{'M'}
        },
        new char[][]{
            new char[]{'N','H'},
            new char[]{'N'}
        },
        new char[][]{
            new char[]{'P','H'},
            new char[]{'P'}
        },
        new char[][]{
            new char[]{'Q','H'},
            new char[]{'Q'}
        },
        new char[][]{
            new char[]{'R','H'},
            new char[]{'R'}
        },
        new char[][]{
            new char[]{'S','H'},
            new char[]{'S'}
        },
        new char[][]{
            new char[]{'T','H'},
            new char[]{'T'}
        },
        new char[][]{
            new char[]{'V','H'},
            new char[]{'V'}
        },
        new char[][]{
            new char[]{'W','H'},
            new char[]{'W'}
        },
        new char[][]{
            new char[]{'X','H'},
            new char[]{'X'}
        },
        new char[][]{
            new char[]{'Y','H'},
            new char[]{'Y'}
        },
        new char[][]{
            new char[]{'Z','H'},
            new char[]{'Z'}
        },
        new char[][]{
            new char[]{'H','B'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','C'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','D'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','F'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','G'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','H'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','J'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','K'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','L'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','M'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','N'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','P'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','Q'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','R'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','S'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','T'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','V'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','W'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','X'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','Y'},
            new char[]{}
        },
        new char[][]{
            new char[]{'H','Z'},
            new char[]{}
        },
        new char[][]{
            new char[]{'E'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'I'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'O'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'U'},
            new char[]{'A'}
        }
    };

    private readonly static char[][][] _WORDEND = new char[][][]{
        new char[][]{
            new char[] { 'E', 'E'},
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'I', 'E'},
            new char[] {'Y'}
        },

        // The transforms of "AY" suggest that all [vowel]Y combinations should have the same effect
        new char[][]{
            new char[] { 'A', 'Y'},
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'E', 'Y'},
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'I', 'Y'},
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'O', 'Y'},
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'U', 'Y'},
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'D', 'T'},
            new char[] {'D'}
        },
        new char[][]{
            new char[] { 'R', 'T'},
            new char[] {'D'}
        },
        new char[][]{
            new char[] { 'R', 'D'},
            new char[] {'D'}
        },
        new char[][]{
            new char[] { 'N', 'T'},
            new char[] {'D'}
        },
        new char[][]{
            new char[] { 'N', 'D'},
            new char[] {'D'}
        },
        new char[][]{
            new char[] { 'A','S'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'E','S'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'I','S'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'O','S'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'U','S'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'A','Z'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'E','Z'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'I','Z'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'O','Z'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'U','Z'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'A'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'E'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'I'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'O'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'U'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'S'},
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'Z'},
            new char[] {' '}
        }

    };
}
