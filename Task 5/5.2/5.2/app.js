'use strict';

let str = '3.5 + 4 * 10 - 5.3 / 5 =';

function getNumbers(str) {
    let regNums = /[\-\+\/\*=]/;

    return str.split(regNums).filter(Boolean);
}

function getOperators(str) {
    let regOperators = /[\d\.=\s]+/;

    return str.split(regOperators).filter(Boolean);
}

let numbers = getNumbers(str);
let operators = getOperators(str);

let j = 0;
let result = parseFloat(numbers[0]);
for (let i = 1; i < numbers.length; i++) {
    let curNum = parseFloat(numbers[i]);
    switch (operators[j++]) {
        case '+':
            result += curNum;
            break;
        case '-':
            result -= curNum;
            break;
        case '/':
            result /= curNum;
            break;
        case '*':
            result *= curNum;
            break;
        default:
            break;
    }
}

console.log(str);
console.log(numbers);
console.log(operators);
console.log(result.toFixed(2));