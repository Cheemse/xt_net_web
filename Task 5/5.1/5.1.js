'use strict';

let str = '';

let charsToDelete = [];

function splitter(str, separators) {
    let tempChar = separators[0];
    for (let i = 1; i < separators.length; i++) {
        str = str.split(separators[i]).join(tempChar);
    }
    str = str.split(tempChar);
    return str;
}

let wordsArr = splitter (str, ['?', '!', ':', ';', ',', '.', '\n', '\t', ' ']);

for (let i = 0; i < wordsArr.length; i++) { 
    for (let j = 0; j < wordsArr[i].length; j++) { 
        if (wordsArr[i].toLowerCase().includes(wordsArr[i][j], j + 1))
            charsToDelete.push(wordsArr[i][j]);
    }
}

for (let i = 0; i < charsToDelete.length; i++) {
    str = str.split(charsToDelete[i]).join("");
}

console.log(str);


