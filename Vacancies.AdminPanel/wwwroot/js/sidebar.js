﻿(function ($) {
    "use strict";

    /*-------------------------------------
        Sidebar Toggle Menu
      -------------------------------------*/
    $('.sidebar-toggle-view').on('click', '.sidebar-nav-item .nav-link', function (e) {
        if (!$(this).parents('#wrapper').hasClass('sidebar-collapsed')) {
            var animationSpeed = 300,
                subMenuSelector = '.sub-group-menu',
                $this = $(this),
                checkElement = $this.next();
            if (checkElement.is(subMenuSelector) && checkElement.is(':visible')) {
                checkElement.slideUp(animationSpeed, function () {
                    checkElement.removeClass('menu-open');
                });
                checkElement.parent(".sidebar-nav-item").removeClass("active");
            } else if ((checkElement.is(subMenuSelector)) && (!checkElement.is(':visible'))) {
                var parent = $this.parents('ul').first();
                var ul = parent.find('ul:visible').slideUp(animationSpeed);
                ul.removeClass('menu-open');
                var parent_li = $this.parent("li");
                checkElement.slideDown(animationSpeed, function () {
                    checkElement.addClass('menu-open');
                    parent.find('.sidebar-nav-item.active').removeClass('active');
                    parent_li.addClass('active');
                });
            }
            if (checkElement.is(subMenuSelector)) {
                e.preventDefault();
            }
        } else {
            if ($(this).attr('href') === "#") {
                e.preventDefault();
            }
        }
    });

    /*-------------------------------------
        Sidebar Menu Control
      -------------------------------------*/
    $(".sidebar-toggle").on("click", function () {
        window.setTimeout(function () {
            $("#wrapper").toggleClass("sidebar-collapsed");
        }, 500);
    });

    /*-------------------------------------
        Sidebar Menu Control Mobile
      -------------------------------------*/
    $(".sidebar-toggle-mobile").on("click", function () {
        $("#wrapper").toggleClass("sidebar-collapsed-mobile");
        if ($("#wrapper").hasClass("sidebar-collapsed")) {
            $("#wrapper").removeClass("sidebar-collapsed");
        }
    });

    /*-------------------------------------
        jquery Scollup activation code
     -------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: "linear",
        scrollSpeed: 900,
        animation: "fade"
    });

    /*-------------------------------------
        jquery Scollup activation code
      -------------------------------------*/
    $("#preloader").fadeOut("slow", function () {
        $(this).remove();
    });

    $(function () {
        /*-------------------------------------
              Data Table init
          -------------------------------------*/
        if ($.fn.DataTable !== undefined) {
            $('.data-table').DataTable({
                paging: true,
                searching: false,
                info: false,
                lengthChange: false,
                lengthMenu: [20, 50, 75, 100],
                columnDefs: [{
                    targets: [0, -1], // column or columns numbers
                    orderable: false // set orderable for selected columns
                }],
            });
        }

    })

})(jQuery);