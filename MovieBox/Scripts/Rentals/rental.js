<<<<<<< HEAD
$(document).ready(function () {
=======
$(document).ready(function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012

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
<<<<<<< HEAD
                    render: function (d) {
=======
                    render: function(d) {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                        return moment(d).format("ddd Do MMM YYYY");
                    }
                },
                {
                    data: { "beenReturned": "beenReturned", "id": "id" },
<<<<<<< HEAD
                    render: function (data) {
                        if (!data.beenReturned)
                            return "<button class='btn btn-default btn-sm btn-block js-return' data-rental-id=" + data.id + ">Return</button>";
                        else
                            return "<button class='btn btn-success btn-sm btn-block js-returned' data-rental-id=" + data.id + ">Returned</button>";
=======
                    render: function(data) {
                        if (!data.beenReturned)
                            return "<button class='btn btn-default btn-sm btn-block js-return' data-rental-id=" +
                                data.id +
                                ">Return</button>";
                        else
                            return "<button class='btn btn-success btn-sm btn-block js-returned' data-rental-id=" +
                                data.id +
                                ">Returned</button>";
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                    }
                },
                {
                    data: "id",
                    orderable: false,
<<<<<<< HEAD
                    render: function (data) {
                        return "<button class='btn btn-danger btn-sm js-delete' data-rental-id=" + data + ">Delete</button>";
=======
                    render: function(data) {
                        return "<button class='btn btn-danger btn-sm js-delete' data-rental-id=" +
                            data +
                            ">Delete</button>";
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                    }
                }
            ]
        });

    // WHEN THE USER CLICKS ON DELETE BUTTON //////////////////////////////

<<<<<<< HEAD
    $("#rentals").on("click", ".js-delete",
        function () {
=======
    $("#rentals").on("click",
        ".js-delete",
        function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012

            var button = $(this);

            bootbox.confirm("Are you sure you want to delete the rental?",
<<<<<<< HEAD
                function (result) {
=======
                function(result) {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                    if (result) {
                        $.ajax({
                            url: "/api/rentals/" + button.attr("data-rental-id"),
                            method: "DELETE",
<<<<<<< HEAD
                            success: function () {
                                toastr.success("Rental record deleted.");
                                table.row(button.parents("tr")).remove().draw();
                            },
                            error: function () {
=======
                            success: function() {
                                toastr.success("Rental record deleted.");
                                table.row(button.parents("tr")).remove().draw();
                            },
                            error: function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                                toastr.error("Unable to delete Rental record.");
                            }
                        });
                    }
                });
        });


    // WHEN THE USER CLICKS THE RETURN BUTTON //////////////////////////////

<<<<<<< HEAD
    $("#rentals").on("click", ".js-return",
        function () {
=======
    $("#rentals").on("click",
        ".js-return",
        function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
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
<<<<<<< HEAD
                    success: function () {
=======
                    success: function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                        button.text("Returned");
                        button.removeClass("btn-default js-return").addClass("btn-success js-returned");
                        toastr.success("Movie returned.");
                    },
<<<<<<< HEAD
                    error: function () {
=======
                    error: function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                        console.log();
                        toastr.error("Unable to return movie.");
                    }
                });
            }
        });

    // WHEN THE USER CLICKS THE RETURN BUTTON //////////////////////////////

<<<<<<< HEAD
    $("#rentals").on("click", ".js-returned",
        function () {
=======
    $("#rentals").on("click",
        ".js-returned",
        function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
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
<<<<<<< HEAD
                    success: function () {
=======
                    success: function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                        button.text("Return");
                        button.removeClass("btn-success js-returned").addClass("btn-default js-return");
                        toastr.info("Movie un-returned.");
                    },
<<<<<<< HEAD
                    error: function () {
=======
                    error: function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                        console.log();
                        toastr.error("Unable to un-return movie.");
                    }
                });
            }
        });
});