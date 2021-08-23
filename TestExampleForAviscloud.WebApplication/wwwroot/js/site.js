function initialize() {
    initializeFormActions();
    initializeBrowseActions();
}

function initializeBrowseActions() {
    $('tr[data-worker-action="info"]').each(function () {
        $(this).on('click', function () {
            $.ajax({
                url: '/Home/Info',
                method: 'POST',
                data: { id: $(this).attr('data-worker-id') },
                success: function (data) {
                    $('div[data-card-name="form"]').html();
                    $('div[data-card-name="form"]').html(data);

                    initializeFormActions();
                }
            });
        })
    });
}

function initializeFormActions() {
    $('button[data-worker-action]').each(function () {
        $(this).on('click', function () {
            switch ($(this).attr('data-worker-action')) {
                case 'close':
                    onClickCloseForm();
                    break;
                case 'edit':
                    onClickEdit(this);
                    break;
                case 'save':
                    onClickSave();
                    break;
                default:
                    break;
            }
        });
    });
}

function updateBrowse() {
    $.ajax({
        url: '/Home/Browse',
        method: 'POST',
        success: function (data) {
            $('div[data-card-name="browse"]').html();
            $('div[data-card-name="browse"]').html(data);

            initializeBrowseActions();
        }
    });
}

function onClickCloseForm() {
    $('div[data-card-name="form"]').empty();
}

function onClickEdit(sender) {
    $('[disabled="disabled"]').each(function () {
        $(this).removeAttr('disabled');
    });

    $(sender).attr('disabled', 'disabled');
}

function onClickSave() {
    $.ajax({
        url: '/Home/Save',
        method: 'POST',
        data: $('form').serialize(),
        success: function (data) {
            $('div[data-card-name="form"]').html();
            $('div[data-card-name="form"]').html(data);

            updateBrowse();
        }
    });
}
