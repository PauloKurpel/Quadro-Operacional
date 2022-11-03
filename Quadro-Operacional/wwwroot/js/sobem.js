jQuery(document).ready(function() {

    // jQuery("#subirTopo").hide();

    jQuery('a#subirTopo').click(function() {
        jQuery('body,html').animate({
            scrollTop: 0
        }, 900);
        return false;
    });
});