

"use strict";


var connection = new signalR.HubConnectionBuilder().withUrl("/signalHub").build();

connection.on("ReceiveNotification", function (userId, message) {
    if (currentUser == userId) {
        new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: message }).show();
    }
});

connection.start().then(function () {
    console.log("connection started");
});

function showNoty(type, message) {
    new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: message }).show();
}



$(document).ready(function () {
    $("#autoSubmit").click(function () {

        var userId = $("#UserId").val();
        var serviceId = $("#serviceId").val();
        var phoneNumber = $("#PhoneNumber").val();
        var userName = $("#username").val();
        var email = $("#email").val();
        var bookingAddress = $("#bookingAddress").val();
        var time = $("#time").val();
        var title = $("#Title").val();
        var type = $("#ServiceType").val();
        var price = $("#Price").val();
        var description = $("#Description").val();

        var auto = {
            UserId: userId,
            ServiceId : serviceId,
            PhoneNumber: phoneNumber,
            Email: email,
            Time: time,
            BookingAddress: bookingAddress,
            Username: userName,
            Title: title,
            ServiceType: type,
            Description: description,
            Price: price
        }

        AutoBookForm(auto);
    });
});



function AutoBookForm(auto) {
    var route = "/booking/costumer-service";
        $.ajax({
            url: route,
            method: "POST",
            data: auto,
            success: function (redirectToIndex) {
                window.location = redirectToIndex;
            },
            error: function (err) {
                $("#ErrorList").html(err);
            }
        });
    }



function BtnClick(value) {
    var userId = $("#userId").val();
  
    var obj =  {
        UserId: userId,
        VehicleType: value
    }

    submitForm(obj);
    
}

function submitForm(obj) {
    var routeOne = "/booking/phase-one-booking";

    $.ajax({
        url: routeOne,
        method: "POST",
        data: obj,
        success: function (redirectToPhaseTwo) {
            window.location = redirectToPhaseTwo;
        },
        error: function (err) {
            console.error(err);
        }
    });
}


function getServices(type) {
    $("#tableList").removeClass("d-none");

    $.get("/booking/services-indiv-per-type/" + type, function (data, status) {
                    var template = `
                                <tr>
                                    <td>#TITLE#</td>
                                    <td>#SERVICEDESCRIPTION#</td>
                                    <td>#PRICE#</td>
                                    <td>#SERVICETYPE#</td>
                                    <td>
                                        <a href="#dialog" role="button" title="Add-Services" onclick="AddItem('#SERVICEID#')" data-toggle="modal"><i class="fas fa-cart-plus"></i></a>
                                    </td>
                                </tr>   
                        `;
        var markup = "";

        $.each(data, function (phasetwo, services) {
            markup = markup + template.replace("#ID#", services.id).replace("#SERVICEID#", services.id).replace("#SERVICEDESCRIPTION#", services.description).replace("#TITLE#", services.vehicle).replace("#DATE#", services.updatedAt).replace("#SERVICETYPE#", services.serviceType).replace("#PRICE#", services.price);
        });

        $("#services-list").html(markup);
        //$(".col-icon").addClass("fa-10x");
    });
}

function confirmDelete(bookingId,title,userId,serviceId) {
    $("#modal-delete-service-title").html(title);
    $("#modal-delete-service-confirm").attr("href", "/booking/delete-item/" + bookingId + "/" + userId + "/" + serviceId);
    $("#modal-delete-service").modal("show");
   
    $("#closeModalOne").modal("hide");
    $("#closeModalTwo").modal("hide");
}

function EmptyItems(userID) {
    $("#modal-empty-service-title").html("All items");
    $("#modal-empty-service-confirm").attr("href", "/booking/empty-items/" + userID).alert("Successfully empty all items");
    $("#modal-empty-service").modal("show");

    $("#closeEmptyOne").modal("hide");
    $("#closeEmptyTwo").modal("hide");
   


}


$(document).ready(function () {
    $("#submit").click(function () {
        var userId = $("#UserId").val();
        var serviceId = $("#ServiceId").val();
        var userName = $("#UserName").val();
        var phoneNumber = $("#PhoneNumber").val();
        var email = $("#Email").val();
        var time = $("#Time").val();
        var address = $("#Address").val();


        var objPhaseThree = {
            UserId: userId,
            ServiceId: serviceId,
            PhoneNumber: phoneNumber,
            Email: email,
            Time: time,
            Address: address,
            Username: userName
        }

        PhaseThreeSubmitForm(objPhaseThree);

    });

});

    
function PhaseThreeSubmitForm(objPhaseThree) {
    var routePhaseThree = "/booking/phase-three-booking";
    $.ajax({
        url: routePhaseThree,
        method: "POST",
        data: objPhaseThree,
        success: function (redirectToIndex) {
            window.location = redirectToIndex;
        },
        error: function (err) {
            $("#ErrorList").html(err);
        }
    });
}

function AddItem(serviceId) {
    var userId = $("#userId").val();


    var object = {
        UserId: userId,
        ServiceId: serviceId
    }

    AddForm(object);

}

function AddForm(object) {
    var route = "/booking/add-service-item";
    $.ajax({
        url: route,
        method: "POST",
        data: object,
        success: function (redirectToPhaseThree) {
            window.location = redirectToPhaseThree;
        },
        error: function (err) {
            alert(err);
        }
    });
}


