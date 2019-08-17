function requestAjaxPost(dataInput, url) {
    return $.ajax({
        crossOrigin: true,
        async: true,
        url: url,
        headers: {
            'Content-Type': 'application/json'
        },
        type: 'POST',
        dataType: 'json',
        contentType: "application/json",
        data: JSON.stringify(dataInput)
    });
}

function requestAjaxGet(url) {
    return $.ajax({
        crossOrigin: true,
        async: true,
        url: url,
        headers: {
            'Content-Type': 'application/json'
        },
        type: 'GET',
        dataType: 'json',
        contentType: "application/json"
    });
}