using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string rna = "";
            foreach(char s  in nucleotide)
            {
                
                switch(s)
                {
                    case 'G': rna += "C";
                          break;
                    case 'C': rna += "G";
                          break;
                    case 'T': rna += "A";
                          break;
                    case 'A': rna += "U";
                          break;    
                    default:
                        throw new ArgumentException("char should be G,C,T,A");

                }
            }
            return rna;
        }
    }
}
