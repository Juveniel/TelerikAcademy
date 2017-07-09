function solve(args) {
    var firstNum = Number(args[0]);
    var secondNum = Number(args[1]);

    if(firstNum > secondNum){
        var temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
    }

    return firstNum + " " + secondNum;
}