document.addEventListener('DOMContentLoaded', () => {
    window.compareLanding = new Vue({
        el: '#compare-landing',
        router: new VueRouter({
            mode: "history"
        }),
        data: {
            selectedProducts: []
        },
        mounted: function () {
            var query = this.$route.fullPath.replace(this.$route.path, "");

            this.$http.get(`/api/compare/products${query}`)
                .then(response => {
                    console.log(response);
                    this.selectedProducts = response.data.Products;
                }).catch((error) => {
                    console.log(error);
                });
        }
    });
}); 