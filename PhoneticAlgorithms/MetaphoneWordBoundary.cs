public partial class Metaphone
{
    public override char[][][] WORDSTART
    {
        get { return _WORDSTART; }
    }
    public override char[][][] WORDEND
    {
        get { return _WORDEND; }
    }
    private readonly static char[][][] _WORDSTART = new char[][][]
    {
        new char[][]{
            new char[] { 'D', 'G','E' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'D', 'G','I' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'D', 'G','Y' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'C', 'I','A' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'S', 'C','H' },
            new char[] {'S', 'X'}
        },
        new char[][]{
            new char[] { 'S', 'I','A' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'S', 'I','O' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'C','H' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'I','A' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'I','O' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'A', 'E' },
            new char[] {'E'}
        },
        new char[][]{
            new char[] { 'C', 'E' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'C', 'H' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'C', 'I' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'C', 'K' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'C', 'Y' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'G', 'E' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'G', 'H' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'G', 'I' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'G', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'G', 'Y' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'K', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'P', 'H' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'P', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'S', 'H' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'H' },
            new char[] {'0'}
        },
        new char[][]{
            new char[] { 'W', 'R' },
            new char[] {'R'}
        },
        new char[][]{
            new char[] { 'W', 'H' },
            new char[] {'W'}
        },
        new char[][]{
            new char[] { 'Y', 'B' },
            new char[] {'B'}
        },
        new char[][]{
            new char[] { 'Y', 'C' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'D' },
            new char[] {'T'}
        },
        new char[][]{
            new char[] { 'Y', 'F' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'Y', 'G' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'H' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'Y', 'J' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'Y', 'K' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'L' },
            new char[] {'L'}
        },
        new char[][]{
            new char[] { 'Y', 'M' },
            new char[] {'M'}
        },
        new char[][]{
            new char[] { 'Y', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'Y', 'P' },
            new char[] {'P'}
        },
        new char[][]{
            new char[] { 'Y', 'Q' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'R' },
            new char[] {'R'}
        },
        new char[][]{
            new char[] { 'Y', 'S' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'Y', 'T' },
            new char[] {'T'}
        },
        new char[][]{
            new char[] { 'Y', 'V' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'Y', 'W' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'Y', 'X' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'Y', 'Z' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'C' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'D' },
            new char[] {'T'}
        },
        new char[][]{
            new char[] { 'G' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Q' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'V' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'X' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'Z' },
            new char[] {'S'}
        }

    };
    private readonly static char[][][] _WORDEND = new char[][][]
    {
        new char[][]{
            new char[] { 'G', 'N','E','D' },
            new char[] {'N','T'}
        },
        new char[][]{
            new char[] { 'D', 'G','E' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'D', 'G','I' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'D', 'G','Y' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'C', 'I','A' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'S', 'C','H' },
            new char[] {'S', 'X'}
        },
        new char[][]{
            new char[] { 'S', 'I','A' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'S', 'I','O' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'C','H' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'I','A' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'I','O' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'M', 'B' },
            new char[] {'M'}
        },
        new char[][]{
            new char[] { 'A', 'E' },
            new char[] {'E'}
        },
        new char[][]{
            new char[] { 'A', 'H' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'A', 'Y' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'C', 'E' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'C', 'H' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'C', 'I' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'C', 'K' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'C', 'Y' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'E', 'H' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'E', 'Y' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'G', 'E' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'G', 'H' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'G', 'I' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'G', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'G', 'Y' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'I', 'H' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'I', 'Y' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'O', 'H' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'O', 'Y' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'P', 'H' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'P', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'S', 'H' },
            new char[] {'X'}
        },
        new char[][]{
            new char[] { 'T', 'H' },
            new char[] {'0'}
        },
        new char[][]{
            new char[] { 'U', 'H' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'U', 'Y' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'W', 'H' },
            new char[] {'W'}
        },
        new char[][]{
            new char[] { 'Y', 'A' },
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'Y', 'B' },
            new char[] {'B'}
        },
        new char[][]{
            new char[] { 'Y', 'C' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'D' },
            new char[] {'T'}
        },
        new char[][]{
            new char[] { 'Y', 'E' },
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'Y', 'F' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'Y', 'G' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'I' },
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'Y', 'J' },
            new char[] {'J'}
        },
        new char[][]{
            new char[] { 'Y', 'K' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'L' },
            new char[] {'L'}
        },
        new char[][]{
            new char[] { 'Y', 'M' },
            new char[] {'M'}
        },
        new char[][]{
            new char[] { 'Y', 'N' },
            new char[] {'N'}
        },
        new char[][]{
            new char[] { 'Y', 'O' },
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'Y', 'P' },
            new char[] {'P'}
        },
        new char[][]{
            new char[] { 'Y', 'Q' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Y', 'R' },
            new char[] {'R'}
        },
        new char[][]{
            new char[] { 'Y', 'S' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'Y', 'T' },
            new char[] {'T'}
        },
        new char[][]{
            new char[] { 'Y', 'U' },
            new char[] {'Y'}
        },
        new char[][]{
            new char[] { 'Y', 'V' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'Y', 'X' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'Y', 'Z' },
            new char[] {'S'}
        },
        new char[][]{
            new char[] { 'C' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'D' },
            new char[] {'T'}
        },
        new char[][]{
            new char[] { 'G' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'Q' },
            new char[] {'K'}
        },
        new char[][]{
            new char[] { 'V' },
            new char[] {'F'}
        },
        new char[][]{
            new char[] { 'X' },
            new char[] {'K','S'}
        },
        new char[][]{
            new char[] { 'Y' },
            new char[] {' '}
        },
        new char[][]{
            new char[] { 'Z' },
            new char[] {'S'}
        }
    };
}
