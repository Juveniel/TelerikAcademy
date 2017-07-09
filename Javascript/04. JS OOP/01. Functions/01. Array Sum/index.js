function isNumeric(n) {
    'use strict';
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function sumArray(numbers) {
    'use strict';
    var sum = 0;

    if (!Array.isArray(numbers) || numbers === 'undefined') {
        throw new Error('Unexpected numbers format');
    }

    if (numbers.length === 0) {
        return null;
    }

    numbers.forEach(function (element) {
        if (!isNumeric(element)) {
            throw new Error('Not a valid number');
        }
        sum += Number(element);
    });

    return sum;
};

module.exports = sumArray;
