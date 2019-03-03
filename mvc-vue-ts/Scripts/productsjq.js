var products = $("#products-list")[0].children;
var showProducts = false;

console.log(new URL(window.location.href));


if (!($('input[name=category]').is(':checked')) && $("#search-input").val() === '') {
    $("#search-input").hide();
    $("#products-list").hide();
}



$('input[name=category]').on('change', function (radioInput) {
    console.log('category-input');
    $("#search-input").show();
    $("#products-list").show();
    const categoryName = radioInput.target.value;
    let url = new URL(window.location.href);
    url.searchParams.set('category', categoryName);
    window.history.pushState(null, null, url);
    for (var i = 0; i < products.length; i++) {
        const productCategory = products[i].dataset.category;
        if (productCategory.toLowerCase().match(categoryName.toLowerCase())) {
            $('#' + i).show();
        } else {
            $('#' + i).hide();
        }
    }

});

$("#search-input").on('input', function (searchInput) {
    console.log('search-input');
    $('input[name="category"]').prop('checked', false);
    const searchValue = searchInput.target.value;
    let url = new URL(window.location.href);
    url.searchParams.delete('category');
    url.searchParams.set('search', searchValue);
    window.history.pushState(null, null, url);
    for (var i = 0; i < products.length; i++) {
        const productName = products[i].dataset.name;
        if (productName.toLowerCase().match(searchValue.toLowerCase())) {
            $('#' + i).show();
        } else {
            $('#' + i).hide();
        }
    }
});

$('input[name=f1]').on('change', function (checkBox) {
    console.log('f1-input');
    const filter = checkBox.target.value;
    for (var i = 0; i < products.length; i++) {
        const productCategory = products[i].dataset.category;
        if (productCategory.toLowerCase().match(filter.toLowerCase())) {
            $('#' + i).show();
        } else {
            $('#' + i).hide();
        }
    }

});

$(window).on("popstate", function () {
    // if the state is the page you expect, pull the name and load it.
        console.log('back');
});

