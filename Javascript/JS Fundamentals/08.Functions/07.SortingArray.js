function SortArray(args){
    var params = (args.toString()).split('\n'),
        size = params[0],
        numbers = (params[1].toString()).split(' ').map(Number),
        min;

    for(var j = 0; j < size; j++){
        min = j;

        for(var k = j + 1; k < size; k++){
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

    console.log(numbers.join(' '));
}

SortArray(['10\n36 10 1 34 28 38 31 27 30 20']);