//
// This is only a SKELETON file for the 'Protein Translation' exercise. It's been provided as a
// convenience to get you started writing code faster.

import { error } from "console";

//
const CODONS = (() => {
  let AUG, UUU, UUC, UUA, UUG, UCU, UCC, UCA, UCG, UAU, UAC, UGU, UGC, UGG, UAA, UAG, UGA
  AUG = 'Methionine'
  UUU = UUC = 'Phenylalanine'
  UUA = UUG = 'Leucine'
  UCU = UCC = UCA = UCG = 'Serine'
  UAU = UAC = 'Tyrosine'
  UGU = UGC = 'Cysteine'
  UGG = 'Tryptophan'
  UAA = UAG = UGA = 'STOP'
  return { AUG, UUU, UUC, UUA, UUG, UCU, UCC, UCA, UCG, UAU, UAC, UGU, UGC, UGG, UAA, UAG, UGA }
})();

export const translate = (rna = "") =>
  (rna.match(/.{1,3}/g) || []).reduce((arr, codon) => {
    if (!CODONS[codon])
      throw new Error('Invalid codon');
    return arr.includes('STOP') ? arr : [...arr, CODONS[codon]];
  }, [])
    .filter(codon => codon !== 'STOP');