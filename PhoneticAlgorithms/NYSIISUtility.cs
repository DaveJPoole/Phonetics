using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class NYSIISUtility
{
    public static char[][][] WORDSTART = new char[][][]
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

    public static char[][][] WORDMIDDLE = new char[][][]{
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
            new char[]{'E','H'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'I','H'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'O','H'},
            new char[]{'A'}
        },
        new char[][]{
            new char[]{'U','H'},
            new char[]{'A'}
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

    public static char[][][] WORDEND = new char[][][]{
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
            new char[] { 'A'},
            new char[] {' '}
        }

    };
}
