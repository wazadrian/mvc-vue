var index = new Vue({
    el: '#products',
    data: {
        loading: true,
        error: false,
        products: [
            { name: 'pr_1', image: 'img', pdfUrl1: 'pdfUrl1', pdfUrl2: 'pdfurl2' },
            { name: 'pr_2', image: 'img', pdfUrl1: 'pdfUrl1', pdfUrl2: 'pdfurl2' },
            { name: 'pr_3', image: 'img', pdfUrl1: 'pdfUrl1', pdfUrl2: 'pdfurl2' },
            { name: 'pr_4', image: 'img', pdfUrl1: 'pdfUrl1', pdfUrl2: 'pdfurl2' },
            { name: 'pr_5_', image: 'img', pdfUrl1: 'pdfUrl1', pdfUrl2: 'pdfurl2' }
        ]
    },
    mounted () {
       axios.get('/products/getproducts')
           .then(response => {
               this.products = response.data;
               console.log(this.products);
            })
            .catch(error => {
                console.log(error);
                this.error = true;
            })
            .finally(() => this.loading = false);
  }
});