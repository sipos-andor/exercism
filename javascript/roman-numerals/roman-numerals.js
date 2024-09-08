//
// This is only a SKELETON file for the 'Roman Numerals' exercise. It's been provided as a
// convenience to get you started writing code faster.
//
export const toRoman = (number) => {
  const DIGITS = [
    [1000, 'M'], [900, 'CM'], [500, 'D'], [400, 'CD'], [100, 'C'], [90, 'XC'],
    [50, 'L'], [40, 'XL'], [10, 'X'], [9, 'IX'], [5, 'V'], [4, 'IV'], [1, 'I']
  ];
  let romanNumber = '';

  DIGITS.forEach(function extract(digit) {
    var value = digit[0], roman = digit[1];
    while (number >= value) {
      romanNumber += roman;
      number -= value;
    }
  });
  return romanNumber;
};
