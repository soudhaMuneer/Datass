const checkIntegers = (a: number, b: number, c: number, itsOk: boolean): boolean => {
    if (itsOk) {
    return b < c;
    } else {
    return b > a && c > b;
    }
    }
    
    console.log(checkIntegers(1, 2, 4, false)); // true
    console.log(checkIntegers(2, 1, 4, true)); // true
    console.log(checkIntegers(1, 3, 2, false)); // false