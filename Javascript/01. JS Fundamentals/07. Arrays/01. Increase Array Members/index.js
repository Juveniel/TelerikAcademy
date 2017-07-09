function solve(args){
    var boundary = Number(args[0]),
        numbers = [];

    for(var i = 0; i < boundary; i++){
        numbers[i] = i * 5;
        console.log(numbers[i]);
    }
}

solve([5]);