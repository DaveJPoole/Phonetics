using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Metaphone
{
    public override char[][][] WORDSTART
    {
        get { return _WORDSTART; }
    }
    private readonly static char[][][] _WORDSTART = new char[][][]
    {
        new char[][]{
            new char[] { 'K', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'P', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'A', 'E' },
            new char[] {'E'}
        },
        new char[][]{
            new char[] { 'G', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'W', 'R' },
            new char[] {'R'}
        },
        new char[][]{
            new char[] { 'X' },
            new char[] {'S'}
        }

    };

}
