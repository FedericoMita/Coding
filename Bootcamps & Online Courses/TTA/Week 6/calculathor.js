//Contemporary English to Shakespearean English translator found at https://lingojam.com/EnglishtoShakespearean
var firstValue = parseFloat(prompt("Writeth h're thy first numb'r, m'rtal"));//I used parseFloat as I believe it would filter out some typing mistakes (by giving NaN if what's typed is not a number)
var secondValue = parseFloat(prompt("And h're, prithee writeth thy second numb'r"));
var operator = prompt("Writeth one of these ancient runes: + - / * ^"); //I changed the subtraction symbol from the assignment to the one I have on my Italian keyboard, which is the same to an hyphen
function operation(firstValue, secondValue, operator){
    switch (operator) {
        case ('+'):
            return firstValue + secondValue;
        case ('-'):
            return firstValue - secondValue;
        case ('/'):
            return firstValue / secondValue;
        case ('*'):
            return firstValue * secondValue;
        case ('^'):
            return firstValue ^ secondValue;
        default:
            alert("Thee wroteth something inc'rrect, thee clotpole!");
            break;
    }
}
console.log(`Thee hath asked Thor to solveth ${firstValue} ${operator} ${secondValue} and the solution appears to beest equat'd to ${operation(firstValue, secondValue, operator)}`);