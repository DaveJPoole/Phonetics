using System;
using System.Collections.Generic;
using System.Text;


    public class Soundex:BaseSoundex
    {
        public Soundex(string inputString) : base(inputString) { }

        /// <summary>
        /// For a given character return the raw SOUNDEX value.  If the argument is not a letter then return a space.
        /// </summary>
        /// <param name="a">The character to be evalutated.</param>
        /// <returns></returns>
        protected override  Char SoundexChar(Char a)
        {

            switch (a)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'W':
                case 'H':
                case 'Y':
                    a = '0';
                    break;
                case 'B':
                case 'F':
                case 'P':
                case 'V':
                    a = '1';
                    break;
                case 'C':
                case 'G':
                case 'J':
                case 'K':
                case 'Q':
                case 'S':
                case 'X':
                case 'Z':
                    a = '2';
                    break;
                case 'D':
                case 'T':
                    a = '3';
                    break;
                case 'L':
                    a = '4';
                    break;
                case 'N':
                case 'M':
                    a = '5';
                    break;
                case 'R':
                    a = '6';
                    break;
                default:
                    a = ' ';
                    break;
            }

            return a;
        }
    }

