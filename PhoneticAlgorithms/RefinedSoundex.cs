using System;
using System.Collections.Generic;

using System.Text;




    public class RefinedSoundex:BaseSoundex{
        public  RefinedSoundex(string inputString):base(inputString){}
        protected override Char SoundexChar(Char a)
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
                case 'P':
                    a = '1';
                    break;
                case 'F':
                case 'V':
                    a = '2';
                    break;
                case 'C':
                case 'K':
                case 'S':
                    a = '3';
                    break;
                case 'G':
                case 'J':
                    a = '4';
                    break;
                case 'Q':
                case 'X':
                case 'Z':
                    a = '5';
                    break;
                case 'D':
                case 'T':
                    a = '6';
                    break;
                case 'L':
                    a = '7';
                    break;
                case 'N':
                case 'M':
                    a = '8';
                    break;
                case 'R':
                    a = '9';
                    break;
                default:
                    a = ' ';
                    break;
            }

            return a;
        }
    }

