(function() {
    window.LC = window.LC || {};
})();

/**
 * Gets the location from browser and resolve promise with data
 **/

LC.currentLocation = (function() {
    'use strict';

    //Possible error codes thrown via the Geolocation API
    var ERROR_TYPE_CODES = [
        'Unknown error',
        'Permission denied by user',
        'Position is not available',
        'Request timed out'
    ];

    /**
     * Gets the location from the browser.
     * @return Promise promise that is fulfilled when the Geolocation has been found
     **/
    var getLocation = function getLocation() {

        return new Promise(function(resolve, reject) {

            // Geolocation API
            navigator.geolocation.getCurrentPosition(
                function resolveLocation(position) {

                    var coordinates = {
                        latitude: position.coords.latitude,
                        longitude: position.coords.longitude
                    };
                    
                    resolve(coordinates);

                },
                function resolveError(error) {

                    var errorMessage = ERROR_TYPE_CODES[error.code];

                    if (error.code === 0 || error.code === 2) {
                        errorMessage += ' ' + error.message;
                    }

                    reject('Geolocation error: ' + errorMessage);

                }
            );
        });

    };

    //Location module API
    return {
        getLocation: getLocation
    };

})();