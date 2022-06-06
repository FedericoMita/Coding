var fruits = ["Apple", "Orange", "Banana", "Pear", "Peach", "Strawberry", "Cherry", "Acai"],
counts = {};//this sets up the char count at the end of the code (line 55). I found this only and it's the easiest I could comprehend enough to insert it in my code.
var vowels = "aeiouAEIOU"; //this is a code snippet I was able to find and tweak with successfully as to have the right article before each fruit
for ( var n = 0; n < fruits.length; n++ )
{
     var first = fruits[n][0];
     if ( vowels.indexOf(first) >= 0 )
         fruits[n] = "An " + fruits[n];
     else
         fruits[n] = "A " + fruits[n];
}
for (let fruit in fruits) {
    var vowels = 0;
    var consonants = 0;
    for (let i = 0; i < fruits[fruit].length; i++) {
            switch (fruits[fruit][i]) { //this will searching for any occurrence of the vowels, both upper and lower cases, and will give +1 to the variable vowels.
                case (fruit[i] = 'A'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'E'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'I'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'O'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'U'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'a'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'e'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'i'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'o'):
                    vowels += 1;
                    break;
                case (fruit[i] = 'u'):
                    vowels += 1;
                    break;
                default:
                    consonants += 1; //instead of doing separate cases for consonants, it's easier to just saying "anything that isn't above is a consonant"
                    break;
            }
        }
        //I tried using .toLowerCase but I was unable to find a working way (for me) to leave the first letter as upper case (even using .slice or .char).
        console.log(`${fruits[fruit]} has ${vowels} vowels and ${consonants} consonants`); //Writing just ${fruit} would print to the console just the corresponding index number.
}
fruits = fruits.join("").split(""); // transforms the initial array into array of single characters
fruits.sort();
fruits.forEach((v) => (counts[v] = (counts[v])? ++counts[v] : 1));
console.log(counts);