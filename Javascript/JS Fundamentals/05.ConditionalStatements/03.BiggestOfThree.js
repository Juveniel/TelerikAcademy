function solve(args){
    var firstNum = Number(args[0]);
    var secondNum = Number(args[1]);
    var thirdNum = Number(args[2]);
    
    return Math.max(firstNum,secondNum, thirdNum);;
}

solve([1,2,3]);