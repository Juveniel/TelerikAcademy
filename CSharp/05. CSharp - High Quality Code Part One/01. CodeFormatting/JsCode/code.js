var browserDetection = (function(){
    var browserName = navigator.appName,
        addScroll = false,
        pageX = 0,
        pageY = 0;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    if (browserName === netscapeBrowserName) {
        document.captureEvents(Event.MOUSEMOVE);
    }

    document.addEventListener('mousemove', mouseMove);

    function mouseMove(ev) {
        if (browserName === "Netscape") {
            pageX = ev.pageX - 5;
            pageY = ev.pageY;
            if (document.layers.ToolTip.visibility === 'show') {
                ShowTooltip();
            }
        } else {
            pageX = event.x - 5;
            pageY = event.y;
            if (document.all.ToolTip.style.visibility === 'visible') {
                ShowTooltip();
            }
        }
    }

    function showTooltip() {
        if (browserName == "Netscape") {
            var theLayer = eval('document.layers[\'ToolTip\']');

            if ((pageX + 120) > window.innerWidth) {
                pageX = window.innerWidth - 150;
            }

            theLayer.left = pageX + 10;
            theLayer.top = pageY + 15;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = eval('document.all[\'ToolTip\']');

            if (theLayer) {
                pageX = eventObj.x - 5;
                pageY = eventObj.y;

                if (addScroll) {
                    pageX = pageX + document.body.scrollLeft;
                    pageY = pageY + document.body.scrollTop;
                }

                if ((pageX + 120) > document.body.clientWidth) {
                    pageX = pageX - 150;
                }

                theLayer.style.pixelLeft = pageX + 10;
                theLayer.style.pixelTop = pageY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function hideTooltip() {
        args = HideTooltip.arguments;

        if (browserName == "Netscape") {
            document.layers['ToolTip'].visibility = 'hide';
        }
        else {
            document.all['ToolTip'].style.visibility = 'hidden';
        }
    }

    function hideMenu(name) {
        if (browserName == "Netscape") {
            document.layers[name].visibility = 'hide';
        } else {
            document.all[name].style.visibility = 'hidden';
        }
    }

    function showMenu(name) {
        if (browserName == "Netscape") {
            document.layers[name].visibility = 'show';
        } else {
            document.all[name].style.visibility = 'visible';
        }
    }
}());
