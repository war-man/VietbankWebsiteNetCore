var markers = [];
var map = null;
var markerCluster = null;
var clusterStyles = [{
    textSize: 16,
    textColor: '#e3f2fd',
    url: '/img/map/m1.png',
    height: 52,
    width: 53
},
{
    textSize: 18,
    textColor: '#e3f2fd',
    url: '/img/map/m2.png',
    height: 55,
    width: 56
},
{
    textSize: 20,
    textColor: '#e3f2fd',
    url: '/img/map/m3.png',
    height: 65,
    width: 66
}];
(function () {
    setHeightMap();
    initialSelect2Theme();
    getProvince();
    google.maps.event.addDomListener(window, 'load', initialize);
})();

function getAllTransagencyMap() {
    return requestAjaxGet('/api/ApiBranch/getalltransagencymap');
}

function initialSelect2Theme() {
    $.fn.select2.defaults.set("theme", "bootstrap");
}

function setHeightMap() {
    $('#branch-map').css("height", window.innerHeight);
}

function initialize() {
    getAllTransagencyMap().done(function (data) {
        $.each(data, function (i, e) {
            $('#branch-number').text(data.length);
            var marker = new google.maps.Marker({
                position: { "lat": parseFloat(e.latitude), "lng": parseFloat(e.longtitude) },
                customInfo: { branchName: e.transAgencyName, address: e.address, detail: e.details}
            });
            google.maps.event.addListener(marker, "click", function (e) {
                generateBranchDetail(marker.customInfo);
            });
            markers.push(marker);
        });
        map = new google.maps.Map(document.getElementById('branch-map'), {
            zoom: 9,
            center: new google.maps.LatLng(10.0309685, 105.7218933),
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            zoomControl: true
        });
        markerCluster = new MarkerClusterer(map, markers, { styles: clusterStyles });
        //initialInputSearch();
    }).fail(function () { });
};

function initialInputSearch() {
    var input = document.getElementById('input-search');
    var searchBox = new google.maps.places.SearchBox(input);
    map.controls[google.maps.ControlPosition.TOP_CENTER].push(input);
    //map.controls[null].push(input);
    map.addListener('bounds_changed', function () {
        searchBox.setBounds(map.getBounds());
    });
    var markers = [];
    // Listen for the event fired when the user selects a prediction and retrieve
    // more details for that place.
    searchBox.addListener('places_changed', function () {
        var places = searchBox.getPlaces();

        if (places.length == 0) {
            return;
        }

        // Clear out the old markers.
        markers.forEach(function (marker) {
            marker.setMap(null);
        });
        markers = [];
        // For each place, get the icon, name and location.
        var bounds = new google.maps.LatLngBounds();
        places.forEach(function (place) {
            if (!place.geometry) {
                console.log("Returned place contains no geometry");
                return;
            }

            // Create a marker for each place.
            markers.push(new google.maps.Marker({
                map: map,
                title: place.name,
                position: place.geometry.location
            }));

            if (place.geometry.viewport) {
                // Only geocodes have viewport.
                bounds.union(place.geometry.viewport);
            } else {
                bounds.extend(place.geometry.location);
            }
        });
        console.log(bounds);
        //map.fitBounds(bounds);
    });
}


function generateBranchDetail(branch) {
    var detail = '<li class="list-group-item"><p><strong>Chi nhánh: </strong>' + branch.branchName + '</p></li>';
    detail += '<li class="list-group-item"><p><strong>Địa chỉ: </strong>' + branch.address + '</p></li>';
    detail += '<li class="list-group-item"><p><strong>Liên hệ: </strong>' + branch.detail + '</p></li>';
    $('#branch-detail').html(detail);
}

function getProvince() {
    requestAjaxGet('/api/ApiBranch/getprovince').done(function (data) {
        generateSelectProvince(data)
    }).fail(function (error) {
        console.log(error);
    });
}

function setMapOnAll(map) {
    console.log(markers.length);
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(map);
    }
}

function clearMarkers() {
    setMapOnAll(null);
}

function deleteMarkers() {
    clearMarkers();
    markers = [];
}

function DeleteMarkers() {
    //Loop through all the markers and remove
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(null);
    }
    markers = [];
};

function generateSelectProvince(province) {
    var option = '<option></option>';
    for (var i = 0; i < province.length; i++) {
        option += '<option value="' + province[i].provinceId + '">' + province[i].name + '</option>';
    }
    $('select[name=province]').html(option);
    $('select[name=province]').select2({
        placeholder: 'Chọn tỉnh thành',
        width: '100%',
        height: '40px',
        containerCssClass: ':all:'
    });
    initSelectProvinceChange();
}

function initSelectProvinceChange() {
    $('select[name=province]').change(function () {
        getDistrict($(this).val());
    });
}

function getDistrict(province) {
    requestAjaxGet('/api/ApiBranch/getdistrict/' + province).done(function (data) {
        generateSelectDistrict(data);
    }).fail(function (error) {
        console.log(error);
    });
}

function generateSelectDistrict(district) {
    var option = '<option></option>';
    for (var i = 0; i < district.length; i++) {
        option += '<option value="' + district[i].districtId + '">' + district[i].name + '</option>';
    }
    $('select[name=district]').html(option);
    $('select[name=district]').select2({
        placeholder: 'Chọn quận/huyện',
        width: '100%',
        height: '40px',
        containerCssClass: ':all:'
    });
    initialSelectDistrictChange();
}

function initialSelectDistrictChange() {
    $('select[name=district]').change(function () {
        var province = $('select[name=province]').val();
        var district = $('select[name=district]').val();
        filterTransagencyMap(province, district);
    });
}

function filterTransagencyMap(province, district) {
    requestAjaxGet('/api/ApiBranch/filtertransagencymap/' + province + '/' + district).done(function (data) {
        $('#branch-number').text(data.length);
        reInitialize(data);
        generateListFilterBranch(data);
    }).fail(function (error) {
    });
}

function reInitialize(data) {
    markers = new Array();
    $.each(data, function (i, e) {
        $('#branch-number').text(data.length);
        var marker = new google.maps.Marker({
            position: { "lat": parseFloat(e.latitude), "lng": parseFloat(e.longtitude) },
            customInfo: { branchName: e.transAgencyName, address: e.address, detail: e.details }
        });
        google.maps.event.addListener(marker, "click", function (e) {
            generateBranchDetail(marker.customInfo);
        });
        markers.push(marker);
    });
    if (data.length > 0) {
        map = new google.maps.Map(document.getElementById('branch-map'), {
            zoom: 12,
            center: new google.maps.LatLng(data[0].latitude, data[0].longtitude),
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            zoomControl: true
        });
        markerCluster = new MarkerClusterer(map, markers, { styles: clusterStyles });
    } else {
        markerCluster.clearMarkers();
        $('#branch-detail').html(null);
    }
};

function generateListFilterBranch(branch) {
    var lstBranch = '';
    for (var i = 0; i < branch.length; i++) {
        lstBranch += '<li class="list-group-item">' +
            '<p><strong>' + branch[i].transAgencyName + '</strong></p >' +
            '<p><small>' + branch[i].address + '</small></p>'+
            '<p><small>' + branch[i].details + '</small></p>' +
            '<p><button data-pos-x="' + branch[i].latitude + '" data-pos-y="' + branch[i].longtitude + '" type="button" class="btn btn-primary btn-xs btn-view-location">Xem vị trí</button></p>' +
                    '</li >';
    }
    $('#list-branch-filter').html(lstBranch);
    initialViewLocationClick();
}

function initialViewLocationClick() {
    $('.btn-view-location').click(function () {
        var posX = $(this).attr('data-pos-x');
        var postY = $(this).attr('data-pos-y');
        var initialLocation = new google.maps.LatLng(posX, postY);
        console.log(initialLocation);
        map.setZoom(20);
        map.setCenter(initialLocation);
    });
}