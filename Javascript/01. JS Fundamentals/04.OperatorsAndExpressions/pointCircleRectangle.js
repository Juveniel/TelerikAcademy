function solve(args) {
    var result = "";
    var insideCircle = false;
    var insideRectangle = false;

    var pointX = parseFloat(args[0]);
    var pointY = parseFloat(args[1]);

    var newX = pointX - 1;
    var newY = pointY - 1;

    var distance = Math.sqrt((newX * newX) + (newY * newY));

    if(distance <= 1.5) {
        insideCircle = true;
    }

    if(pointX >= -1 && pointX <= 5 && pointY <= 1 && pointY >= -1){
        insideRectangle = true;
    }

    if(insideCircle && insideRectangle){
        result = 'inside circle inside rectangle';
    }
    else if(!insideCircle && insideRectangle){
        result = 'outside circle inside rectangle';
    }
    else if(insideCircle && !insideRectangle){
        result = 'inside circle outside rectangle';
    }
    else{
        result = 'outside circle outside rectangle';
    }

    return result;
}
