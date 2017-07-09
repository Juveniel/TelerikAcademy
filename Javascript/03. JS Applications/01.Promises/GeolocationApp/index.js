(function() {
    'use strict';

    window.GLO = window.GLO || {};

    /* Inject received coordinates in view */
    var injectCoordinates = function(coordinates) {
        document.getElementById('lattitude').innerHTML = coordinates.lattitude;
        document.getElementById('longtitude').innerHTML = coordinates.longtitude;
    };

    (function () {
                
    });
}());