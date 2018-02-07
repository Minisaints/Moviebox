$(function() {
    var galleryImage = $(".gallery").find("img").first();

    var gallery = [
        "/Content/images/image1.jpg",
        "/Content/images/image2.jpg",
        "/Content/images/image3.jpg"
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    ];

    var i = 0;

    setInterval(function() {
<<<<<<< HEAD
        i = (i + 1) % gallery.length;
        galleryImage.fadeOut(function() {
            $(this).attr("src", gallery[i]);
            $(this).fadeIn(2000);
        });
    }, 5000);
=======
            i = (i + 1) % gallery.length;
            galleryImage.fadeOut(function() {
                $(this).attr("src", gallery[i]);
                $(this).fadeIn(2000);
            });
        },
        5000);
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
});