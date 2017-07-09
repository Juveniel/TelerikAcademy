function solve(args){
    var N = Number(args[0]),
        K = Number(args[1]),
        numbers = args[2].split(' ').map(Number),
        result = [], temp = [],
        min = 0, max = 0, sum = 0, i;

    for(i = 0; i < N - K + 1; i += 1){
        for(var j = i; j < i + K; j += 1){
            temp.push(numbers[j]);
        }

        min = Math.min.apply(Math, temp);
        max = Math.max.apply(Math, temp);

        sum = min + max;
        result.push(sum);
        temp = [];
    }

    console.log(result.join(','));
}

solve(['8', '4', '1 8 8 4 2 9 8 11']);
solve(['4', '2', '1 3 1 8']);
solve(['5', '3', '7 7 8 9 10']);