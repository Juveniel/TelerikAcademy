function solve(args) {
    var boundary = Number(args[0]);
    var max = 0;
    for (var i = boundary; i >= 0; i--) {
        var isPrime = true;

        for (var divider = 2; divider <= Math.sqrt(i); divider++) {
            if (i % divider === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            max = i;
            break;
        }
    }
    console.log(max);
}
solve([13]);
solve([126]);