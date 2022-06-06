const userName = ''; //put your name here
userName ? console.log(`Hello ${userName} !`) : console.log('Hello!'); //ternary operator, which is a shortened if...else statement
const userQuestion = ''; //type your question here, to be processed by the Magic Eight Ball program; I'm using "const" for these but I don't see any difference in using other variable types
userName ? console.log(`${userName} asked ${userQuestion}`) : console.log(`${userQuestion}`); //another ternary operator, depending on userName
let randomNumber = Math.floor(Math.random() * 8); //methods to generate one out of 8 possible numbers, 0-7
let eightBall = ''; //empty because we are going to generate the value below
switch (randomNumber) { //switch operator, more streamlined than if...else if...else
    case 0: 
      eightBall = 'It is certain';
      break;
    case 1:
      eightBall = 'It is decidedly so';
      break;
    case 2:
      eightBall = 'Reply hazy try again';
      break;
    case 3:
      eightBall = 'Cannot predict now';
      break;
    case 4:
      eightBall = 'Do not count on it';
      break;
    case 5:
      eightBall = 'My sources say no';
      break;
    case 6:
      eightBall = 'Outlook not so good';
      break;
    case 7:
      eightBall = 'Signs point to yes';
      break;
    default:
      break; //unnecessary but good practice, apparently
  }
console.log(`The Magic Eight Ball says: ${eightBall}`); //printing the results