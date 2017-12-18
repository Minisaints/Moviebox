$(document).ready(function () {

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
                    render: function (data, type, customer) {
                        return "<a href='/customers/edit/" + customer.id + "'>" + customer.name + "</a>";
                    }
                },
                {
                    data: "membershipType.name"
                }, {
                    data: "birthDate",
                    render: function (d) {
                        return moment(d).format("Do MMMM YYYY");
                    }
                },
                {
                    data: "id",
                    orderable: false,
                    render: function (data) {
                        return "<button class='btn btn-danger btn-sm js-delete' data-customer-id=" + data + ">Delete</button>";
                    }
                }
            ]
        });

    //////////////////////////////////////////////////

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
        });
});