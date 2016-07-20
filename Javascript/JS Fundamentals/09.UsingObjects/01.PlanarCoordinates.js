function PlanarCoodinates(args){
    var input = args.map(Number),
        x1 = input[0],
        y1 = input[1],
        x2 = input[2],
        y2 = input[3],
        x3 = input[4],
        y3 = input[5],
        x4 = input[6],
        y4 = input[7],
        x5 = input[8],
        y5 = input[9],
        x6 = input[10],
        y6 = input[11];

    var p1 = createPoint(x1, y1),
        p2 = createPoint(x2, y2),
        p3 = createPoint(x3, y3),
        p4 = createPoint(x4, y4),
        p5 = createPoint(x5, y5),
        p6 = createPoint(x6, y6);


    var firstLine = createLine(p1, p2),
        secondLine = createLine(p3, p4),
        thirdLine = createLine(p5, p6);

    function createPoint(x, y){
        return {
            'x' : x,
            'y' : y
        }
    }

    function createLine(pointA, pointB){
        return{
            'pointA' : pointA,
            'pointB' : pointB,
            'lineLength' : calculateLineLength(pointA, pointB)
        }
    }

    function calculateLineLength(pointA, pointB){
        return Math.sqrt((pointA.x - pointB.x) * (pointA.x - pointB.x) + (pointA.y - pointB.y) * (pointA.y - pointB.y));
    }

    function canFormTriangle(firstLine, secondLine, thirdLine){
        if((firstLine.lineLength + secondLine.lineLength > thirdLine.lineLength) &&
            (firstLine.lineLength + thirdLine.lineLength > secondLine.lineLength) &&
            (secondLine.lineLength + thirdLine.lineLength > firstLine.lineLength)) {
            return true;
        } else {
            return false;
        }
    }

    console.log((firstLine.lineLength).toFixed(2));
    console.log((secondLine.lineLength).toFixed(2));
    console.log((thirdLine.lineLength).toFixed(2));

    if(canFormTriangle(firstLine, secondLine, thirdLine)){
        console.log('Triangle can be built');
    }
    else{
        console.log('Triangle can not be built');
    }
}