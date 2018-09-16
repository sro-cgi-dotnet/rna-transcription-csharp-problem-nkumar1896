using System;
using System.Text;
namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //we can not make the changes in the original string that's why i created the new string
            //used stringbuilder because i will save the memory in the heap
        
            StringBuilder rna=new StringBuilder();
            foreach(char s  in nucleotide)
            {
                
                switch(s)
                {
                    case 'G': rna.Append("C");
                          break;
                    case 'C': rna.Append("G");
                          break;
                    case 'T': rna.Append("A");
                          break;
                    case 'A': rna.Append("U");
                          break;    
                    default:
                        throw new ArgumentException("char should be G,C,T,A");

                }
            }
            //need to use Tostring method to get string from stringbuilder
            return rna.ToString();
        }
    }
}
