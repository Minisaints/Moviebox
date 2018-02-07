<<<<<<< HEAD
﻿$(document).ready(function () {
=======
﻿$(document).ready(function() {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012

    // customers are fetched from our API
    var table = $("#rentals").DataTable(
        {
            ajax: {
                url: "/api/customers",
                dataSrc: ""
            },
            columns: [
                {
                    data: "name",
<<<<<<< HEAD
                    render: function (data, type, customer) {
=======
                    render: function(data, type, customer) {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                        return "<a href='/customers/edit/" + customer.id + "'>" + customer.name + "</a>";
                    }
                },
                {
                    data: "membershipType.name"
                }, {
                    data: "birthDate",
<<<<<<< HEAD
                    render: function (d) {
=======
                    render: function(d) {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                        return moment(d).format("Do MMMM YYYY");
                    }
                },
                {
                    data: "id",
                    orderable: false,
<<<<<<< HEAD
                    render: function (data) {
                        return "<button class='btn btn-danger btn-sm js-delete' data-customer-id=" + data + ">Delete</button>";
=======
                    render: function(data) {
                        return "<button class='btn btn-danger btn-sm js-delete' data-customer-id=" +
                            data +
                            ">Delete</button>";
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                    }
                }
            ]
        });

    //////////////////////////////////////////////////

<<<<<<< HEAD
    $("#rentals").on("click", ".js-delete",
        function () {
            var button = $(this);

            bootbox.confirm("Are you sure you want to delete the customer?", function (result) {
                if (result) {
                    $.ajax({
                        url: "/api/customers/" + button.attr("data-customer-id"),
                        method: "DELETE",
                        success: function () {
                            toastr.success("Customer record deleted.");
                            table.row(button.parents("tr")).remove().draw();
                        },
                        error: function () {
                            toastr.error("Unable to delete Customer record.");

                        }
                    });
                }
            });
=======
    $("#rentals").on("click",
        ".js-delete",
        function() {
            var button = $(this);

            bootbox.confirm("Are you sure you want to delete the customer?",
                function(result) {
                    if (result) {
                        $.ajax({
                            url: "/api/customers/" + button.attr("data-customer-id"),
                            method: "DELETE",
                            success: function() {
                                toastr.success("Customer record deleted.");
                                table.row(button.parents("tr")).remove().draw();
                            },
                            error: function() {
                                toastr.error("Unable to delete Customer record.");

                            }
                        });
                    }
                });
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        });
});