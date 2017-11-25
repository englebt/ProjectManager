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