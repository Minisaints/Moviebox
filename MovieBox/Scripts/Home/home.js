//@Scripts.Render("~/bundles/slideshow")

//SLIDESHOW BELOW
//<img alt="" src="/Content/images/image1.jpg" />

    $(document).ready(function() {
        $(".movie").on("mouseover",
                function () {
                    var movie = $(this);
                    movie.fadeTo(100, 0.6);

                }),
            $(".movie").on("mouseleave",
                function() {
                    var movie = $(this);
                    movie.fadeTo(100, 1.0);

                }),
            $(".frontTitle_latestRelease").on("click",
                function() {
                    var movie = $(".jumbotron_latestRelease");
                    movie.slideToggle(1000);
                }),
            $(".frontTitle_popularMovies").on("click",
                function() {
                    var movie = $(".jumbotron_popularMovies");
                    movie.slideToggle(1000);
                });

        $(".icon-tower").on("mouseover",
            function() {
                $(".message-tower").show();
            }).on("mouseleave",
            function() {
                $(".message-tower").hide();

            });

        $(".icon-monitor").on("mouseover",
            function() {
                $(".message-monitor").show();
            }).on("mouseleave",
            function() {
                $(".message-monitor").hide();

            });
    });