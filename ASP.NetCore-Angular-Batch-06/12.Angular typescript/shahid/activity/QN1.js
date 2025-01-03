"use strict";
const isPossible = (a, b, c) => (a + b === c) || (a + c === b) || (b + c == a);
console.log(isPossible(2, 3, 5));
