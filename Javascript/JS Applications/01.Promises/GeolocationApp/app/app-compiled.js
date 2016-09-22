(function () {
    'use strict';

    /**
     * Location container
     */

    window.LC = window.LC || {};

    /**
     *  Inject the coordinates in html
     */
    let initMap = function initMap(coordinates) {
        if (!!navigator.geolocation) {
            var map;

            var mapOptions = {
                zoom: 16

            };

            map = new google.maps.Map(document.getElementById('map-location-canvas'), mapOptions);

            var geolocation = new google.maps.LatLng(coordinates.latitude, coordinates.longitude);

            var infowindow = new google.maps.InfoWindow({
                map: map,
                position: geolocation,
                maxWidth: 500,
                maxHeight: 50,
                content: '<h1>Location pinned from HTML5 Geolocation!</h1>' + '<h2>Latitude: ' + coordinates.latitude + '</h2>' + '<h2>Longitude: ' + coordinates.longitude + '</h2>'
            });

            map.setCenter(geolocation);
        } else {
            document.getElementById('map-location-canvas').innerHTML = 'No Geolocation Support.';
        }
    };

    /**
     *  Main
     */
    (function () {
        LC.currentLocation.getLocation().then(function (data) {
            initMap(data);
        });
    })();
})();

//# sourceMappingURL=app-compiled.js.map