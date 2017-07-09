function solve(args){
    var coordX = parseFloat(args[0]);
    var coordY = parseFloat(args[1]);
    var distance = Math.sqrt((coordX * coordX) + (coordY * coordY));

    if(distance <= 2){
        return "yes " + distance.toFixed(2);
    }
    else{
        return "no " + distance.toFixed(2);
    }
}