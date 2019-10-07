class CartModal extends Modal {
    openFun = function () {
        $("#myModal").find("#modalPicture").attr("style", "background-image: url('data:image/png;base64," + $(this).children("data").attr("image") + "'); background-size: cover; background-position: center");
        $("#myModal").find("#itemId").attr("value", $(this).children("data").attr("itemId"));
        //$("#myModal").find("#modalContent").text($(this).children("data").attr("name"));
    }

    constructor() {
        super('#myModal', '.modal-close', '.modal-btn',
            function (sender) { this.openFun(sender) },
            function (sender) { this.closeFun(sender) });
    }

    openFun = function (sender) {
        $("#myModal").find("#modalPicture").attr("style", "background-image: url('data:image/png;base64," + $(sender).children("data").attr("image") + "'); background-size: cover; background-position: center");
        $("#myModal").find("#itemId").attr("value", $(sender).children("data").attr("itemId"));
        //$("#myModal").find("#modalContent").text($(this).children("data").attr("name"));
    }

    closeFun = function (sender) {
    }
}