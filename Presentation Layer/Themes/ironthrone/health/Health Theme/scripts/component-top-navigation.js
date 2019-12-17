XA.component.topNavigation = (function ($) {
    var topNavigation = {};

    topNavigation.initInitialized = function (component) {
        topNavigation.toggleDropdown(component);
    }

    topNavigation.toggleDropdown = function (component) {
        var dropdown = component.find(".dropdown-list");
        var contact = component.find(".top-nav-contact");

        dropdown.find("ul").append("<li class='" + contact.attr("class") + " active'>" + contact.text() + "</li>");
        dropdown.find("h3").on("click", function () {
            dropdown.toggleClass("active");
        });        
    }

    topNavigation.init = function () {
        var $topNav = $(".top-nav:not(initialized)");
        $topNav.each(function () {
            var instance = $(this);
            topNavigation.initInitialized(instance);
            $(this).addClass("initialized");
        });
    }

    return topNavigation;
}(jQuery, document));

XA.register("top-nav", XA.component.topNavigation);