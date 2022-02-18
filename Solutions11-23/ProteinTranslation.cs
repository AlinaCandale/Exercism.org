using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions11_23
{
    static class ProteinTranslation
    {
        public static string[] Proteins(string strand)
        {
            IEnumerable<string> codons = Enumerable.Range(0, strand.Length / 3)
                .Select(i => strand.Substring(i * 3, 3));
            List<string> protein = new List<string>();
            foreach (string c in codons)
            {
                switch (c)
                {
                    case "AUG":
                        protein.Add("Methionine");
                        break;
                    case "UUU":
                        protein.Add("Phenylalanine");
                        break;
                    case "UUC":
                        protein.Add("Phenylalanine");
                        break;
                    case "UUA":
                        protein.Add("Leucine");
                        break;
                    case "UUG":
                        protein.Add("Leucine");
                        break;
                    case "UCU":
                        protein.Add("Serine");
                        break;
                    case "UCC":
                        protein.Add("Serine");
                        break;
                    case "UCA":
                        protein.Add("Serine");
                        break;
                    case "UCG":
                        protein.Add("Serine");
                        break;
                    case "UAU":
                        protein.Add("Tyrosine");
                        break;
                    case "UAC":
                        protein.Add("Tyrosine");
                        break;
                    case "UGU":
                        protein.Add("Cysteine");
                        break;
                    case "UGC":
                        protein.Add("Cysteine");
                        break;
                    case "UGG":
                        protein.Add("Tryptophan");
                        break;
                    case "UAA":
                        return protein.ToArray();
                    case "UAG":
                        return protein.ToArray();
                    case "UGA":
                        return protein.ToArray();
                    default:
                        break;
                }
            }
            return protein.ToArray();
        }
    }
}

/*
 * Instructions
Translate RNA sequences into proteins.

RNA can be broken into three nucleotide sequences called codons, and then translated to a polypeptide like so:

RNA: "AUGUUUUCU" => translates to

Codons: "AUG", "UUU", "UCU" => which become a polypeptide with the following sequence =>

Protein: "Methionine", "Phenylalanine", "Serine"

There are 64 codons which in turn correspond to 20 amino acids; however, all of the codon sequences and resulting amino acids are not important in this exercise. If it works for one codon, the program should work for all of them. However, feel free to expand the list in the test suite to include them all.

There are also three terminating codons (also known as 'STOP' codons); if any of these codons are encountered (by the ribosome), all translation ends and the protein is terminated.

All subsequent codons after are ignored, like this:

RNA: "AUGUUUUCUUAAAUG" =>

Codons: "AUG", "UUU", "UCU", "UAA", "AUG" =>

Protein: "Methionine", "Phenylalanine", "Serine"

Note the stop codon "UAA" terminates the translation and the final methionine is not translated into the protein sequence.

Below are the codons and resulting Amino Acids needed for the exercise.

Codon	Protein
AUG	Methionine
UUU, UUC	Phenylalanine
UUA, UUG	Leucine
UCU, UCC, UCA, UCG	Serine
UAU, UAC	Tyrosine
UGU, UGC	Cysteine
UGG	Tryptophan
UAA, UAG, UGA	STOP
*/
