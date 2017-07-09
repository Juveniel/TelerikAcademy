function solve(args){
    var numbers = (args.toString()).split('\n').map(Number),
        numbersLen = numbers.length,
        min;

    for(var j = 1; j < numbersLen; j++){
        min = j;

        for(var k = j + 1; k < numbersLen; k++){
            if(numbers[k] < numbers[min]){
                min = k;
            }
        }

        if(j != min){
            var temp = numbers[j];
            numbers[j] = numbers[min];
            numbers[min] = temp;
        }

    }

    console.log(numbers.splice(1).join('\n'));
}

solve(['6\n3\n4\n1\n5\n2\n6']);