//You have been employed by Kelvin, the mad scientist, to create an application that will alert him in simple, plain English, whether the weather is good enough for him to work on building his new lab somewhere within the boundary of his secret location.
//He has sensors set up to detect the temperature (now in Celsius, thanks to you!) and wants to display a message on one of his terminals based on that temperature.

temperature = prompt('What is the temperature in degrees Celsius?'); //this gives me error in certain compilers, not in most of them and I have no idea why
    if(isNaN(temperature)){ //I don't know why this work only if it's first and in general this is the only order that allowed me to make it work
        alert('Do you measure the temperature in letters? Dollar signs? Batman symbols? No, I want numbers!');
        } else if(temperature == '') { //I tried doing (temperature == null) but after moving around the parameters of the if...else if it wasn't working anymore
        alert('Write the damn temperature!');
        } else {
        console.log(temperature + '° Celsius detected.'); //not gonna use backtick, if I can avoid it...Italian keyboard
        }
condition = ['Sunny', 'Cloudy', 'Raining', 'Snowing', 'Thor']; //yay for array
condition = prompt('What weather condition can you observe, my minion? Choose from: Sunny, Cloudy, Raining, Snowing or Thor'); //it's late and I'm sleep deprived, let me have some fun with assignment! :D
if(!isNaN(condition)){ //shamelessly copied what I did above
    alert("Let's use words, please."); //as you can see, I use "" when I need to use the ' in the message
    } else if(condition == '') {
    alert('Was that a difficult question?');
    } else {
    console.log('The weather condition is ' + condition);
    }
if(goToWork = true) { //not really sure why goToWork needs to be boolean, but here it is
    switch (goToWork) {
        case (condition [0] && temperature >= 10):
        alert("Just go to work, you lazy bum. It's a nice day!");
        break;
        case (condition [1] && temperature >= 10):
        alert("Just go to work, you lazy bum. It's a nice day!");
        break;
        case (condition [0] && temperature > 20):
        alert("Just go to work, you lazy bum. It's a nice day!");
        break;
        case (condition [1] && temperature > 20):
        alert("Just go to work, you lazy bum. It's a nice day!");
        break;
        case (condition [2] && temperature > 20):
        alert("Outside it's warm and wet so *insert random sexual joke*");
        break;
        default:
        break;
    }
} else(goToWork = false); { //I have absolutely no idea on why, but VS wanted me to put a =>, while an online compiler wanted to put a ; which is working and I'm leaving it, but I'd like to know why
    switch (goToWork) {
        case (condition [2] && temperature >= 10):
        alert("It's raining, you can stay home. We'll postpone our world conquest, but next time find an ombrella");
        break;
        case (condition [3] && temperature >= 10):
        alert("In my days, the snow was colder and we used it instead of running water. Yes, you can stay home.");
        break;
        case (condition [4] && temperature >= 10):
        alert("Nobody likes a drunk angry nordic storm god");
        break;
        case (condition [3] && temperature > 20):
        alert("Warm AND snowing? Have you spiked my coffee?");
        break;
        case (condition [4] && temperature > 20):
        alert("Nobody likes a drunk angry nordic storm god");
        break;
        case (condition [0] && temperature > 30):
        alert("I'm half expecting giant sand worms emerging any minute, so you can stay home");
        break;
        case (condition [1] && temperature > 30):
        alert("I'm half expecting giant sand worms emerging any minute, so you can stay home");
        break;
        case (condition [2] && temperature > 30):
        alert("I'm half expecting giant sand worms emerging any minute, so you can stay home");
        break;
        case (condition [3] && temperature > 30):
        alert("I don't think it's snow with this temperature. I think it's ash.");
        break;
        case (condition [4] && temperature > 30):
        alert("Nobody likes a drunk angry nordic storm god");
        break;
        case (condition [0] && temperature <= 10):
        alert("Don't come to work unless you bring your own combustible");
        break;
        case (condition [1] && temperature <= 10):
        alert("Don't come to work unless you bring your own combustible");
        break;
        case (condition [2] && temperature <= 10):
        alert("Don't come to work unless you bring your own combustible");
        break;
        case (condition [3] && temperature <= 10):
        alert("Don't come to work unless you bring your own combustible");
        break;
        case (condition [4] && temperature <= 10):
        alert("Even Thor stays in Asgard, with this weather");
        break;
        default:
        break;
    }
}

/* As requested, I tried moving the conditions into a function (after semplifying everything else, as to work with less distractions), but it's not working and I don't why. Well, to be more precise, I know that I didn't really understand how to do it, so I winged it. I'd appreciate an explanation.
let temperature = prompt('What is the temperature in degrees Celsius?');
let condition = ['Sunny', 'Cloudy', 'Raining', 'Snowing', 'Thor'];
condition = prompt('What weather condition can you observe? Sunny, Cloudy, Raining, Snowing or Thunder?');
let goToWork = weather;
if (goToWork==true) {
alert('Come to work.')
} else {
alert('Stay home')
}
function weather (temperature, condition, goToWork) {
    if (temperature >= 10 && condition ('0', '1'))
    {
        return goToWork(true);
    } else if (temperature > 20 && condition ('0', '1', '2'))
    {
    		return goToWork(true);
    } else
    {
        return goToWork(false);
    }
}*/
