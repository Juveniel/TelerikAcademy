function solve(args){
    var inputStr = String(args[0]),
        result = '',
        i;

    for(i = inputStr.length - 1; i >= 0 ; i--){
        result += inputStr[i];
    }

    console.log(result);
}

solve(['sample']);