class MenuModal extends Modal {
    constructor() {
        super('#myModal', '.modal-close', '.modal-btn',
            function (sender) { this.openFun(sender) },
            function (sender) { this.closeFun(sender) });
    }

    openFun = function (sender) {
        let id = $(sender).find("data").attr("itemId");
        $("#addForm").find("#itemId").attr("value", id);
    }

    closeFun = function (sender) {
        $("#addForm").find("#quantity").val(1);
    }
}