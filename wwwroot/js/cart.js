$(".remove-item-btn").each(function (index, btn) {
    // When the user clicks the button, open the modal
    $(this).click(function (event) {
        event.stopPropagation();
        var itemId = $(this).parents(".modal-btn").find("data").attr("itemId")
        $.post("/Home/RemoveItemToCart", { itemId: itemId }, function (data, status) {
            if (status == "success") {
                $(".menu-item").each(function (index, item) {
                    var JQItem = $(item);
                    if (JQItem.find("data").attr("itemId") == itemId) {
                        JQItem.remove();
                        var cartNav = $("#cartNav").children('span');
                        cartNav.text(parseInt(cartNav.text()) - 1);
                        return;
                    }
                });
            }
        });
    });
});

new CartModal();