window.onload = function(){
    handleRedirectBtn();
    handleOverlayClick();
};

function handleRedirectBtn() {
    var redirectBtn = document.getElementById('redirect-btn');

    redirectBtn.addEventListener('click', function() {
        var showPopupWindow = new Promise(function(resolve, reject) {

            createShowPopup('popup', 'Redirecting to some fancy place ( :');

            window.setTimeout(
                function() {
                    resolve();
                }, 2000);
        });

        showPopupWindow.then(function() {
            window.location = 'http://best.telerikacademy.com/';
        });
    });
}

function handleOverlayClick() {
    var overlay = document.getElementById('popup-overlay'),
        popups = document.getElementsByClassName('popup');

    overlay.addEventListener('click', function () {
        document.body.removeChild(popups[0]);
        overlay.style.display = 'none';
    });
}

function createShowPopup(elementClass, text){
    let popup = document.createElement('div'),
        overlay = document.getElementById('popup-overlay');

    popup.className = elementClass;
    popup.innerHTML = text;

    overlay.style.display = 'block';
    document.body.appendChild(popup);
}
