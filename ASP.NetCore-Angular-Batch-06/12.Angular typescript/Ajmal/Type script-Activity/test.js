var a = 11;
var b = 12;
var c = a * b;
console.log(c);
var isPossible = function (a, b, c) { return (a + b === c) || (a + c === b) || (b + c === a); };
console.log(isPossible(3, 2, 5)); // true
console.log(isPossible(1, 2, 4)); // false
var message = "Hello, TypeScript!";
console.log(message);
var checkIntegers = function (type, a, b, c, itsOk) {
    if (itsOk) {
        return b < c;
    }
    else {
        return b > a && c > b;
    }
};
console.log(checkIntegers("Enter value =", 1, 2, 3, true)); // true
console.log(checkIntegers(2, 1, 4, true)); // true
console.log(checkIntegers(1, 3, 2, false)); // false
