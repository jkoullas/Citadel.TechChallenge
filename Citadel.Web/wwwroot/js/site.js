
$('#submitButton').click(function () {

    var userValue = $("#userDetails").val();            
    var request = { Name: userValue };

    if (!$("#userDetails").val()) {
        $('#outputLabel').text("Please enter a name");
        return;
    }

    $.ajax(
        {
            type: "POST",
            url: "https://localhost:7128/api/user-detail",
            dataType: "text",
            data: JSON.stringify(request),
            contentType: "application/json; charset=utf-8",
            success: function (result) {
                $('#outputLabel').text(result)
            },
            error: function (req, status, error) {
                $('#outputLabel').text("We have a experienced an error and are not able to submit your request. Please try again later");
            }
        });
});
