﻿window.onload = onloadstart;

function onloadstart() {
    
        var options = {
            zoom: 8
            , center: new google.maps.LatLng(18.2, -66.4)
            , mapTypeId: google.maps.MapTypeId.SATELLITE
        };
        var map = new google.maps.Map(document.getElementById('map'), options);
};