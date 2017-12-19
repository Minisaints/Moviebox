$(document).ready(function () {

    ////////////// customers are fetched from our API

    var table = $("#rentals").DataTable(
        {
            ajax: {
                url: "/api/rentals",
                dataSrc: ""
            },
            columns: [
                {
                    data: "movieName"
                },
                {
                    data: "customerName"
                },
                {
                    data: "dateRented",
                    render: function (d) {
                        return moment(d).format("ddd Do MMM YYYY");
                    }
                },
                {
                    data: { "beenReturned": "beenReturned", "id": "id" },
                    render: function (data) {
                        if (!data.beenReturned)
                            return "<button class='btn btn-default btn-sm btn-block js-return' data-rental-id=" + data.id + ">Return</button>";
                        else
                            return "<button class='btn btn-success btn-sm btn-block js-returned' data-rental-id=" + data.id + ">Returned</button>";
                    }
                },
                {
                    data: "id",
                    orderable: false,
                    render: function (data) {
                        return "<button class='btn btn-danger btn-sm js-delete' data-rental-id=" + data + ">Delete</button>";
                    }
                }
            ]
        });

    // WHEN THE USER CLICKS ON DELETE BUTTON //////////////////////////////

    $("#rentals").on("click", ".js-delete",
        function () {

            var button = $(this);

            bootbox.confirm("Are you sure you want to delete the rental?",
                function (result) {
                    if (result) {
                        $.ajax({
                            url: "/api/rentals/" + button.attr("data-rental-id"),
                            method: "DELETE",
                            success: function () {
                                toastr.success("Rental record deleted.");
                                table.row(button.parents("tr")).remove().draw();
                            },
                            error: function () {
                                toastr.error("Unable to delete Rental record.");
                            }
                        });
                    }
                });
        });


    // WHEN THE USER CLICKS THE RETURN BUTTON //////////////////////////////

    $("#rentals").on("click", ".js-return",
        function () {
            if ($(this).hasClass("js-return")) {

                var button = $(this);

                //var object = {
                //    dateRented: new Date(),
                //    dateReturned: new Date(),
                //    beenReturned: true
                //};

                var newObject = [
                    {
                        "op": "replace",
                        "path": "/beenReturned",
                        "value": "true"
                    }
                ];

                $.ajax({
                    url: "/api/rentals/" + button.attr("data-rental-id"),
                    method: "PATCH",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(newObject),
                    success: function () {
                        button.text("Returned");
                        button.removeClass("btn-default js-return").addClass("btn-success js-returned");
                        toastr.success("Movie returned.");
                    },
                    error: function () {
                        console.log();
                        toastr.error("Unable to return movie.");
                    }
                });
            }
        });

    // WHEN THE USER CLICKS THE RETURN BUTTON //////////////////////////////

    $("#rentals").on("click", ".js-returned",
        function () {
            if ($(this).hasClass("js-returned")) {

                var button = $(this);

                //var object = {
                //    dateRented: new Date(),
                //    dateReturned: new Date(),
                //    beenReturned: false
                //};

                var newObject = [
                    {
                        "op": "replace",
                        "path": "/beenReturned",
                        "value": "false"
                    }
                ];

                $.ajax({
                    url: "/api/rentals/" + button.attr("data-rental-id"),
                    method: "PATCH",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(newObject),
                    success: function () {
                        button.text("Return");
                        button.removeClass("btn-success js-returned").addClass("btn-default js-return");
                        toastr.info("Movie un-returned.");
                    },
                    error: function () {
                        console.log();
                        toastr.error("Unable to un-return movie.");
                    }
                });
            }
        });
});