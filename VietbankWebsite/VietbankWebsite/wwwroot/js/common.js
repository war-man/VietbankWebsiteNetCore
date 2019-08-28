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

function isEmpty(obj) {
    if (obj === undefined) {
        return true;
    }

    if (obj === null) {
        return true;
    }

    return false;
}

function replaceHtmlToNull(html,endChar) {
    if (isEmpty(html) === false) {
        return html.replace(/<[^>]*>?/gm, '').substring(0, endChar).concat('...');
    }
    return '<p></p>';
}