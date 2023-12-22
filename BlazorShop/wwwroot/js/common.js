window.ShowToastr = (type, message) => {
    if (type == "success") {
        toastr.success(message, "Operation Successful", { timeOut: 5000 })
    }
    if (type == "error") {
        toastr.error(message, "Inconceivable!")
    }
}

window.ShowSweetAlert = (type, message) => {
    if (type == "success") {
        Swal.fire({
            title: "Good!",
            text: message,
            icon: "success"
        });
    }
    if (type == "error") {
        Swal.fire({
            title: "Wrong!",
            text: message,
            icon: "error"
        });
    }
}

function ShowDeleteConfirmModal() {
    $('#deleteModal').modal('show');
}

function HideDeleteConfirmModal() {
    $('#deleteModal').modal('hide');
}