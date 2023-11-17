//-------Телефонный справочник--------------//
function Phone(ID) {
    $.ajax({
        url: "/Home/Phone/",
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
            $('#ServicesModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    })
}

function GetLastName() {

    var isValid = true;

    if ($('#SearchName').val() == "") {
        $('#SearchName').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#SearchName').css('border-color', 'lightgrey');
    }
      
    
    
    if (isValid == false) {
        return false;
    }

        
    var data = {

        'str': $('#SearchName').val(),
               
    };
    $("#search").html("");

    $.ajax({

        url: "/Home/GetLastName",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(data),
        dataType: "html",
           success: function (data) {
                //$('#search').replaceWith(data);
               $('#search').empty();
               $('#search').html(data);
                
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//-------------------//