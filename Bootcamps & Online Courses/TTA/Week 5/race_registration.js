let raceNumber = Math.floor(Math.random() * 1000);
const registeredEarly = false; //default value set as "false". Set as "true" if part of the early registration, if not leave "false"
const runnerAge = x; //substitute "x" with a proper numerical value for runnerAge

switch (true) { //I tried keeping the same switch method as the previous exercise
  case (runnerAge > 18 && registeredEarly):
  raceNumber += 1000;
  console.log(`You will race at 9:30 am and your number is ${raceNumber}.`);
  break;
  case (runnerAge > 18 && !registeredEarly):
  console.log(`You will race at 11:00 am and your number is ${raceNumber}.`);
  break;
  case (runnerAge < 18):
  console.log(`You will race at 12:30 pm and your number is ${raceNumber}.`);
  break;
  case (runnerAge == 18):
  console.log('Please go speak to the registation desk.');
  break;
  default:
  break; //again, I put this just for good practice
}
