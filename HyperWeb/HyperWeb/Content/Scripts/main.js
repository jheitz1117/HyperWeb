require(['jquery'], function ($) {
    $("#site-nav .nav.navbar-nav li>a").click(function () {
        // Setting the active nav item immediately makes the site appear more responsive
        $("#site-nav .nav.navbar-nav li").removeClass("active");
        $(this).parent("li").addClass("active");
    });
});
