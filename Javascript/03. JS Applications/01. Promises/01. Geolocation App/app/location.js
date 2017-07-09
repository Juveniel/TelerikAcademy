var getLocation = function() {

    return new Promise(function(resolve, reject) {

        navigator.geolocation.getCurrentPosition(function (position) {
            var coords = {
                latitude: position.coords.latitude,
                longitude: position.coords.longitude
            };

            resolve(coords);
        }, function(error) {
            reject();
        });

    })
};