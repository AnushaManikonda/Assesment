function tablejson(data) {

    var col = [];
    for (var i = 0; i < data.length; i++) {
        for (var key in data[i]) {
            if (col.indexOf(key) === -1) {
               col.push(key);
            }
        }
    }

    // CREATE DYNAMIC TABLE.
    var table = document.createElement("table");

    // CREATE HTML TABLE HEADER ROW USING THE EXTRACTED HEADERS ABOVE.

    var tr = table.insertRow(-1);                   // TABLE ROW.

    for (var i = 0; i < col.length; i++) {
        var th = document.createElement("th");      // TABLE HEADER.
        th.innerHTML = col[i];
        tr.appendChild(th);
    }

    // ADD JSON DATA TO THE TABLE AS ROWS.
    for (var i = 0; i < data.length; i++) {

        tr = table.insertRow(-1);

        for (var j = 0; j < col.length; j++) {
            var tabCell = tr.insertCell(-1);
            tabCell.innerHTML = data[i][col[j]];
        }
    }

    // FINALLY ADD THE NEWLY CREATED TABLE WITH JSON DATA TO A CONTAINER.
    var divContainer = document.getElementById("showData");
    divContainer.innerHTML = "";
    divContainer.appendChild(table);
}
 
 var data;
$(document).ready(function () {
    $("#Button1").on('click', function () {
        $("#showData").toggle();
    });
});
$(document).ready(function () {
    $("#Button3").on('click', function () {
        $("#showData").show();
    });
});

function get() {
    $.ajax({
        type: "POST",
        //url: '<%= ResolveUrl("~/WebService2.asmx/hello") %>',
        url: '/WebService1.asmx/get',
        data: "{ 'pageno': '" + $('input[id$=TextBox3]').val() + "', 'pagesize': '" + $('input[id$=TextBox4]').val() + "'}",,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var data = JSON.parse(msg.d);
            tablejson(data);
        },
        error: function (xhr, status, message) {
            alert("Status: " + status + "\nMessage: " + message);
        }
    });
    return false;
}

function geting() {
    $.ajax({
        type: "POST",
        //url: '<%= ResolveUrl("~/WebService2.asmx/hello") %>',
        url: '/WebService1.asmx/get',
        data: "{ 'id': '" + $('input[id$=TextBox3]').val() + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var data = JSON.parse(msg.d);
            tablejson(data);
        },
        error: function (xhr, status, message) {
            alert("Status: " + status + "\nMessage: " + message);
        }
    });
    return false;
}



//this is for pageination list
/*var data;
$(document).ready(function () {
    $("#btnHello").on('click', function () {
        $("#showData").toggle();
    });
});

function hello() {
    var data;
    $.ajax({

        type: "POST",

        //url: '<%= ResolveUrl("~/WebService2.asmx/hello") %>',
        url: '/WebService2.asmx/Listofuser',
        data: "{ 'pageno': '" + $('input[id$=TextBox1]').val() + "', 'pagesize': '" + $('input[id$=TextBox2]').val() + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            data = JSON.parse(msg.d);
            tablejson(data);
        },
        error: function (xhr, status, message) {
            alert("Status: " + status + "\nMessage: " + message);
        }
    });
    return false;*/