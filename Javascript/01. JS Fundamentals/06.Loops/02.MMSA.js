function solve(args) {
    var min = Math.min.apply(Math, args).toFixed(2);
    var max = Math.max.apply(Math, args).toFixed(2);
    var sum = 0;
    var avg = 0;

    for(var i = 0 ; i < args.length; i++){
        sum += parseFloat(args[i]);
    }

    avg = sum / args.length;

    console.log('min=' + min);
    console.log('max=' + max);
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}

solve([1,2,3,4,5]);