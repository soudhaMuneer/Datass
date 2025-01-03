function apple(a, b, c) {
    return (a + b === c) || (a + c === b) || (b + c === a);
}
console.log(apple(2, 3, 5)); // true
console.log(apple(1, 2, 4)); // false
