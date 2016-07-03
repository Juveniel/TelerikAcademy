function solve(args){
    var firstNum = Number(args[0]);
    var secondNum = Number(args[1]);
    var thirdNum = Number(args[2]);

    var temp = 0;
    if (firstNum < secondNum) {
        temp = secondNum;
        secondNum = firstNum;
        firstNum = temp;
    }

    if (secondNum < thirdNum) {
        temp = thirdNum;
        thirdNum = secondNum;
        secondNum = temp;
    }

    if (firstNum < secondNum) {
        temp = secondNum;
        secondNum = firstNum;
        firstNum = temp;
    }

    console.log(firstNum + " " + secondNum + " " + thirdNum);
}

solve([5,1,2]);
solve([-2,-2,1]);
solve([-2,4,3]);
solve([0, -2.5, 5]);
solve([-1.1,-0.5, -0.1]);
solve([10,20,30]);