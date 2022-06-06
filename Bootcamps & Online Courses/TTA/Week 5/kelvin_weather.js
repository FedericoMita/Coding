const kelvin = 293; //as requested from the exercise, I used the "const" variable, to make "kelvin" a constant
console.log('Kelvin: ' + kelvin); //I want to show every temperature I'm working with, so I'll use "console.log" for each of them
const celsius = kelvin - 273; //this is the same temperature, but converted in Celsius and associated to a new constant
console.log('Celsius:' + '\xa0' + celsius); //just to show variety, I used "\xa0" to add an extra non-breaking space, instead of just putting a space before the closing single quotes as I did above
let fahrenheit = celsius * (9/5) + 32; //fahrenheit is a a "let" variable because we'll need to be able to reassign the value, as per exercise. The equation converts Celsius to Fahrenheit
fahrenheit = Math.floor(fahrenheit); //the ".floor()" method should round up the number
console.log(`The temperature is ${fahrenheit} degrees Fahrenheit.`); //as I used string interpolation above, in here I used a tagged template...I had to research how to type a backtick in an Italian keyboard, as there isn't a key for it! It's Alt+096