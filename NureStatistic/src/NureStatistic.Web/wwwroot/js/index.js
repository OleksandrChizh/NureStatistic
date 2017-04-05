(function ($, cookiemanager) {
    var startPageUrl = "/Home/IndexContent";
    var urlBeforePageUpdatingCookieName = "url-before-page-updating";
    var wasPageUpdating = false;
    var previousUrl;
    var contentWrapper = $("[data-is-content-wrapper]");

    $("[data-is-submenu-buttons-list] a").on("click",
        function (event) {
            var target = event.target;
            var url = target.href;

            if (wasPageUpdating || url !== previousUrl) {
                wasPageUpdating = false;
                contentWrapper.load(url);
                previousUrl = url;

                if (url.includes(startPageUrl))
                {
                    url = url.replace(startPageUrl, "");
                }

                window.history.pushState(null, null, url);
            }
        });

    setupContentWrapper(contentWrapper);

    function setupContentWrapper(contentWrapper) {
        var urlBeforePageUpdating = cookiemanager.getCookie(urlBeforePageUpdatingCookieName);
        if (urlBeforePageUpdating == undefined) {
            contentWrapper.load(startPageUrl);
        } else {
            var selectedButtonBeforePageUpdating = $("[data-is-submenu-buttons-list] a[href='" + urlBeforePageUpdating + "']");
            wasPageUpdating = true;
            selectedButtonBeforePageUpdating.click();
            $("[data-is-submenu-buttons-list] a").removeClass("active");
            selectedButtonBeforePageUpdating.addClass("active");

            cookiemanager.deleteCookie(urlBeforePageUpdatingCookieName);
        }
    }

})(jQuery, cookiemanager);