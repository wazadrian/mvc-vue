var index = new Vue({
    el: '#products',
    data: {
        loading: true,
        error: false,
        products: [],
        productsToShow: [],
        searchInput: '',
        category: '',
        showItems: false,
        f1: false,
        f2: false,
        f3: false
    },
    mounted() {
       axios.get('/products/getproducts')
           .then(response => {
               this.products = response.data;
               this.productsToShow = response.data;
               console.log(response.data);
            })
            .catch(error => {
                console.log(error);
                this.error = true;
            })
            .finally(() => this.loading = false);
    },
    watch: {
        searchInput: function (val) {
            console.log('searchInput');
            this.productsToShow = this.products.filter((product) => {
                return product.Name.toLowerCase().match(val.toLowerCase());
            });
        },
        category: function (val) {
            console.log('category');
            this.showItems = true;
            this.productsToShow = this.products.filter((product) => {
                return product.Category.toLowerCase().match(val.toLowerCase());
            });
        }

    }
});