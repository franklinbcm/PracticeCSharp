function LoadFile() {
    if ($('#tbFileLoader').val().length < 5) {
        alert('Dabe seleccionar un documento');
    }
    else {
        var file = fixPath('tbFileLoader');
        debugger
        var fname = document.getElementById("tbFileLoader").files[0].name;
        $.ajax({
            type: "Get",
            url: "../Home/LoadFile",
            contentType: "application/json charset=utp-8",
            dataType: "json",
            data: { fileLocation: file, fileName: fname},
            success: function (data) {
                console.log(data);
            },
            error: function (err) {
                console.log(err);
            }

        })
    }


};
function GetUrl(vControl) {
    debugger
    $('input[type=file]').change(function () {
        debugger
        console.log(this.files[0].mozFullPath);
    });
}

 
function fixPath(vControl) {
    var input = document.getElementById(vControl);
    var fReader = new FileReader();
    fReader.readAsDataURL(input.files[0]);
    return fReader.result;
 
};