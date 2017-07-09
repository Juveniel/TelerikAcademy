function solve(args){
    var isPrime = true;
    var numberToCheck = Number(args[0]);

    if(numberToCheck < 2){
        isPrime = false;
    }

    for(var i = 2; i <= Math.sqrt(numberToCheck); i++){
        if(numberToCheck % i === 0){
            isPrime = false;
            break;
        }
    }

    return isPrime;
}