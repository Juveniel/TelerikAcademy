function isNumeric(n) {
    'use strict';
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function findPrimesInRange(rangeStart, rangeEnd) {
    'use strict';
    var primeNumbers = [],
        isPrime,
        divider,
        i;

    if (!isNumeric(rangeStart) || rangeStart === 'undefined' ||
        !isNumeric(rangeEnd) || rangeEnd === 'undefined') {
        throw new Error('Function params must be valid numbers');
    }

    for (i = Math.max(rangeStart, 2); i <= rangeEnd; i += 1) {
        isPrime = true;

        for (divider = 2; divider <= Math.sqrt(i); divider += 1) {
            if (i % divider === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime) {
            primeNumbers.push(Number(i));
        }
    }

    return primeNumbers;
}

module.exports = findPrimesInRange;