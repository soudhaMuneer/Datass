var isPossible = function (a, b, c) { return (a + b === c) || (a + c
    === b) || (b + c === a); };
console.log(isPossible(2, 3, 5)); // true
console.log(isPossible(1, 2, 4)); // false
