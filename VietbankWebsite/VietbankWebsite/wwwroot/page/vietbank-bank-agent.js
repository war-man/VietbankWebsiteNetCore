(function () {
    getBankAgent();
})();

function getBankAgent() {
    $('#bank-agent').DataTable({
        ajax: {
            url: '/api/ApiAbout/getbankcode',
            headers: {
                'Content-Type': 'application/json'
            },
            type: 'GET'
        },
        columns: [
            { data: "swiftCode" },
            { data: "bankName" },
            { data: "city" },
            { data: "country" }
        ],
        "order": [[0, "desc"]],
        "bLengthChange": false,
        "info": false,
    });
}
