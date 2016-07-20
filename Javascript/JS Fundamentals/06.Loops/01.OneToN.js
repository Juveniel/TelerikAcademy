function solve(args){
    var result = [];
    var boundary = Number(args[0]);

    for(var i = 1; i <= boundary; i++){
        result.push(i);
    }

    console.log(result.join(' '));
}

solve([5]);
solve([1]);