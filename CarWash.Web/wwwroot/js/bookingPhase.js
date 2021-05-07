

"use strict";


var connection = new signalR.HubConnectionBuilder().withUrl("/signalHub").build();

connection.on("ReceiveNotification", function (userId, message) {
    if (currentUser == userId) {
        new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: message }).show();
    }
});

connection.start().then(function () {
    console.log("connection started");
    messageTextBox.disabled = false;
    sendButton.disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


function showNoty(type, message) {
    new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: message }).show();
}


var sendForm = document.getElementById("send-form");
var sendButton = document.getElementById("send-button");
var messagesList = document.getElementById("messages-list");
var messageTextBox = document.getElementById("message-textbox");
var newUserId = document.getElementById("userId");
var newChatId = document.getElementById("chatId");
var newUserName = document.getElementById("userName");

function appendMessage(message, time, date, userid) {
    if (currentUser == userid) {

        var outgoing_msg = document.createElement("div");
        outgoing_msg.classList.add("outgoing_msg");

        var sendmsg = document.createElement("div");
        sendmsg.classList.add("sent_msg");

        var p = document.createElement("p");
        p.appendChild(document.createTextNode(message));

        var span = document.createElement("span");
        span.classList.add("time_date");
        span.appendChild(document.createTextNode(time + "|" + date));

        outgoing_msg.appendChild(sendmsg);
        sendmsg.appendChild(p);
        sendmsg.appendChild(span);

        messagesList.append(outgoing_msg);

    }
    else {
        var incoming_msg = document.createElement("div");
        incoming_msg.classList.add("incoming_msg");

        var incoming_msg_img = document.createElement("div");
        incoming_msg_img.classList.add("incoming_msg_img");

        var image = document.createElement("img");
        image.classList.add("image");
        image.setAttribute("src", "~/userprofile/users/" + userid + "/thumbnail.png");
        image.setAttribute("alt", "user-image");

        var received_msg = document.createElement("div");
        received_msg.classList.add(" received_msg");

        var received_withd_msg = document.createElement("div");
        received_withd_msg.classList.add("received_withd_msg");

        var p = document.createElement("p");
        p.appendChild(document.createTextNode(content));

        var span = document.createElement("span");
        span.classList.add("time_date");
        span.appendChild(document.createTextNode(time + "|" + date));


        incoming_msg.appendChild(incoming_msg_img);
        incoming_msg_img.appendChild(image);
        incoming_msg.appendChild.appendChild(received_msg);
        received_msg.appendChild(received_withd_msg);
        received_withd_msg.appendChild(p);
        received_withd_msg.appendChild(span);

        messagesList.appendChild(incoming_msg);
    }


}

sendForm.addEventListener("submit", function (evt) {
    var message = messageTextBox.value;
    messageTextBox.value = "";
    var newuser = newUserId.value;
    var newchat = newChatId.value;
    var newusername = newUserName.value;

    connection.invoke("Send", message, newuser, newchat, newusername).catch(function (err) {
        return console.error(err.toString());
    });
    evt.preventDefault();
});


connection.on("SendMessage", function (message, time, date, userid, otherusers) {
    appendMessage(message, time, date, userid);
    if (currentShopOwner == otherusers) {
        new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: sender + ': ' + message + ' ' + time + ' ' + date }).show();

    }
});

connection.on("SendAction", function (sender, action) {
    console.log(sender + ' ' + action);
    new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: sender + ' ' + action }).show();
    appendMessage(sender + ' ' + action);
});


document.getElementById("sendButton").addEventListener("click", function (event) {
    var userName = document.getElementById("userName").value;
    var userID = document.getElementById("userId").value;
    var shopID = document.getElementById("shopId").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", userId, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
    var obj = {
        UserName: userName,
        UserId: userID,
        ShopId: shopID,
        Message: message
    }
    Send(obj);
});

function Send(obj) {
    var route = "/chat/messages";
    $.ajax({
        url: route,
        method: "POST",
        data: obj,
        success: function (redirectToIndex) {
            alert(redirectToIndex);
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


function AddItem(serviceId) {
    var userId = $("#userId").val();
    var bookingId = $("#bookingId").val();

    var object = {
        UserId: userId,
        ServiceId: serviceId,
        BookingId: bookingId
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


