$(function() {
    var galleryImage = $(".gallery").find("img").first();

    var gallery = [
        "/Content/images/image1.jpg",
        "/Content/images/image2.jpg",
        "/Content/images/image3.jpg"

    ];

    var i = 0;

    setInterval(function() {
        i = (i + 1) % gallery.length;
        galleryImage.fadeOut(function() {
            $(this).attr("src", gallery[i]);
            $(this).fadeIn(2000);
        });
    }, 5000);
});