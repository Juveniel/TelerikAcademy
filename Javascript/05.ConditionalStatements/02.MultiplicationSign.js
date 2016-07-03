function solve(args) {
    var productSign = "";
    var firstNum = Number(args[0]);
    var secondNum = Number(args[1]);
    var thirdNum = Number(args[2]);

    var firstNumSign = firstNum > 0 ? 1 : 0;
    var secondNumSign = secondNum > 0 ? 1 :0;
    var thirdNumSign = thirdNum > 0 ? 1 : 0;

    var sign = firstNumSign + secondNumSign + thirdNumSign;

    if(firstNum === 0 || secondNum === 0 || thirdNum === 0){
        productSign = "0";
    }
    else if(sign === 1 || sign === 3){
        productSign = "+";
    }
    else{
        productSign = "-";
    }

    console.log(productSign)
}

solve([5,2,2]);
solve([-2,-2,1]);
solve([-2,4,3]);
solve([0,-2.5,4]);
solve([-1,-0.5,5.1]);