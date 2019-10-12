// Remove one item
$(".remove-item-btn").each(function (index, btn) {
    // When the user clicks the button, open the modal
    $(this).click(function (event) {
        event.stopPropagation();
        var itemId = $(this).parents(".menu-item").find("data").attr("itemId")
        $.post("/Home/DecreaseQuantityItem", { itemId: itemId, quantity: 1 }, function (data, status) {
            if (status == "success") {
                $(".menu-item").each(function (index, item) {
                    var JQItem = $(item);
                    var JQData = JQItem.find("data");
                    if (JQData.attr("itemId") == itemId) {
                        let cart = JSON.parse(data);
                        updateCartCount(cart["itemCount"]);
                        updateItemQuantity(JQItem, parseInt(JQData.attr("quantity")) - 1);
                        updateItemDisplay(JQItem)
                        updateMainMessageDisplay();
                        updateTotalPriceDisplay(cart["totalPrice"]);
                        return;
                    }
                });
            }
        });
    });
});

$(".remove-all-item-btn").each(function (index, btn) {
    // When the user clicks the button, open the modal
    $(this).click(function (event) {
        event.stopPropagation();
        var itemId = $(this).parents(".menu-item").find("data").attr("itemId")
        $.post("/Home/RemoveItemToCart", { itemId: itemId }, function (data, status) {
            if (status == "success") {
                $(".menu-item").each(function (index, item) {
                    var JQItem = $(item);
                    var JQData = JQItem.find("data");
                    if (JQData.attr("itemId") == itemId) {
                        let cart = JSON.parse(data);
                        updateItemQuantity(JQItem, 0);
                        updateItemDisplay(JQItem)
                        var cartNav = $("#cartNav").children('span');
                        cartNav.text(cart["itemCount"]);
                        updateMainMessageDisplay();
                        updateTotalPriceDisplay(cart["totalPrice"]);
                        return;
                    }
                });
            }
        });
    });
});

function updateItemQuantity(menuItem, newQuantity) {
    menuItem.find("data").attr("quantity", newQuantity);
}

function updateItemDisplay(menuItem) {
    var quantity = parseInt(menuItem.find("data").attr("quantity"));
    if (quantity < 1) {
        menuItem.remove();
        return true;
    }
    menuItem.find(".item-quantity").text(quantity);
    return false;
}

function updateMainMessageDisplay() {
    if ($("#cartItems").children().length == 0) {
        $("#CartEmpty").show();
        $("#CartNotEmpty").hide();
    }
    else {
        $("#CartEmpty").hide();
        $("#CartNotEmpty").show();
    }
}

function updatButtonOrderDisplay() {
    if ($("#cartItems").children().length == 0) {
        $(".order-btn").hide();
    }
    else {
        $(".order-btn").show();
    }
}

function updateTotalPriceDisplay(price) {
    if ($("#cartItems").children().length == 0) {
        $("#totalPrice").hide();
        return;
    }
    $("#totalPrice").show();
    $("#totalPrice").find(".price").text(price.toFixed(2) + "$");
}

let modal = new CartModal();
updateMainMessageDisplay();
updatButtonOrderDisplay();
$.post("/Home/CartJson", function (data, status) {
    if (status == "success") {
        updateTotalPriceDisplay(JSON.parse(data)["totalPrice"]);
    }
});

$(document).ready(function () {
    $('#ordersCreateForm').submit(function (event) {
        var customerName = $(this).find("#CustomerName").val();
        var customerAdress = $(this).find("#CustomerAdress").val();
        var customerPhoneNumber = $(this).find("#CustomerPhoneNumber").val();
        var token = $(this).find("[name=__RequestVerificationToken]").val();
        $.post("/Orders/Create",
            {
                CustomerName: customerName,
                CustomerAdress: customerAdress,
                CustomerPhoneNumber: customerPhoneNumber,
                __RequestVerificationToken: token
            },
            function (data, status) {
                if (status == "success") {
                    if (data != "") {
                        $('#ordersCreateForm').html($(data).find('#ordersCreateForm').html());
                        modal.openFun();
                    }
                    else {
                        location.reload();
                    }
                }
            });
        return false;
    });
}); 