// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function getFormDataDynamicFunction(inputElementArray) {

    var obj = {};

    inputElementArray.each(function () {

        var inputName = $(this).attr('name');
        var inputValue = $(this).val();

        var inputName = $(this).attr('name');
        var inputVal;

        if ($(this).hasClass('datalist-input-validation')) {
            var datalistOption = $(this).data('datalist')
            var selectedOption = $(datalistOption + ' option[value="' + $(this).val() + '"]');
            var inputVal = selectedOption.data('id');
        } else if ($(this).hasClass('form-check-input')) {
            inputVal = $(this).is(':checked');
        } else if ($(this).hasClass('get-input-data-id')) {
            inputVal = $(this).attr('data-id');
        } else if ($(this).is('td')) {
            ($(this).hasClass('get-input-data-id') ? inputVal = $(this).attr('data-id') : inputVal = $(this).text());
        } else {
            val = $(this).val();
            ($(this).hasClass('is-input-number') ? inputVal = parseInt(val) : inputVal = val);
        }

        obj[inputName] = inputVal;

        if ($(this).parent().parent().attr('data-new-unique-id')) {
            var dataRowUniqueID = $(this).parent().parent().attr('data-new-unique-id');
            if (data2316Array.length > 0) {
                var indexOfExistingObj = data2316Array.findIndex((obj) => {
                    if (obj !== undefined) {
                        return obj.uniqueID === dataRowUniqueID || obj.workHistoryID === dataRowUniqueID;
                    }
                });

                var data2316Arr = [];
                data2316Arr.push(data2316Array[indexOfExistingObj]);
                obj['uniqueID'] = dataRowUniqueID;
                obj['prevEmp2316Input'] = data2316Arr;
            }
        }

    });

    return obj;

}

function getTableRowData(tbodyId) {

    var dataArrayObj = [];

    var tableRows = $(tbodyId).find('tr');

    tableRows.map((index, row) => {
        var inputs = $(row).find('td, td input, td select, td textarea');
        var dataObj = getFormDataDynamicFunction(inputs);

        dataArrayObj.push(dataObj);
    });

    //console.log(dataObj);
    return dataArrayObj;

}

function getDataFromDatalist(inputValue, datalistSelector, dataAttribute) {
    var selectedOption = $(datalistSelector + " option[value='" + inputValue + "']").attr(dataAttribute);
    return selectedOption;
}

function setupImagePreview(inputId, previewId) {

    var $fileInput = $(inputId);
    var $imagePreview = $(previewId);

    $fileInput.on('change', function () {
        var file = this.files[0];

        if (file && !/^image\/(jpeg|jpg|png)$/.test(file.type)) {
            alert('Please select a valid image file (JPEG or PNG).');
            //resetInput();
            return;
        }

        if (file && file.size > 2 * 1024 * 1024) {
            alert('File size exceeds the maximum allowed limit (2MB).');
            //resetInput();
            return;
        }

        var reader = new FileReader();

        reader.onload = function (e) {
            $imagePreview.attr('src', e.target.result).removeClass('image-custom');
        };

        reader.readAsDataURL(file);
    });
}


function confirmation(hdr = "", msg = "", confirmbtntxt = "Yes", cancelbtntxt = "No") {
    return Swal.fire({
        title: hdr,
        html: msg,
        showDenyButton: true,
        confirmButtonText: confirmbtntxt,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#6c757d',
        denyButtonText: cancelbtntxt,
        icon: 'question',
        allowOutsideClick: false,
    });
}

function swal_loading(hdr = "", msg = "") {
    return Swal.fire({
        title: hdr,
        html: msg,
        allowOutsideClick: false,
        timerProgressBar: false,
        didOpen: () => {
            Swal.showLoading();
        },
        willClose: () => {
            this.close();
        }
    });
}

function success_alert(hdr = "", msg = "") {
    return Swal.fire(hdr, msg, 'success');
}

function failed_alert(hdr = "", msg = "") {
    return Swal.fire(hdr, msg, 'error');
}

function warning_alert(hdr = "", msg = "") {
    return Swal.fire(hdr, msg, 'warning');
}

function info_alert(hdr = "", msg = "") {
    return Swal.fire(hdr, msg, 'info');
}

function success_alert_custom(hdr = "", msg = "", confirmbtntxt = "Yes", cancelbtntxt = "No") {
    return Swal.fire({
        title: hdr,
        html: msg,
        showDenyButton: true,
        confirmButtonText: confirmbtntxt,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#6c757d',
        denyButtonText: cancelbtntxt,
        icon: 'success',
        allowOutsideClick: false,
    });
}