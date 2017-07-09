function solve(args) {
    var sideA = parseFloat(args[0]);
    var sideB = parseFloat(args[1]);
    var height = parseFloat(args[2]);

    var trapezoidArea = ((sideA + sideB) /2) * height;

    return trapezoidArea.toFixed(7);
}



