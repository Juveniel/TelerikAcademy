function solve(args){
    var a = +(args[0]);
    var b = +(args[1]);
    var c = +(args[2]);

    var diskriminante = (b * b) - (4 * (a * c));

    var result;
    if(diskriminante > 0){
        var x2 = (-b + Math.sqrt(diskriminante)) / (2 * a);
        var x1 = (-b - Math.sqrt(diskriminante)) / (2 * a);

        result = 'x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2);
    }
    else if(diskriminante == 0){
        var x12 = -b / (2 * a);

        result = 'x1=x2=' + x12.toFixed(2);
    }
    else{
        result = 'no real roots';
    }

    console.log(result);
}


solve([-0.5,4,-8]);