$('#create-project').on('click', function(evt) {
    evt.preventDefault();

    $.get({
        url: $(this).attr('href')
    }).done(function (result) {
        $('#projects-modal').html(result);
        $('#projects-modal').modal('show');
    }).fail(function (xhr, status, error) {
        console.log(error);
    });

    return false;
});

$(document).on('click', '.btn-expand', function() {
    $(this).html('<i class="fa fa-minus-square"></i>'); 
    $(this).removeClass("btn-expand").addClass("btn-collapse"); 
    $($(this).attr('data-target')).collapse('show');
});
$(document).on('click', '.btn-collapse', function() { 
    $(this).html('<i class="fa fa-plus-square"></i>'); 
    $(this).removeClass("btn-collapse").addClass("btn-expand");
    $($(this).attr('data-target')).collapse('hide');
});