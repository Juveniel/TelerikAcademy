function solve(args){
    var inputNum = Number(args[0]);
    var thirdDigit = Math.floor(inputNum / 100) % 10;

    if(thirdDigit == 7){
        return true;
    }

    return false + " " + thirdDigit;
}
