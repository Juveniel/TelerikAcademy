function solve(args){
    var firstNum = Number(args[0]);
    var secondNum = Number(args[1]);
    var thirdNum = Number(args[2]);
    var fourthNum = Number(args[3]);
    var fifthNum = Number(args[4]);


    if (firstNum>secondNum && firstNum>thirdNum && firstNum>fourthNum && firstNum>fifthNum)
    {
        console.log(firstNum);
    }
    else if (secondNum>firstNum && secondNum>thirdNum && secondNum>fourthNum && secondNum>fifthNum)
    {
        console.log(secondNum);
    }
    else if (thirdNum>firstNum && thirdNum>secondNum && thirdNum>fourthNum && thirdNum>fifthNum)
    {
        console.log(thirdNum);
    }
    else if (fourthNum>firstNum && fourthNum>thirdNum && fourthNum>secondNum && fourthNum>fifthNum)
    {
        console.log(fourthNum);
    }
    else
    {
        console.log(fifthNum);
    }
}

solve([1,2,3,4,6]);