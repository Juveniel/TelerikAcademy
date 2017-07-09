function solve(args) {
    var numbers = (args.toString()).split('\n').map(Number),
        numbersLen = numbers.length,
        value = numbers.slice(-1)[0],
        startIndex  = 0,
        stopIndex   = numbersLen - 1,
        middle      = Math.floor((stopIndex + startIndex)/2);

    numbers = numbers.slice(1, -1);

    while(numbers[middle] != value && startIndex < stopIndex){

        if (value < numbers[middle]){
            stopIndex = middle - 1;
        } else if (value > numbers[middle]){
            startIndex = middle + 1;
        }

        middle = Math.floor((stopIndex + startIndex)/2);
    }

    return (numbers[middle] != value) ? -1 : middle;
}

solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']);