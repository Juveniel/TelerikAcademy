function solve(args){
    var numbers = args[0].split(' ').map(Number),
        len = numbers.length,
        line, times = 0, direction = '', step = 0,
        currentRes = 0, currentIdx = 0,
        stepsCounts = [],
        i, j;

    for(i = 1; i < args.length; i += 1){
        if(args[i] === 'stop'){
            break;
        }

        line = args[i].split(' ');
        times = Number(line[0]);
        direction = String(line[1]);
        step = Number(line[2]);

        currentRes = 0;

        Move(times, direction, step);
        
        stepsCounts.push(currentRes);
    }

    function Move(times, direction , step){

        for(j = 0; j < times; j += 1){

            if(direction === 'right'){
                currentIdx = (currentIdx + step) % len;
            }
            else{
                currentIdx = (currentIdx - step) % len < 0
                    ? len + (currentIdx - step) % len
                    : (currentIdx - step) % len
            }

            currentRes += numbers[currentIdx];
        }
    }

    var avg = CalcAverage(stepsCounts);
    console.log(avg);

    function CalcAverage(numArr){
        var len = numArr.length,
            sum = 0,
            avg = 0;

        for(i = 0; i < len; i += 1){
            sum +=  Number(numArr[i]);
        }

        avg = sum / len;

        return avg;
    }
}

solve(
    [
        '1 2 3 4 5 6 7 8 9 10',
        '1 right 3',
        '1 left 3',
        '2 left 3',
        '3 left 5',
        'stop'
    ]
);
solve(
    [
        '1 2 3 5 7 10 20',
        '5 right 1',
        '2 left 2',
        '3 right 2',
        '1 left 3',
        'stop'
    ]
);